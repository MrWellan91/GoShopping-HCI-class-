Public Class Trip
    Dim dateTrip As Date
    Property tripLocation As String

#Region "Constructor"
    Public Sub New()
        TripDate = New Date()
        Location = "Sun"
    End Sub

    Public Sub New(ByVal dt As Date, ByVal location As String)
        TripDate = dt
        Me.Location = location
    End Sub
#End Region

#Region "Properties"
    Public Property TripDate As Date
        Get
            Return dateTrip
        End Get
        Set(value As Date)
            dateTrip = value
        End Set
    End Property

    Public Property Location As String
        Get
            Return tripLocation
        End Get
        Set(value As String)
            tripLocation = value
        End Set
    End Property
#End Region
End Class
