Public Class clMovimiento
    Private _idmov As Long
    Private _codpro As String
    Private _producto As String
    Private _codAlmacen As String
    Private _unidades As Double
    Private _precio As Double
    Private _neto As Double
    Private _descuento1 As Double
    Private _textoextra1 As String
    Private _impuesto1 As Double
    Private _porcenimpuesto1 As Double
    Private _impuesto2 As Double
    Private _porcenimpuesto2 As Double
    Private _impuesto3 As Double
    Private _porcenimpuesto3 As Double

    Private _retencion1 As Double
    Private _porcenretencion1 As Double

    Private _retencion2 As Double
    Private _porcenretencion2 As Double

    Private _porcen6 As Double

    Private _segmento As String

    'ublic PARA SALDAR DOCUMENTOS CUANDO ES TIPO CARGOABONO
    Private _codconceptopagar As String
    Private _nomconceptopagar As String
    Private _seriepagar As String
    Private _foliopagar As String
    Private _importe As Double
    Private _pendiente As Double
    Private _fechavencimiento As String
    Private _fechapago As String

    ''DATO PARA DEVOLUCIONES
    Private _totaldocumento As Double

    ''DATOS PARA CONSTRUCTOR
    Private _validado As Integer '0-Sin Error,1-Erro en precio,2-Eror en presupuesto total
    Private _idprecio As Integer
    Private _total As Double
    Private _totalpresupuesto As Double
    Private _cantidaddisponible As Integer

    Public Property Idmov As Long
        Get
            Return _idmov
        End Get
        Set(value As Long)
            _idmov = value
        End Set
    End Property

    Public Property Codpro As String
        Get
            Return _codpro
        End Get
        Set(value As String)
            _codpro = value
        End Set
    End Property

    Public Property Producto As String
        Get
            Return _producto
        End Get
        Set(value As String)
            _producto = value
        End Set
    End Property

    Public Property CodAlmacen As String
        Get
            Return _codAlmacen
        End Get
        Set(value As String)
            _codAlmacen = value
        End Set
    End Property

    Public Property Unidades As Double
        Get
            Return _unidades
        End Get
        Set(value As Double)
            _unidades = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
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

    Public Property Textoextra1 As String
        Get
            Return _textoextra1
        End Get
        Set(value As String)
            _textoextra1 = value
        End Set
    End Property

    Public Property Impuesto1 As Double
        Get
            Return _impuesto1
        End Get
        Set(value As Double)
            _impuesto1 = value
        End Set
    End Property

    Public Property Porcenimpuesto1 As Double
        Get
            Return _porcenimpuesto1
        End Get
        Set(value As Double)
            _porcenimpuesto1 = value
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

    Public Property Porcenimpuesto2 As Double
        Get
            Return _porcenimpuesto2
        End Get
        Set(value As Double)
            _porcenimpuesto2 = value
        End Set
    End Property

    Public Property Impuesto3 As Double
        Get
            Return _impuesto3
        End Get
        Set(value As Double)
            _impuesto3 = value
        End Set
    End Property

    Public Property Porcenimpuesto3 As Double
        Get
            Return _porcenimpuesto3
        End Get
        Set(value As Double)
            _porcenimpuesto3 = value
        End Set
    End Property

    Public Property Retencion1 As Double
        Get
            Return _retencion1
        End Get
        Set(value As Double)
            _retencion1 = value
        End Set
    End Property

    Public Property Porcenretencion1 As Double
        Get
            Return _porcenretencion1
        End Get
        Set(value As Double)
            _porcenretencion1 = value
        End Set
    End Property

    Public Property Retencion2 As Double
        Get
            Return _retencion2
        End Get
        Set(value As Double)
            _retencion2 = value
        End Set
    End Property

    Public Property Porcenretencion2 As Double
        Get
            Return _porcenretencion2
        End Get
        Set(value As Double)
            _porcenretencion2 = value
        End Set
    End Property

    Public Property Porcen6 As Double
        Get
            Return _porcen6
        End Get
        Set(value As Double)
            _porcen6 = value
        End Set
    End Property

    Public Property Segmento As String
        Get
            Return _segmento
        End Get
        Set(value As String)
            _segmento = value
        End Set
    End Property

    Public Property Codconceptopagar As String
        Get
            Return _codconceptopagar
        End Get
        Set(value As String)
            _codconceptopagar = value
        End Set
    End Property

    Public Property Nomconceptopagar As String
        Get
            Return _nomconceptopagar
        End Get
        Set(value As String)
            _nomconceptopagar = value
        End Set
    End Property

    Public Property Seriepagar As String
        Get
            Return _seriepagar
        End Get
        Set(value As String)
            _seriepagar = value
        End Set
    End Property

    Public Property Foliopagar As String
        Get
            Return _foliopagar
        End Get
        Set(value As String)
            _foliopagar = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _importe
        End Get
        Set(value As Double)
            _importe = value
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

    Public Property Fechavencimiento As String
        Get
            Return _fechavencimiento
        End Get
        Set(value As String)
            _fechavencimiento = value
        End Set
    End Property

    Public Property Fechapago As String
        Get
            Return _fechapago
        End Get
        Set(value As String)
            _fechapago = value
        End Set
    End Property

    Public Property Totaldocumento As Double
        Get
            Return _totaldocumento
        End Get
        Set(value As Double)
            _totaldocumento = value
        End Set
    End Property

    Public Property Validado As Integer
        Get
            Return _validado
        End Get
        Set(value As Integer)
            _validado = value
        End Set
    End Property

    Public Property Idprecio As Integer
        Get
            Return _idprecio
        End Get
        Set(value As Integer)
            _idprecio = value
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

    Public Property Totalpresupuesto As Double
        Get
            Return _totalpresupuesto
        End Get
        Set(value As Double)
            _totalpresupuesto = value
        End Set
    End Property

    Public Property Cantidaddisponible As Integer
        Get
            Return _cantidaddisponible
        End Get
        Set(value As Integer)
            _cantidaddisponible = value
        End Set
    End Property
End Class
