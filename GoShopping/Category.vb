Public Class Category
    Dim name As String
    Dim items As New List(Of Item)
    Dim subCats As New List(Of Category)

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
    ''' <param name="upCat"></param>
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
    End Sub

    ''' <summary>
    ''' Remove an item from the list
    ''' </summary>
    ''' <param name="item"></param>
    Public Sub removeItem(ByRef item As Item)
        Me.ItemList.Remove(item)
    End Sub

    ''' <summary>
    ''' Add a sub category
    ''' </summary>
    ''' <param name="cat"></param>
    Public Sub addCategory(ByRef cat As Category)
        Me.subCats.Add(cat)
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
                childNode.Nodes.Add(item.ItemName)
            Next
            childNode = categoryToTreenode(subCat)
            parent.Nodes.Add(childNode)
        Next

        For Each item In cat.ItemList
            parent.Nodes.Add(item.ItemName)
        Next

        Return parent
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
            items.AddRange(value)
        End Set
    End Property

    Public Property SubCategories As List(Of Category)
        Get
            Return subCats
        End Get
        Set(value As List(Of Category))
            subCats.AddRange(value)
        End Set
    End Property

#End Region

End Class
