Imports System.IO
Imports GoShopping
Imports Newtonsoft.Json

Public Class Liste

#Region "Attributes"
    Dim name As String
    Dim cats As New List(Of Category)
    Dim tripPlanned As New Trip
#End Region

#Region "Constructor"
    ''' <summary>
    ''' Constructor with a list of categories
    ''' </summary>
    ''' <param name="listName"></param>
    ''' <param name="catList"></param>
    ''' Useless for the time being
    Public Sub New(ByVal listName As String, ByRef catList As List(Of Category))
        Me.name = listName
        cats.AddRange(catList)
        Me.Trip = New Trip()
    End Sub

    ''' <summary>
    ''' Constructor of an empty list
    ''' </summary>
    ''' <param name="listName"></param>
    Public Sub New(ByVal listName As String)
        Me.name = listName
        Dim l As Liste = jsonToListe(My.Resources.marketList)
        cats.AddRange(l.cats)
        Me.Trip = New Trip()
        For Each c In cats
            Category.emptyItems(c)
        Next
    End Sub

    ''' <summary>
    ''' Constructor of a list with one category
    ''' </summary>
    ''' <param name="listName"></param>
    ''' <param name="cat"></param>
    Public Sub New(ByVal listName As String, ByVal cat As Category)
        Me.name = listName
        cats.Add(cat)
        Me.Trip = New Trip()
    End Sub

    Public Sub New(ByVal listName As String, ByVal tp As Trip)
        Me.name = listName
        Dim l As Liste = jsonToListe(My.Resources.marketList)
        cats.AddRange(l.cats)
        Me.Trip = New Trip()
        For Each c In cats
            Category.emptyItems(c)
        Next
        Me.Trip = tp
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
        Me.cats.Add(category)
        Categories.Sort()
    End Sub

    ''' <summary>
    ''' Remove a category from the liste
    ''' </summary>
    ''' <param name="category"></param>
    Public Sub removeCategory(ByRef category As Category)
        Me.cats.Remove(category)
    End Sub

    ''' <summary>
    ''' Add an item to the category
    ''' </summary>
    ''' <param name="category"></param>
    ''' <param name="item"></param>
    Public Sub addItem(ByRef category As Category, ByVal item As Item)
        category.addItem(item)
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
    ''' <param name="json">Json string</param>
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

    ''' <summary>
    ''' Returns a json String from a json file
    ''' </summary>
    ''' <param name="jsonPath"></param>
    ''' <returns></returns>
    Public Shared Function fileToJson(ByVal jsonPath As String) As String
        Dim json As String
        Try
            json = File.ReadAllText(jsonPath)
        Catch ex As Exception
            Console.WriteLine("Erreur")
            Console.WriteLine(ex.GetBaseException)
            json = "null"
        End Try

        Return json
    End Function

    ''' <summary>
    ''' Convert a list to a treenode
    ''' </summary>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function listeToTreenode(ByRef list As Liste) As TreeNode
        Dim parent As New TreeNode
        parent.Text = list.ListName + " - " + list.Trip.Location + " - " + list.Trip.TripDate.ToShortDateString
        parent.Name = list.ListName
        'Loop throuh the categories of the list
        For Each c In list.cats
            parent.Nodes.Add(Category.categoryToTreenode(c))
        Next

        Return parent
    End Function

    ''' <summary>
    ''' Returns an item from a the list
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Function getItem(ByVal name As String) As Item
        Dim item As New Item
        For Each c In Me.cats
            Dim it As Item = c.getItem(name)
            If Not IsNothing(it) Then
                item = it
            End If
        Next

        Return item
    End Function

    ''' <summary>
    ''' get item via its id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function getItemId(ByVal id As Integer, ByRef cat As String) As Item
        Dim item As New Item
        For Each c In Me.cats

            Dim it As Item = c.getItemId(id, cat)
            If Not IsNothing(it) And it.ItemId <> 0 Then
                cat = cat + "\" + c.CategoryName
                Return it
            End If
        Next

        Return item
    End Function

    ''' <summary>
    ''' Get a category via its name
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Function getCategory(ByVal name As String) As Category
        Return cats.Find(Function(x)
                             Return x.CategoryName = name
                         End Function)
    End Function

    ''' <summary>
    ''' Returns in a list all the items of the list
    ''' </summary>
    ''' <returns></returns>
    Public Function getAllItems() As List(Of Item)
        Dim list As New List(Of Item)
        For Each c In cats
            c.getAllItems(list)
        Next
        Return list
    End Function

    ''' <summary>
    ''' Return the number of items of a list
    ''' </summary>
    ''' <returns></returns>
    Public Function getNbItem() As Integer
        Return getAllItems().Count
    End Function

    ''' <summary>
    ''' Returns the total price without taxes of the items of the list
    ''' </summary>
    ''' <returns></returns>
    Public Function totalSum() As Double
        Dim total As Double = 0
        For Each item In getAllItems()
            total = total + item.Price
        Next

        Return total
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

    Public Property Trip As Trip
        Get
            Return tripPlanned
        End Get
        Set(value As Trip)
            tripPlanned = value
        End Set
    End Property

    Public Property Categories As List(Of Category)
        Get
            Return cats
        End Get
        Set(value As List(Of Category))
            cats = value
        End Set
    End Property



#End Region

End Class
