Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Liste
    Public name As String
    Public items As New Hashtable()

    Public Sub New(name As String)
        Me.name = name
    End Sub

    Public Sub New(name As String, ByVal items As Hashtable)
        Me.name = name
        Me.items = items
    End Sub

    Public Overloads Shared Sub twList(ByRef tw As TreeView, ByRef filePath As String)
        Dim json = File.ReadAllText(filePath)
        Dim obj As JObject = JObject.Parse(json)
    End Sub

    'Default function that will load the default item list (resources/marketList.txt)
    Public Overloads Shared Sub twList(ByRef tw As TreeView)
        Dim json As String
        Try
            json = My.Resources.marketList
        Catch ex As Exception
            Console.WriteLine("Erreur")
            Console.WriteLine(ex.GetBaseException)
            json = "{ ""erreur"" : ""erreur"" }"
        End Try

        Dim jsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
        Dim listJsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(jsonObject("List").ToString)

        Dim defaultListe As Liste = jsonToListe(listJsonObject)

        Dim nodes = jsonToNodeTree(listJsonObject)
        tw.Nodes.Add(nodes)
    End Sub

    'Convert json file to a TreeNode
    Public Shared Function jsonToNodeTree(ByVal obj As JObject) As TreeNode
        Dim parent As TreeNode = New TreeNode() 'parent node
        For Each token In obj
            parent.Text = token.Key.ToString()
            Dim child As TreeNode = New TreeNode()

            child.Text = token.Key.ToString()
            If token.Value.Type.ToString = "Object" Then
                Dim o As JObject = CType(token.Value, JObject)
                child = jsonToNodeTree(o)
                child.Text = token.Key.ToString()
                parent.Nodes.Add(child)
            ElseIf (token.Value.Type.ToString() = "Array") Then
                Dim index = -1
                For Each item In token.Value
                    If item.Type.ToString() = "Object" Then
                        Dim objTn As TreeNode = New TreeNode()
                        index = index + 1
                        Dim o As JObject = CType(item, JObject)
                        objTn = jsonToNodeTree(o)
                        objTn.Text = token.Key.ToString() + "[" + index + "]"
                        child.Nodes.Add(objTn)
                    ElseIf item.Type.ToString() = "Array" Then
                        index = index + 1
                        Dim dataArray As TreeNode = New TreeNode()
                        For Each donnee In item
                            dataArray.Text = token.Key.ToString() + "[" + index + "]"
                            dataArray.Nodes.Add(donnee.ToString())
                        Next
                        child.Nodes.Add(dataArray)
                    Else
                        child.Nodes.Add(item.ToString())
                    End If
                Next
                parent.Nodes.Add(child)
            Else
                If token.Value.ToString() = "" Then
                    child.Nodes.Add("Empty")
                Else
                    child.Nodes.Add(token.Value.ToString())
                End If
                parent.Nodes.Add(child)
            End If
        Next
        Return parent
    End Function

    Public Shared Function jsonToListe(ByVal obj As JObject) As Liste
        Dim cat As New List(Of String)
        Dim itemHash As New Hashtable()

        For Each gl In obj.Children
            For Each gm In gl.Children
                For Each gk In gm.Children
                    Dim word = gk.Children.Last
                    itemHash.Add(gk.Path, word)
                Next
            Next
        Next

        Return New Liste("oui", itemHash)
    End Function

End Class
