Public Class clEmpresa
    Private _idempresa As Integer
    Private _nombreempresa As String
    Private _bddCont As String

    Private _colSucursales As New Collection
    Public Property Idempresa As Integer
        Get
            Return _idempresa
        End Get
        Set(value As Integer)
            _idempresa = value
        End Set
    End Property

    Public Property Nombreempresa As String
        Get
            Return _nombreempresa
        End Get
        Set(value As String)
            _nombreempresa = value
        End Set
    End Property

    Public Property BddCont As String
        Get
            Return _bddCont
        End Get
        Set(value As String)
            _bddCont = value
        End Set
    End Property

    Public Property ColSucursales As Collection
        Get
            Return _colSucursales
        End Get
        Set(value As Collection)
            _colSucursales = value
        End Set
    End Property
End Class
