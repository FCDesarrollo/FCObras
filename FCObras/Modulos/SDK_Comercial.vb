Imports System.Runtime.InteropServices
Imports System.Text

Module SDK_Comercial
    '   Descripción:        En este módulo se declaran las constantes, métodos,
    '                       y estructuras de datos del SDK de Comercial
    '
    '   Fecha de Creación:  20/06/2017
    '   Departamento:       Ingenia
    '   Autor:              Oscar Galvan
    '
    '   Actualización:
    '
    '--------------------------------------------------------------------------

    '___________________DECLARACIÓN DE CONSTANTES DE LONGITUD____________________
    '
    ' Se adiciona 1 (+ 1) a la longitud original contemplando
    ' el caracter nulo necesario al final de la cadena.
    Public Const kLongCodigo As Integer = 30 + 1
    Public Const kLongNombre As Integer = 60 + 1
    Public Const kLongNombreProducto As Integer = 255 + 1
    Public Const kLongFecha As Integer = 23 + 1
    Public Const kLongAbreviatura As Integer = 3 + 1
    Public Const kLongCodValorClasif As Integer = 3 + 1
    Public Const kLongTextoExtra As Integer = 50 + 1
    Public Const kLongNumSerie As Integer = 11 + 1
    Public Const kLongReferencia As Integer = 20 + 1
    Public Const kLongSeries As Integer = 30 + 1
    Public Const kLongDescripcion As Integer = 60 + 1
    Public Const kLongNumeroExtInt As Integer = 6 + 1
    Public Const kLongNumeroExpandido As Integer = 30 + 1
    Public Const kLongCodigoPostal As Integer = 6 + 1
    Public Const kLongTelefono As Integer = 15 + 1
    Public Const kLongEmailWeb As Integer = 50 + 1
    Public Const kLongRFC As Integer = 20 + 1
    Public Const kLongCURP As Integer = 20 + 1
    Public Const kLongDesCorta As Integer = 20 + 1
    Public Const kLongDenComercial As Integer = 50 + 1
    Public Const kLongRepLegal As Integer = 50 + 1
    Public Const kLogitudLugarExpedicion As Integer = 50 + 1


    '______________DEFINICIÓN DE LAS ESTRUCTRURAS DE DATOS DEL SDK_______________

    ' Registro para documentos
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi, Pack:=4)>
    Public Structure tDocumento
        Public aFolio As Double
        Public aNumMoneda As Integer
        Public aTipoCambio As Double
        Public aImporte As Double
        Public aDescuentoDoc1 As Double
        Public aDescuentoDoc2 As Double
        Public aSistemaOrigen As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodConcepto As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongNumSerie)> Public aSerie As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongFecha)> Public aFecha As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodigoCteProv As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodigoAgente As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongReferencia)> Public aReferencia As String
        Public aAfecta As Integer
        Public aGasto1 As Double
        Public aGasto2 As Double
        Public aGasto3 As Double
    End Structure

    ' Registro para la llave de documentos
    Public Structure tLlaveDocto
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodConcepto As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongNumSerie)> Public aSerie As String
        Public aFolio As Double
    End Structure

    ' Registro para Movimientos
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi, Pack:=4)>
    Public Structure tMovimiento
        Public aConsecutivo As Integer  ' Valor inicial debe ser 100 con incrementos de 100 en 100, por si es necesario insertar movtos intermedios
        Public aUnidades As Double   ' En caso de producto con series, lotes y/o pedimentos y carcateristicas este valor es cero
        Public aPrecio As Double     ' Usado para docuementos de venta
        Public aCosto As Double      ' Usado para docuemtnos de compra y/o inventarios
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodProdSer As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodAlmacen As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongReferencia)> Public aReferencia As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=kLongCodigo)> Public aCodClasificacion As String
    End Structure

    ' Registro para Movimientos con descuentos
    '    Public Type RegMovimientoCDesctos
    '  aConsecutivo As Long  ' Valor inicial debe ser 100 con incrementos de 100 en 100, por si es necesario insertar movtos intermedios
    '  aUnidades As Double   ' En caso de producto con series, lotes y/o pedimentos y carcateristicas este valor es cero
    '  aPrecio As Double     ' Usado para docuementos de venta
    '  aCosto As Double      ' Usado para docuemtnos de compra y/o inventarios
    '  aPorcDescto1 As Double
    '  aImporteDescto1 As Double
    '  aPorcDescto2 As Double
    '  aImporteDescto2 As Double
    '  aPorcDescto3 As Double
    '  aImporteDescto3 As Double
    '  aPorcDescto4 As Double
    '  aImporteDescto4 As Double
    '  aPorcDescto5 As Double
    '  aImporteDescto5 As Double
    '  aCodProdSer As String * kLongCodigo
    '  aCodAlmacen As String * kLongCodigo
    '  aReferencia As String * kLongReferencia
    '  aCodClasificacion As String * kLongCodigo ' No tiene uso, valor omision en blancos
    'End Type

    ' Registro para movimientos con series, lotes y pedimentos
    '    Public Type tSeriesCapas
    '  aUnidades As Double       ' Si es un producto con series este valor es cero
    '  aTipoCambio As Double
    '  aSeries As String * kLongSeries
    '  aPedimento As String * kLongDescripcion
    '  aAgencia As String * kLongDescripcion
    '  aFechaPedimento As String * kLongFecha    ' Formato mm/dd/aaaa
    '  aNumeroLote As String * kLongDescripcion
    '  aFechaFabricacion As String * kLongFecha  ' Formato mm/dd/aaaa
    '  aFechaCaducidad As String * kLongFecha    ' Formato mm/dd/aaaa
    'End Type

    '    ' Registro para Caracteristicas
    '    Public Type tCaracteristicas
    '  aUnidades As Double
    '  aValorCaracteristica1 As String * kLongDescripcion
    '  aValorCaracteristica2 As String * kLongDescripcion
    '  aValorCaracteristica3 As String * kLongDescripcion
    'End Type

    ' Registro para CaracteristicasUnidades
    '    Public Type tCaracteristicasUnidades
    '  aUnidad  As String * kLongAbreviatura
    '  aUnidades As Double
    '  aUnidadesNC As Double
    '  aValorCaracteristica1 As String * kLongDescripcion
    '  aValorCaracteristica2 As String * kLongDescripcion
    '  aValorCaracteristica3 As String * kLongDescripcion
    'End Type

    ' Registro para Tipo de Producto
    '    Public Type tTipoProducto
    '  aSeriesCapas As tSeriesCapas
    '  aCaracteristicas As tCaracteristicas
    'End Type

    ' Registro para Llave de Apertura de Caja
    '    Public Type tLlaveAper
    '  aCodCaja As String * kLongCodigo
    '  aFechaApe As String * kLongFecha
    'End Type

    ' Registro para Producto
    '    Public Type tProducto
    '  cCodigoProducto As String * kLongCodigo
    '  cNombreProducto As String * kLongNombre
    '  cDescripcionProducto As String * kLongNombreProducto
    '  cTipoProducto As Long       ' 1 = Producto, 2 = Paquete, 3 = Servicio
    '  cFechaAltaProducto As String * kLongFecha
    '  cFechaBaja As String * kLongFecha
    '  cStatusProducto As Long     ' 0 - Baja Lógica, 1 - Alta
    '  cControlExistencia As Long
    '  cMetodoCosteo As Long       ' 1 = Costo Promedio en Base a Entradas, 2 = Costo Promedio en Base a Entradas Almacen, 3 = Último costo, 4 = UEPS, 5 = PEPS, 6 = Costo específico, 7 = Costo Estandar
    '  cCodigoUnidadBase As String * kLongCodigo
    '  cCodigoUnidadNoConvertible As String * kLongCodigo
    '  cPrecio1 As Double
    '  cPrecio2 As Double
    '  cPrecio3 As Double
    '  cPrecio4 As Double
    '  cPrecio5 As Double
    '  cPrecio6 As Double
    '  cPrecio7 As Double
    '  cPrecio8 As Double
    '  cPrecio9 As Double
    '  cPrecio10 As Double
    '  cImpuesto1 As Double
    '  cImpuesto2  As Double
    '  cImpuesto3 As Double
    '  cRetencion1 As Double
    '  cRetencion2 As Double
    '  cNombreCaracteristica1 As String * kLongAbreviatura
    '  cNombreCaracteristica2 As String * kLongAbreviatura
    '  cNombreCaracteristica3 As String * kLongAbreviatura
    '  cCodigoValorClasificacion1 As String * kLongCodValorClasif
    '  cCodigoValorClasificacion2 As String * kLongCodValorClasif
    '  cCodigoValorClasificacion3 As String * kLongCodValorClasif
    '  cCodigoValorClasificacion4 As String * kLongCodValorClasif
    '  cCodigoValorClasificacion5 As String * kLongCodValorClasif
    '  cCodigoValorClasificacion6 As String * kLongCodValorClasif
    '  cTextoExtra1 As String * kLongTextoExtra
    '  cTextoExtra2 As String * kLongTextoExtra
    '  cTextoExtra3 As String * kLongTextoExtra
    '  cFechaExtra As String * kLongFecha
    '  cImporteExtra1 As Double
    '  cImporteExtra2 As Double
    '  cImporteExtra3 As Double
    '  cImporteExtra4 As Double
    'End Type

    ' Registro para Cliente/Proveedor
    'Public Type tClienteProveedor
    '  cCodigoCliente As String * kLongCodigo
    '  cRazonSocial As String * kLongNombre
    '  cFechaAlta As String * kLongFecha
    '  cRFC As String * kLongRFC
    '  cCURP As String * kLongCURP
    '  cDenComercial As String * kLongDenComercial
    '  cRepLegal As String * kLongRepLegal
    '  cNombreMoneda As String * kLongNombre
    '  cListaPreciosCliente As Long
    '  cDescuentoMovto As Double
    '  cBanVentaCredito As Long      ' 0 = No se permite venta a crédito, 1 = Se permite venta a crédito
    '  cCodigoValorClasificacionCliente1 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionCliente2 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionCliente3 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionCliente4 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionCliente5 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionCliente6 As String * kLongCodValorClasif
    '  cTipoCliente As Long          ' 1 - Cliente, 2 - Cliente/Proveedor, 3 - Proveedor
    '  cEstatus As Long              ' 0. Inactivo, 1. Activo
    '  cFechaBaja As String * kLongFecha
    '  cFechaUltimaRevision As String * kLongFecha
    '  cLimiteCreditoCliente As Double
    '  cDiasCreditoCliente As Long
    '  cBanExcederCredito As Long    ' 0 = No se permite exceder crédito, 1 = Se permite exceder el crédito
    '  cDescuentoProntoPago As Double
    '  cDiasProntoPago As Long
    '  cInteresMoratorio As Double
    '  cDiaPago As Long
    '  cDiasRevision As Long
    '  cMensajeria As String * kLongDesCorta
    '  cCuentaMensajeria As String * kLongDescripcion
    '  cDiasEmbarqueCliente As Long
    '  cCodigoAlmacen As String * kLongCodigo
    '  cCodigoAgenteVenta As String * kLongCodigo
    '  cCodigoAgenteCobro As String * kLongCodigo
    '  cRestriccionAgente As Long
    '  cImpuesto1 As Double
    '  cImpuesto2 As Double
    '  cImpuesto3 As Double
    '  cRetencionCliente1 As Double
    '  cRetencionCliente2 As Double
    '  cCodigoValorClasificacionProveedor1 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionProveedor2 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionProveedor3 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionProveedor4 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionProveedor5 As String * kLongCodValorClasif
    '  cCodigoValorClasificacionProveedor6 As String * kLongCodValorClasif
    '  cLimiteCreditoProveedor As Double
    '  cDiasCreditoProveedor As Long
    '  cTiempoEntrega As Long
    '  cDiasEmbarqueProveedor As Long
    '  cImpuestoProveedor1 As Double
    '  cImpuestoProveedor2 As Double
    '  cImpuestoProveedor3 As Double
    '  cRetencionProveedor1 As Double
    '  cRetencionProveedor2 As Double
    '  cBanInteresMoratorio As Long      ' 0 = No se le calculan intereses moratorios al cliente, 1 = Si se le calculan intereses moratorios al cliente.
    '  cTextoExtra1 As String * kLongTextoExtra
    '  cTextoExtra2 As String * kLongTextoExtra
    '  cTextoExtra3 As String * kLongTextoExtra
    '  cFechaExtra As String * kLongFecha
    '  cImporteExtra1 As Double
    '  cImporteExtra2 As Double
    '  cImporteExtra3 As Double
    '  cImporteExtra4 As Double
    'End Type

    ' Registro para Valores de clasificación
    '    Public Type tValorClasificacion
    '  cClasificacionDe As Long
    '  cNumClasificacion As Long
    '  cCodigoValorClasificacion As String * kLongCodValorClasif
    '  cValorClasificacion As String * kLongDescripcion
    'End Type

    '    ' Registro para Unidades de peso y medida
    '    Public Type tUnidad
    '  cNombreUnidad As String * kLongNombre
    '  cAbreviatura As String * kLongAbreviatura
    '  cDespliegue As String * kLongAbreviatura
    'End Type

    ' Registro para Direcciones

    '    Public Type Direccion
    '  cCodCteProv As String * kLongCodigo
    '  cTipoCatalogo As Long '1=Clientes y 2=Proveedores
    '  cTipoDireccion As Long '1=Domicilio Fiscal, 2=Domicilio Envio
    '  cNombreCalle As String * kLongDescripcion
    '  cNumeroExterior As String * kLongNumeroExpandido
    '  cNumeroInterior As String * kLongNumeroExpandido
    '  cColonia As String * kLongDescripcion
    '  cCodigoPostal As String * kLongCodigoPostal
    '  cTelefono1 As String * kLongTelefono
    '  cTelefono2 As String * kLongTelefono
    '  cTelefono3 As String * kLongTelefono
    '  cTelefono4 As String * kLongTelefono
    '  cEmail As String * kLongEmailWeb
    '  cDireccionWeb As String * kLongEmailWeb
    '  cCiudad As String * kLongDescripcion
    '  cEstado As String * kLongDescripcion
    '  cPais As String * kLongDescripcion
    '  cTextoExtra As String * kLongDescripcion
    'End Type

    '__________________DECLARACIÓN DE LAS FUNCIONES DEL SDK______________________

    ' ***** Funciones Generales del SDK *****
    ' Inicialización/Terminación

    Public Declare Function fSetNombrePAQ Lib "MGWSERVICIOS.DLL" (ByRef aNombrePAQ As String) As Integer
    Public Declare Function fAbreEmpresa Lib "MGWSERVICIOS.DLL" (ByVal aEmpresa As String) As Integer
    Public Declare Sub fCierraEmpresa Lib "MGWSERVICIOS.DLL" ()
    Public Declare Sub fTerminaSDK Lib "MGWSERVICIOS.DLL" ()
    Public Declare Sub fError Lib "MGWSERVICIOS.DLL" (ByVal aNumError As Integer, aMensaje As StringBuilder, ByVal aLen As Integer)

    Public Declare Function SetCurrentDirectory Lib "KERNEL32" Alias "SetCurrentDirectoryA" (ByVal pPtrDirActual As String) As Integer

    'Public Declare Sub fTerminaSDK Lib "MGWServicios.DLL" ()
    'Public Declare Function SetCurrentDirectory Lib "KERNEL32" Alias "SetCurrentDirectoryA" (ByVal pPtrDirActual As String) As Integer
    '' Manejo de errores
    'Public Declare Sub fError Lib "MGWServicios.DLL" (ByVal aNumError As Integer, ByVal aError As String, ByVal aLen As Integer)

    ' ***** Funciones de Empresas *****
    ' Navegación
    Declare Function fPosPrimerEmpresa Lib "MGWServicios.DLL" (ByRef aIdEmpresa As Long, ByVal aNombreEmpresa As String, ByVal aDirectorioEmpresa As String) As Long
    Declare Function fPosSiguienteEmpresa Lib "MGWServicios.DLL" (ByRef aIdEmpresa As Long, ByVal aNombreEmpresa As String, ByVal aDirectorioEmpresa As String) As Long
    ' Apertura/Cierre
    'Declare Function fAbreEmpresa Lib "MGWServicios.DLL" (ByVal aError As String) As Integer
    'Public Declare Sub fCierraEmpresa Lib "MGWServicios.DLL" ()
    ''Public Declare Function fSetNombrePAQ Lib "MGWServicios.DLL" (ByVal aNombrePAQ As String) As Integer
    'Public Declare Function fSetNombrePAQ Lib "MGWServicios.DLL" (ByVal aSistema As String) As Integer

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscarDocumento Lib "MGWServicios.DLL" (ByVal aCodConcepto As String, ByVal aSerie As String, ByVal aFolio As String) As Long
    Declare Function fBuscarIdDocumento Lib "MGWServicios.DLL" (ByVal aIdDocumento As Long) As Long

    Declare Function fPosPrimerDocumento Lib "MGWServicios.DLL" () As Long
    Declare Function fPosUltimoDocumento Lib "MGWServicios.DLL" () As Long
    Declare Function fPosSiguienteDocumento Lib "MGWServicios.DLL" () As Long
    Declare Function fPosAnteriorDocumento Lib "MGWServicios.DLL" () As Long



    ' Alto Nivel - Busqueda/Navegación
    Declare Function fBuscaDocumento Lib "MGWServicios.DLL" (ByRef aLlaveDocto As tLlaveDocto) As Long

    ' Documentos - Alto nivel
    Public Declare Function fSiguienteFolio Lib "MGWServicios.DLL" (ByVal aCodigoConcepto As String, ByVal aSerie As String, ByRef aFolio As Double) As Integer
    Public Declare Function fAltaDocumento Lib "MGWServicios.DLL" (ByRef aIdDocumento As Integer, ByRef lDocumento As tDocumento) As Integer
    Public Declare Function fEditarDocumento Lib "MGWServicios.DLL" () As Integer
    Public Declare Function fSetDatoDocumento Lib "MGWServicios.DLL" (ByVal aCampo As String, ByVal aValor As String) As Integer

    Public Declare Function fLeeDatoDocumento Lib "MGWServicios.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    Public Declare Function fGuardaDocumento Lib "MGWServicios.DLL" () As Integer



    ''DOCUMENTO     '''AGREGADAS 23/12/2019
    Public Declare Function fAltaDocumentoCargoAbono Lib "MGWServicios.DLL" (ByRef aDocto As tDocumento) As Long
    Public Declare Function fBorraDocumento Lib "MGWServicios.DLL" () As Long
    Public Declare Function fSaldarDocumento Lib "MGWServicios.DLL" (aDoctoaPagar As tLlaveDocto, aDoctoPago As tLlaveDocto, ByVal aImporte As Double, ByVal aIdMoneda As Long, ByVal aFecha As String) As Long



    'Public Declare Function fAltaCteProv Lib "MGWServicios.DLL" (ByRef aIdCteProv As Long, aCteProv As tClienteProveedor) As Long


    'Public Declare Function fAltaProducto Lib "MGWServicios.DLL" (ByRef aIdProducto As Long, aProducto As tProducto) As Long

    'Funciones de movimientos
    '<System.Runtime.InteropService.DllImport("user32.dll",
    'SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Declare Function fAltaMovimiento Lib "MGWServicios.DLL" (ByVal aIdDocumento As Long, ByRef lIdMovimiento As Long, ByRef lMovimiento As tMovimiento) As Integer
    Public Declare Function fEditarMovimiento Lib "MGWServicios.DLL" () As Integer
    Public Declare Function fSetDatoMovimiento Lib "MGWServicios.DLL" (ByVal aCampo As String, ByVal aValor As String) As Integer
    Public Declare Function fGuardaMovimiento Lib "MGWServicios.DLL" () As Integer
    Public Declare Function fBuscarIdMovimiento Lib "MGWServicios.DLL" (ByVal aldMovimiento As Long) As Integer

    'Obtener Licencia
    Public Declare Function fInicializaLicenseInfo Lib "MGWServicios.DLL" (ByVal aSistema As Byte) As Integer
    Public Declare Function fObtieneLicencia Lib "MGWServicios.DLL" (ByVal aCodActiva As String, ByVal aCodSitio As String, ByVal aSerie As String, ByVal aTagVersion As String) As Integer
    Public Declare Function fEmitirDocumento Lib "MGWServicios.DLL" (ByVal aCodConcepto As String, ByVal aSerie As String, ByVal aFolio As Double, ByVal aPassword As String, ByVal aArchivoAdicional As String) As Long

    Public Sub prueba()
        Dim lSetcurrent As String

        'InicizalizaSDK_Comercial = True
        lSetcurrent = Trim(FC_RutaSDKComercial)

        SDK_Comercial.SetCurrentDirectory(lSetcurrent)
        lErrorIn = SDK_Comercial.fSetNombrePAQ("CONTPAQ I COMERCIAL")

        If lErrorIn <> 0 Then
            MensajeError_Comercial(lErrorIn, "Al abrir el SDK")
            'InicizalizaSDK_Comercial = False
        End If
    End Sub
End Module
