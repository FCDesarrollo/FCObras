Public Class clDocumento
    Private _iddoc As Long
    Private _idcliente As Long
    Private _codcliente As String
    Private _nomcliente As String
    Private _idsucursal As Integer
    Private _nomempresa As String
    Private _fechadocto As String
    Private _idconcepto As Long
    Private _codconcepto As String

    Private _nomconcepto As String
    Private _serie As String
    Private _folio As String
    Private _total As Double
    Private _asociado As Boolean
    Private _cancelado As Integer
    Private _fechavencimiento As String
    Private _pendiente As Double
    Private _idmoneda As Integer
    Private _tipocambio As Double
    Private _referencia As String
    Private _observaciones As String

    Private _neto As Double
    Private _descuento1 As Double
    Private _iva As Double
    Private _ish As Double
    Private _retiva As Double
    Private _retIeps As Double

    Private _impuesto2 As Double ''IEPS

    Private _dColMovimientos As New Collection

    Private _iddocumentode As Long

    ''dato para el construccion
    Private _idobra As Integer

    Public Property Iddoc As Long
        Get
            Return _iddoc
        End Get
        Set(value As Long)
            _iddoc = value
        End Set
    End Property

    Public Property Idcliente As Long
        Get
            Return _idcliente
        End Get
        Set(value As Long)
            _idcliente = value
        End Set
    End Property

    Public Property Codcliente As String
        Get
            Return _codcliente
        End Get
        Set(value As String)
            _codcliente = value
        End Set
    End Property

    Public Property Nomcliente As String
        Get
            Return _nomcliente
        End Get
        Set(value As String)
            _nomcliente = value
        End Set
    End Property

    Public Property Idsucursal As Integer
        Get
            Return _idsucursal
        End Get
        Set(value As Integer)
            _idsucursal = value
        End Set
    End Property

    Public Property Nomempresa As String
        Get
            Return _nomempresa
        End Get
        Set(value As String)
            _nomempresa = value
        End Set
    End Property

    Public Property Fechadocto As String
        Get
            Return _fechadocto
        End Get
        Set(value As String)
            _fechadocto = value
        End Set
    End Property

    Public Property Idconcepto As Long
        Get
            Return _idconcepto
        End Get
        Set(value As Long)
            _idconcepto = value
        End Set
    End Property

    Public Property Codconcepto As String
        Get
            Return _codconcepto
        End Get
        Set(value As String)
            _codconcepto = value
        End Set
    End Property

    Public Property Nomconcepto As String
        Get
            Return _nomconcepto
        End Get
        Set(value As String)
            _nomconcepto = value
        End Set
    End Property

    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property

    Public Property Folio As String
        Get
            Return _folio
        End Get
        Set(value As String)
            _folio = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

    Public Property Asociado As Boolean
        Get
            Return _asociado
        End Get
        Set(value As Boolean)
            _asociado = value
        End Set
    End Property

    Public Property Cancelado As Integer
        Get
            Return _cancelado
        End Get
        Set(value As Integer)
            _cancelado = value
        End Set
    End Property

    Public Property Fechavencimiento As String
        Get
            Return _fechavencimiento
        End Get
        Set(value As String)
            _fechavencimiento = value
        End Set
    End Property

    Public Property Pendiente As Double
        Get
            Return _pendiente
        End Get
        Set(value As Double)
            _pendiente = value
        End Set
    End Property

    Public Property Idmoneda As Integer
        Get
            Return _idmoneda
        End Get
        Set(value As Integer)
            _idmoneda = value
        End Set
    End Property

    Public Property Tipocambio As Double
        Get
            Return _tipocambio
        End Get
        Set(value As Double)
            _tipocambio = value
        End Set
    End Property

    Public Property Referencia As String
        Get
            Return _referencia
        End Get
        Set(value As String)
            _referencia = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _observaciones
        End Get
        Set(value As String)
            _observaciones = value
        End Set
    End Property

    Public Property Neto As Double
        Get
            Return _neto
        End Get
        Set(value As Double)
            _neto = value
        End Set
    End Property

    Public Property Descuento1 As Double
        Get
            Return _descuento1
        End Get
        Set(value As Double)
            _descuento1 = value
        End Set
    End Property

    Public Property Iva As Double
        Get
            Return _iva
        End Get
        Set(value As Double)
            _iva = value
        End Set
    End Property

    Public Property Ish As Double
        Get
            Return _ish
        End Get
        Set(value As Double)
            _ish = value
        End Set
    End Property

    Public Property Retiva As Double
        Get
            Return _retiva
        End Get
        Set(value As Double)
            _retiva = value
        End Set
    End Property

    Public Property RetIeps As Double
        Get
            Return _retIeps
        End Get
        Set(value As Double)
            _retIeps = value
        End Set
    End Property

    Public Property Impuesto2 As Double
        Get
            Return _impuesto2
        End Get
        Set(value As Double)
            _impuesto2 = value
        End Set
    End Property

    Public Property DColMovimientos As Collection
        Get
            Return _dColMovimientos
        End Get
        Set(value As Collection)
            _dColMovimientos = value
        End Set
    End Property

    Public Property Iddocumentode As Long
        Get
            Return _iddocumentode
        End Get
        Set(value As Long)
            _iddocumentode = value
        End Set
    End Property

    Public Property Idobra As Integer
        Get
            Return _idobra
        End Get
        Set(value As Integer)
            _idobra = value
        End Set
    End Property
End Class
