Imports System.IO
Imports Newtonsoft.Json

Public Class Liste
    Dim name As String
    Dim cats As New List(Of Category)

#Region "Constructor"
    ''' <summary>
    ''' Constructor with a list of categories
    ''' </summary>
    ''' <param name="listName"></param>
    ''' <param name="catList"></param>
    Public Sub New(ByVal listName As String, ByRef catList As List(Of Category))
        Me.name = listName
        cats.AddRange(catList)
    End Sub

    ''' <summary>
    ''' Constructor of an empty list
    ''' </summary>
    ''' <param name="listName"></param>
    Public Sub New(ByVal listName As String)
        Me.name = listName
    End Sub

    ''' <summary>
    ''' Constructor of a list with one category
    ''' </summary>
    ''' <param name="listName"></param>
    ''' <param name="cat"></param>
    Public Sub New(ByVal listName As String, ByVal cat As Category)
        Me.name = listName
        cats.Add(cat)
    End Sub

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Me.name = "Empty List"
    End Sub
#End Region

#Region "Methods"
    ''' <summary>
    ''' Add a category to the list
    ''' </summary>
    ''' <param name="category"></param>
    Public Sub addCategory(ByVal category As Category)
        Me.Categories.Add(category)
    End Sub

    ''' <summary>
    ''' Remove a category from the liste
    ''' </summary>
    ''' <param name="category"></param>
    Public Sub removeCategory(ByRef category As Category)
        Me.Categories.Remove(category)
    End Sub

    ''' <summary>
    ''' Add an item to the category
    ''' </summary>
    ''' <param name="category"></param>
    ''' <param name="item"></param>
    Public Sub addItem(ByVal category As Category, ByVal item As Item)
        Me.Categories.Find(Function(x) x.CategoryName = category.CategoryName).addItem(item)
    End Sub

    ''' <summary>
    ''' Remove an item from the category
    ''' </summary>
    ''' <param name="category"></param>
    ''' <param name="item"></param>
    Public Sub removeItem(ByVal category As Category, ByVal item As Item)
        Me.Categories.Find(Function(x) x.CategoryName = category.CategoryName).removeItem(item)
    End Sub

    ''' <summary>
    ''' Returns the list in json format
    ''' </summary>
    ''' <returns>json as string</returns>
    Public Function listeToJson() As String
        Return JsonConvert.SerializeObject(Me)
    End Function

    ''' <summary>
    ''' Returns a list object from a json string, if error returns an empty list
    ''' </summary>
    ''' <param name="jsonPath">Path of the json file</param>
    ''' <returns></returns>
    Public Shared Function jsonToListe(ByVal json As String) As Liste
        Dim list
        Try
            list = JsonConvert.DeserializeObject(Of Liste)(json)
        Catch ex As JsonSerializationException
            list = New Liste()
        End Try

        Return list
    End Function

    Public Shared Function fileToJson(ByVal jsonPath As String) As String
        Dim json As String
        Dim list As Liste
        Try
            json = File.ReadAllText(jsonPath)
        Catch ex As Exception
            Console.WriteLine("Erreur")
            Console.WriteLine(ex.GetBaseException)
            json = "null"
        End Try

        Return json
    End Function

    Public Shared Function listeToTreenode(ByRef list As Liste) As TreeNode
        Dim parent As New TreeNode
        parent.Text = list.ListName
        parent.Name = list.ListName
        'Loop throuh the categories of the list
        For Each c In list.cats
            parent.Nodes.Add(Category.categoryToTreenode(c))
        Next

        Return parent
    End Function


#End Region

#Region "Properties"
    Public Property ListName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Categories As List(Of Category)
        Get
            Return cats
        End Get
        Set(value As List(Of Category))
            cats.AddRange(value)
        End Set
    End Property
#End Region
End Class
