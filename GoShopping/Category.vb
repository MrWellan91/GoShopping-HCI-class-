Public Class Category
    Implements IComparable(Of Category)

#Region "Attributes"
    Dim name As String
    Dim items As New List(Of Item)
    Dim subCats As New List(Of Category)
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Constructor when you add items to your category
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="itemList"></param>
    Public Sub New(ByVal name As String, ByRef itemList As List(Of Item))
        Me.name = name
        Me.items.AddRange(itemList)
    End Sub

    ''' <summary>
    ''' Constructor to add categories to your category
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="subCats"></param>
    Public Sub New(ByVal name As String, ByVal subCats As List(Of Category))
        Me.name = name
        Me.subCats.AddRange(subCats)
    End Sub

    ''' <summary>
    ''' Constructor with only a name
    ''' </summary>
    ''' <param name="name"></param>
    Public Sub New(ByVal name As String)
        Me.name = name
    End Sub

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Me.name = "Empty Category"
    End Sub
#End Region

#Region "Methods"
    ''' <summary>
    ''' Add an item to the list
    ''' </summary>
    ''' <param name="item"></param>
    Public Sub addItem(ByVal item As Item)
        Me.ItemList.Add(item)
        ItemList.Sort()
    End Sub

    ''' <summary>
    ''' Remove an item from the list
    ''' </summary>
    ''' <param name="item"></param>
    Public Sub removeItem(ByVal item As Item)
        Dim found = items.FindIndex(Function(x) x.ItemName = item.ItemName)
        If found <> -1 Then
            items.RemoveAt(found)
        End If
    End Sub

    ''' <summary>
    ''' Add a sub category
    ''' </summary>
    ''' <param name="cat"></param>
    Public Sub addCategory(ByRef cat As Category)
        Me.subCats.Add(cat)
        subCats.Sort()
    End Sub

    ''' <summary>
    ''' Remove a sub category
    ''' </summary>
    ''' <param name="cat"></param>
    Public Sub removeCategory(ByRef cat As Category)
        Me.subCats.Remove(cat)
    End Sub

    ''' <summary>
    ''' Recursive function that will loop to all sub categories return a child containing sub categories and items
    ''' </summary>
    ''' <param name="cat"></param>
    ''' <returns></returns>
    Public Shared Function categoryToTreenode(ByRef cat As Category) As TreeNode
        Dim parent As New TreeNode
        parent.Name = cat.CategoryName
        parent.Text = cat.CategoryName

        For Each subCat In cat.subCats
            Dim childNode As New TreeNode
            childNode.Name = subCat.CategoryName
            childNode.Text = subCat.CategoryName
            For Each item In subCat.items
                Dim itemNode As New TreeNode
                itemNode.Text = item.ItemName + " - " + item.Price.ToString() + " €"
                itemNode.Name = item.ItemName
                childNode.Nodes.Add(itemNode)
            Next
            childNode = categoryToTreenode(subCat)
            parent.Nodes.Add(childNode)
        Next

        For Each item In cat.ItemList
            Dim itemNode As New TreeNode
            itemNode.Text = item.ItemName + " - " + item.Price.ToString() + " €"
            itemNode.Name = item.ItemName

            parent.Nodes.Add(itemNode)
        Next

        Return parent
    End Function

    ''' <summary>
    ''' Return an item if it exists in a list
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Function getItem(ByVal name As String) As Item
        Dim item As New Item
        For Each i In items
            If i.ItemName = name Then
                Return i
            End If
        Next

        Return item
    End Function

    ''' <summary>
    ''' Get item via its id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function getItemId(ByVal id As Integer, ByRef cat As String) As Item
        Dim item As New Item

        For Each i In items
            If i.ItemId = id Then
                Return i
            End If
        Next

        For Each c In subCats
            For Each i In c.items
                If i.ItemId = id Then
                    cat = c.CategoryName
                    Return i
                End If
            Next
        Next



        Return item
    End Function


    ''' <summary>
    ''' Get category via its name
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Function getCategory(ByVal name As String) As Category
        Return subCats.Find(Function(x) x.CategoryName = name)
    End Function

    Public Shared Function getRecuCategory(ByVal name As String, ByRef categorie As Category) As Category
        Dim cat As New Category
        For Each s In categorie.subCats
            If s.CategoryName = name Then
                Return s
            End If

            cat = s.subCats.Find(Function(x) x.CategoryName = name)
            If Not IsNothing(cat) Then
                Return cat
            End If

            cat = getRecuCategory(name, s)
        Next

        Return cat
    End Function

    ''' <summary>
    ''' Empty the list
    ''' </summary>
    ''' <param name="categorie"></param>
    Public Shared Sub emptyItems(ByRef categorie As Category)
        For Each c In categorie.subCats
            c.items = New List(Of Item)
        Next
        categorie.items = New List(Of Item)
    End Sub

#End Region

#Region "IComparable"
    Public Function CompareTo(other As Category) As Integer _
        Implements IComparable(Of Category).CompareTo
        Return Me.CategoryName.CompareTo(other.CategoryName)
    End Function
#End Region

#Region "Properties"
    Public Property CategoryName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property ItemList As List(Of Item)
        Get
            Return items
        End Get
        Set(value As List(Of Item))
            items = value
        End Set
    End Property

    Public Property SubCategories As List(Of Category)
        Get
            Return subCats
        End Get
        Set(value As List(Of Category))
            subCats = value
        End Set
    End Property

#End Region

End Class
