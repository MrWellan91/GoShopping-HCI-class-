Public Class Item
    Implements IComparable(Of Item)
#Region "Attributes"
    Dim id As Integer
    Dim name As String
    Dim itemPrice As Double
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="price"></param>
    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal price As Double)
        Me.id = id
        Me.name = name
        Me.itemPrice = price
    End Sub

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Me.name = "No item"
        Me.id = 0
        Me.itemPrice = 0
    End Sub
#End Region

#Region "IComparable"
    Public Function CompareTo(other As Item) As Integer _
        Implements IComparable(Of Item).CompareTo
        Return Me.ItemName.CompareTo(other.ItemName)
    End Function
#End Region

#Region "Properties"
    Public Property ItemId As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property ItemName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property Price As Double
        Get
            Return itemPrice
        End Get
        Set(value As Double)
            itemPrice = value
        End Set
    End Property
#End Region
End Class
