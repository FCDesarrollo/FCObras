Public Class clSucursal
    Private _idsucursal As Integer
    Private _nombreAdw As String
    Private _nombresucursal As String
    Private _bddAdw As String
    Private _usacomercial As Integer

    Public Property Idsucursal As Integer
        Get
            Return _idsucursal
        End Get
        Set(value As Integer)
            _idsucursal = value
        End Set
    End Property

    Public Property NombreAdw As String
        Get
            Return _nombreAdw
        End Get
        Set(value As String)
            _nombreAdw = value
        End Set
    End Property

    Public Property Nombresucursal As String
        Get
            Return _nombresucursal
        End Get
        Set(value As String)
            _nombresucursal = value
        End Set
    End Property

    Public Property BddAdw As String
        Get
            Return _bddAdw
        End Get
        Set(value As String)
            _bddAdw = value
        End Set
    End Property

    Public Property Usacomercial As Integer
        Get
            Return _usacomercial
        End Get
        Set(value As Integer)
            _usacomercial = value
        End Set
    End Property
End Class
