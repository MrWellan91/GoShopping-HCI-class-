Public Class Item
    Dim name As String
    Dim itemPrice As Double

#Region "Constructors"
    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="price"></param>
    Public Sub New(ByVal name As String, ByVal price As Double)
        Me.name = name
        Me.itemPrice = price
    End Sub

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Me.name = "None item"
    End Sub
#End Region

#Region "Properties"
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
