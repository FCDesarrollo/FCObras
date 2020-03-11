Imports System.Text
Imports System.Runtime.InteropServices
Module SDK_ADMW
    '--------------------------------------------------------------------------------------
    ' Modulo:             SDK_ADMW
    ' Descripción:        En este módulo se declaran las constantes, métodos,
    '                     y estructuras de datos del SDK de AdminPAQ.
    '
    ' Fecha de creación:  01.sept.06
    ' Departamento:       Alianzas ISV's
    ' Autor:              AS
    '
    ' Actualización:      15.sept.06
    ' Contacto:           desarrollo.isv@compac.com.mx
    '--------------------------------------------------------------------------------------

    '__________________DECLARACIÓN DE LAS FUNCIONES DEL SDK______________________


    ' ***** Funciones Generales del SDK *****
    ' Inicialización/Terminación
    Public Declare Function fInicializaSDK Lib "MGW_SDK.DLL" () As Integer
    Public Declare Function SetCurrentDirectory Lib "KERNEL32" Alias "SetCurrentDirectoryA" (ByVal pPtrDirActual As String) As Integer
    Public Declare Function fSetNombrePAQ Lib "MGW_SDK.DLL" (ByVal aSistema As String) As Integer

    Public Declare Sub fTerminaSDK Lib "MGW_SDK.DLL" ()
    ' Manejo de errores
    Public Declare Sub fError Lib "MGW_SDK.DLL" (ByVal aNumError As Integer, ByVal aError As StringBuilder, ByVal aLen As Integer)



    ' ***** Funciones de Empresas *****
    ' Navegación
    Declare Function fPosPrimerEmpresa Lib "MGW_SDK.DLL" (ByRef aIdEmpresa As Long, ByVal aNombreEmpresa As String, ByVal aDirectorioEmpresa As String) As Long
    Declare Function fPosSiguienteEmpresa Lib "MGW_SDK.DLL" (ByRef aIdEmpresa As Long, ByVal aNombreEmpresa As String, ByVal aDirectorioEmpresa As String) As Long
    ' Apertura/Cierre
    Declare Function fAbreEmpresa Lib "MGW_SDK.DLL" (ByVal aError As String) As Integer
    Public Declare Sub fCierraEmpresa Lib "MGW_SDK.DLL" ()



    ' ***** Funciones de Documentos *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertarDocumento Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditarDocumento Lib "MGW_SDK.DLL" () As Long
    Public Declare Function fGuardaDocumento Lib "MGW_SDK.DLL" () As Integer
    Declare Function fCancelarModificacionDocumento Lib "MGW_SDK.DLL" () As Long

    Public Declare Function fBorraDocumento Lib "MGW_SDK.DLL" () As Integer
    Declare Function fCancelaDocumento Lib "MGW_SDK.DLL" () As Integer
    Declare Function fBorraDocumento_CW Lib "MGW_SDK.DLL" () As Integer
    Declare Function fCancelaDocumento_CW Lib "MGW_SDK.DLL" () As Integer

    'Todos los documentos creados con el SDK deben afectarse a fin de que se actualicen los acumulados del sistema
    Declare Function fAfectaDocto_Param Lib "MGW_SDK.DLL" (ByVal aCodConcepto As String, ByVal aSerie As String, ByVal aFolio As Double, ByVal aAfecta As Boolean) As Long
    Declare Function fSaldarDocumento_Param Lib "MGW_SDK.DLL" (ByVal aCodConcepto_Pagar As String, ByVal aSerie_Pagar As String, ByVal aFolio_Pagar As Double, ByVal aCodConcepto_Pago As String, ByVal aSerie_Pago As String, ByVal aFolio_Pago As Double, ByVal aImporte As Double, ByVal aIdMoneda As Long, ByVal aFecha As String) As Long
    Declare Function fBorrarAsociacion_Param Lib "MGW_SDK.DLL" (ByVal aCodConcepto_Pagar As String, ByVal aSerie_Pagar As String, ByVal aFolio_Pagar As Double, ByVal aCodConcepto_Pago As String, ByVal aSerie_Pago As String, ByVal aFolio_Pago As Double) As Long

    Public Declare Function fSetDatoDocumento Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Integer
    Declare Function fLeeDatoDocumento Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Integer) As Integer
    Public Declare Function fSiguienteFolio Lib "MGW_SDK.DLL" (ByVal aCodigoConcepto As String, ByVal aSerie As String, ByRef aFolio As Double) As Integer

    Declare Function fSetFiltroDocumento Lib "MGW_SDK.DLL" (ByVal aFechaInicio As String, ByVal aFechaFin As String, ByVal aCodigoConcepto As String, ByVal aCodigoCteProv As String) As Long
    Declare Function fCancelaFiltroDocumento Lib "MGW_SDK.DLL" () As Long
    Declare Function fDocumentoImpreso Lib "MGW_SDK.DLL" (ByVal aImpreso As Boolean) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscarDocumento Lib "MGW_SDK.DLL" (ByVal aCodConcepto As String, ByVal aSerie As String, ByVal aFolio As String) As Integer
    Public Declare Function fBuscarIdDocumento Lib "MGW_SDK.DLL" (ByVal aIdDocumento As Integer) As Integer

    Declare Function fPosPrimerDocumento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoDocumento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteDocumento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorDocumento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOF Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOF Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura

    Public Declare Function fAltaDocumento Lib "MGW_SDK.DLL" (ByRef aIdDocumento As Integer, ByRef aDocto As tDocumento) As Integer
    Public Declare Function fAltaMovimiento Lib "MGW_SDK.DLL" (ByVal aIdDocumento As Integer, ByRef aIdMovimiento As Integer, ByRef aMovimiento As tMovimiento) As Integer
    Public Declare Function fAltaDocumentoCargoAbono Lib "MGW_SDK.DLL" (ByRef aDocto As tDocumento) As Integer


    'Todos los documentos creados con el SDK deben afectarse a fin de que se actualicen los acumulados del sistema
    Declare Function fAfectaDocto Lib "MGW_SDK.DLL" (ByRef astDocAPagar As tLlaveDocto, ByVal aAfecta As Boolean) As Long
    Declare Function fSaldarDocumento Lib "MGW_SDK.DLL" (ByVal astDocAPagar As tLlaveDocto, ByVal astDocPago As tLlaveDocto, ByVal aImporte As Double, ByVal aIdMoneda As Long, ByVal aFecha As String) As Long
    Declare Function fSaldarDocumentoCheqPAQ Lib "MGW_SDK.DLL" (ByVal astDocAPagar As tLlaveDocto, ByVal astDocPago As tLlaveDocto, ByVal aImporte As Double, ByVal aIdMoneda As Long, ByVal aFecha As String, ByVal aTipoCambioCheqPAQ As Double) As Long
    Declare Function fBorrarAsociacion Lib "MGW_SDK.DLL" (ByVal astDocAPagar As tLlaveDocto, ByVal astDocPago As tLlaveDocto) As Long

    Declare Function fRegresaIVACargo Lib "MGW_SDK.DLL" (ByVal aLlaveDocto As tLlaveDocto, ByRef aNetoTasa15 As Double, ByRef aNetoTasa10 As Double, ByRef aNetoTasaCero As Double, ByRef aNetoTasaExcenta As Double, ByRef aNetoOtrasTasas As Double, ByRef aIVATasa15 As Double, ByRef aIVATasa10 As Double, ByRef aIVAOtrasTasas As Double) As Long
    Declare Function fRegresaIVAPago Lib "MGW_SDK.DLL" (ByVal aLlaveDocto As tLlaveDocto, ByRef aNetoTasa15 As Double, ByRef aNetoTasa10 As Double, ByRef aNetoTasaCero As Double, ByRef aNetoTasaExcenta As Double, ByRef aNetoOtrasTasas As Double, ByRef aIVATasa15 As Double, ByRef aIVATasa10 As Double, ByRef aIVAOtrasTasas As Double) As Long

    ' Alto Nivel - Busqueda/Navegación
    Declare Function fBuscaDocumento Lib "MGW_SDK.DLL" (ByRef aLlaveDocto As tLlaveDocto) As Long


    ' ***** Funciones de Movimientos  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertarMovimiento Lib "MGW_SDK.DLL" () As Long
    Public Declare Function fEditarMovimiento Lib "MGW_SDK.DLL" () As Integer
    Public Declare Function fGuardaMovimiento Lib "MGW_SDK.DLL" () As Integer
    Declare Function fCancelaCambiosMovimiento Lib "MGW_SDK.DLL" () As Long

    Declare Function fAltaMovimientoCaracteristicas_Param Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As String, ByVal aIdMovtoCaracteristicas As String, ByVal aUnidades As String, ByVal aValorCaracteristica1 As String, ByVal aValorCaracteristica2 As String, ByVal aValorCaracteristica3 As String) As Long
    Declare Function fAltaMovimientoSeriesCapas_Param Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As String, ByVal aIdMovtoCaracteristicas As String, ByVal aUnidad As String, ByVal aUnidades As String, ByVal aUnidadesNC As String, ByVal aValorCaracteristica1 As String, ByVal aValorCaracteristica2 As String, ByVal aValorCaracteristica3 As String) As Long
    Declare Function fAltaMovtoCaracteristicasUnidades_Param Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As String, ByVal aUnidades As String, ByVal aTipoCambio As String, ByVal aSeries As String, ByVal aPedimento As String, ByVal aAgencia As String, ByVal aFechaPedimento As String, ByVal aNumeroLote As String, ByVal aFechaFabricacion As String, ByVal aFechaCaducidad As String) As Long

    Declare Function fCalculaMovtoSerieCapa Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As Long) As Long
    Declare Function fObtieneUnidadesPendientes Lib "MGW_SDK.DLL" (ByVal aConceptoDocto As String, ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByRef aUnidades As String) As Long
    Declare Function fObtieneUnidadesPendientesCarac Lib "MGW_SDK.DLL" (ByVal aConceptoDocto As String, ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByVal aValorCaracteristica1 As String, ByVal aValorCaracteristica2 As String, ByVal aValorCaracteristica3 As String, ByRef aUnidades As String) As Long
    Declare Function fModificaCostoEntrada Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As String, ByVal aCostoEntrada As String) As Long

    Public Declare Function fSetDatoMovimiento Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Integer
    Declare Function fLeeDatoMovimiento Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    Declare Function fSetFiltroMovimiento Lib "MGW_SDK.DLL" (ByVal aIdDocumento As Long) As Long
    Declare Function fCancelaFiltroMovimiento Lib "MGW_SDK.DLL" () As Long

    ' Bajo Nivel - Busqueda/Navegación
    Public Declare Function fBuscarIdMovimiento Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As Integer) As Integer

    Declare Function fPosPrimerMovimiento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoMovimiento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteMovimiento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorMovimiento Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosMovimientoBOF Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosMovimientoEOF Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura
    'Declare Function fAltaMovimientoEx Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As Long, ByRef aTipoProducto As tProducto) As Long
    'Declare Function fAltaMovimientoCDesct Lib "MGW_SDK.DLL" (ByVal aIdDocumento As Long, ByRef aIdMovimiento As Long, ByRef aMovimiento As tMovimientoDesc) As Long
    'Declare Function fAltaMovimientoCaracteristicas Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As Long, ByRef aIdMovtoCaracteristicas As Long, aCaracteristicas As tCaracteristicas) As Long
    'Declare Function fAltaMovtoCaracteristicasUnidades Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As Long, ByRef aIdMovtoCaracteristicas As Long, ByRef aCaracteristicasUnidades As tCaracteristicasUnidades) As Long
    'Declare Function fAltaMovimientoSeriesCapas Lib "MGW_SDK.DLL" (ByVal aIdMovimiento As Long, aSeriesCapas As tSeriesCapas) As Long


    ' ***** Funciones de Clientes / Proveedores *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fBorraCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionCteProv Lib "MGW_SDK.DLL" () As Long

    Declare Function fEliminarCteProv Lib "MGW_SDK.DLL" (ByVal aCodCteProv As String) As Long
    Declare Function fSetDatoCteProv Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long
    Declare Function fLeeDatoCteProv Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaCteProv Lib "MGW_SDK.DLL" (ByVal aCodCteProv As String) As Long
    Declare Function fBuscaIdCteProv Lib "MGW_SDK.DLL" (ByVal aIdCteProv As Long) As Long

    Declare Function fPosPrimerCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFCteProv Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFCteProv Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura
    'Declare Function fAltaCteProv Lib "MGW_SDK.DLL" (ByRef aIdCteProv As Long, aCteProv As tClienteProveedor) As Long
    'Declare Function fActualizaCteProv Lib "MGW_SDK.DLL" (ByVal aCodCteProv As String, aCteProv As tClienteProveedor) As Long
    'Declare Function fLlenaRegistroCteProv Lib "MGW_SDK.DLL" (aCteProv As tClienteProveedor, ByVal aEsAlta As Long) As Long


    ' ***** Funciones de Productos  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fBorraProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionProducto Lib "MGW_SDK.DLL" () As Long

    Declare Function fEliminarProducto Lib "MGW_SDK.DLL" (ByVal aCodCteProv As String) As Long
    Declare Function fSetDatoProducto Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long
    Declare Function fLeeDatoProducto Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    Declare Function fRecuperaTipoProducto Lib "MGW_SDK.DLL" (ByRef aUnidades As Boolean, ByRef aSerie As Boolean, ByRef aLote As Boolean, ByRef aPedimento As Boolean, ByRef aCaracteristicas As Boolean) As Long

    'Función de recosteo de productos
    Declare Function fRecosteoProducto Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByVal aEjercicio As Long, ByVal aPeriodo As Long, ByVal aCodigoClasificacion1 As String, ByVal aCodigoClasificacion2 As String, ByVal aCodigoClasificacion3 As String, ByVal aCodigoClasificacion4 As String, ByVal aCodigoClasificacion5 As String, ByVal aCodigoClasificacion6 As String, ByVal aNombreBitacora As String, ByVal aSobreEscribirBitacora As Long, ByVal aEsCalculoArimetico As Long) As Long

    Declare Function fRegresaPrecioVenta Lib "MGW_SDK.DLL" (ByVal aCodigoConcepto As String, ByVal aCodigoCliente As String, ByVal aCodigoProducto As String, ByRef aPrecioVenta As String) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaProducto Lib "MGW_SDK.DLL" (ByVal aCodProducto As String) As Long
    Declare Function fBuscaIdProducto Lib "MGW_SDK.DLL" (ByVal aIdProducto As Long) As Long

    Declare Function fPosPrimerProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFProducto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFProducto Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura
    'Declare Function fAltaProducto Lib "MGW_SDK.DLL" (ByRef aIdProducto As Long, aProducto As tProducto) As Long
    'Declare Function fActualizaProducto Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, aProducto As tProducto) As Long
    'Declare Function fLlenaRegistroProducto Lib "MGW_SDK.DLL" (aProducto As tProducto, ByVal aEsAlta As Long) As Long


    ' ***** Funciones de Direcciones  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionDireccion Lib "MGW_SDK.DLL" () As Long

    Declare Function fSetDatoDireccion Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long
    Declare Function fLeeDatoDireccion Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaDireccionEmpresa Lib "MGW_SDK.DLL" () As Long
    Declare Function fBuscaDireccionCteProv Lib "MGW_SDK.DLL" (ByVal aCodCteProv As String, aTipoDireccion As String) As Long
    Declare Function fBuscaDireccionDocumento Lib "MGW_SDK.DLL" (ByVal aIdDocumento As Long, aTipoDireccion As String) As Long

    Declare Function fPosPrimerDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimaDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFDireccion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFDireccion Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura
    'Declare Function fAltaDireccion Lib "MGW_SDK.DLL" (ByRef aIdDireccion As Long, astDireccion As tDireccion) As Long
    'Declare Function fActualizaDireccion Lib "MGW_SDK.DLL" (astDireccion As tDireccion) As Long
    'Declare Function fLlenaRegistroDireccion Lib "MGW_SDK.DLL" (astDireccion As tDireccion, ByVal aEsAlta As Long) As Long


    ' ***** Funciones de Existencias  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fRegresaExistencia Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByVal aAnio As String, ByVal aMes As String, ByVal aDia As String, ByRef aExistencia As Double) As Long
    Declare Function fRegresaExistenciaCaracteristicas Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByVal aAnio As String, ByVal aMes As String, ByVal aDia As String, ByVal aValorCaracteristica1 As String, ByVal aValorCaracteristica2 As String, ByVal aValorCaracteristica3 As String, ByRef aExistencia As Double) As Long


    ' ***** Funciones de Costo Histórico  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fRegresaCostoPromedio Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByVal aAnio As String, ByVal aMes As String, ByVal aDia As String, ByRef aCostoPromedio As String) As Long
    Declare Function fRegresaUltimoCosto Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByVal aAnio As String, ByVal aMes As String, ByVal aDia As String, ByRef aUltimoCosto As String) As Long
    Declare Function fRegresaCostoEstandar Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByRef aCostoEstandar As String) As Long
    Declare Function fRegresaCostoCapa Lib "MGW_SDK.DLL" (ByVal aCodigoProducto As String, ByVal aCodigoAlmacen As String, ByVal aUnidades As Double, ByRef aImporteCosto As String) As Long


    ' ***** Funciones de Concepto Documento *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fLeeDatoConceptoDocto Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long
    Declare Function fRegresPorcentajeImpuesto Lib "MGW_SDK.DLL" (ByVal aIdConceptoDocumento As Long, ByVal aIdClienteProveedor As Long, ByVal aIdProducto As Long, ByRef aPorcentajeImpuesto As Double) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaConceptoDocto Lib "MGW_SDK.DLL" (ByVal aCodConcepto As String) As Long
    Declare Function fBuscaIdConceptoDocto Lib "MGW_SDK.DLL" (ByVal aIdConcepto As Long) As Long

    Declare Function fPosPrimerConceptoDocto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimaConceptoDocto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteConceptoDocto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorConceptoDocto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFConceptoDocto Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFConceptoDocto Lib "MGW_SDK.DLL" () As Long


    ' ***** Funciones de Parámetros *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fLeeDatoParametros Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long


    ' ***** Funciones del Catálogo de Clasificaciones  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fEditaClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionClasificacion Lib "MGW_SDK.DLL" () As Long

    Declare Function fSetDatoClasificacion Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long
    Declare Function fLeeDatoClasificacion Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    Declare Function fActualizaClasificacion Lib "MGW_SDK.DLL" (ByVal aClasificacionDe As Long, ByVal aNumClasificacion As Long, ByVal aNombreClasificacion As String) As Long


    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaClasificacion Lib "MGW_SDK.DLL" (ByVal aClasificacionDe As Long, ByVal aNumClasificacion As Long) As Long
    Declare Function fBuscaIdClasificacion Lib "MGW_SDK.DLL" (ByVal aIdClasificacion As Long) As Long

    Declare Function fPosPrimerClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFClasificacion Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFClasificacion Lib "MGW_SDK.DLL" () As Long


    ' ***** Funciones del Catálogo de Valores de Clasificaciones *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fBorraValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionValorClasif Lib "MGW_SDK.DLL" () As Long

    Declare Function fEliminarValorClasif Lib "MGW_SDK.DLL" (ByVal aClasificacionDe As Long, ByVal aNumClasificacion As Long, ByVal aCodValorClasif As String) As Long
    Declare Function fSetDatoValorClasif Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long
    Declare Function fLeeDatoValorClasif Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaValorClasif Lib "MGW_SDK.DLL" (ByVal aClasificacionDe As Long, ByVal aNumClasificacion As Long, ByVal aCodValorClasif As String) As Long
    Declare Function fBuscaIdValorClasif Lib "MGW_SDK.DLL" (ByVal aIdValorClasif As Long) As Long

    Declare Function fPosPrimerValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFValorClasif Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFValorClasif Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura
    'Declare Function fAltaValorClasif Lib "MGW_SDK.DLL" (ByRef aIdValorClasif As Long, astValorClasif As tValorClasificacion) As Long
    'Declare Function fActualizaValorClasif Lib "MGW_SDK.DLL" (ByVal aCodigoValorClasif As String, astValorClasif As tValorClasificacion) As Long
    'Declare Function fLlenaRegistroValorClasif Lib "MGW_SDK.DLL" (astValorClasif As tValorClasificacion) As Long


    ' ***** Funciones del Catálogo de Unidades de Medida y Peso  *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fBorraUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionUnidad Lib "MGW_SDK.DLL" () As Long

    Declare Function fEliminarUnidad Lib "MGW_SDK.DLL" (ByVal aNombreUnidad As String) As Long
    Declare Function fSetDatoUnidad Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long
    Declare Function fLeeDatoUnidad Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaUnidad Lib "MGW_SDK.DLL" (ByVal aNombreUnidad As String) As Long
    Declare Function fBuscaIdUnidad Lib "MGW_SDK.DLL" (ByVal aIdUnidad As Long) As Long

    Declare Function fPosPrimerUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFUnidad Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFUnidad Lib "MGW_SDK.DLL" () As Long

    ' Alto Nivel - Lectura/Escritura
    'Declare Function fAltaUnidad Lib "MGW_SDK.DLL" (ByRef aIdUnidad As Long, astUnidad As tUnidad) As Long
    'Declare Function fActualizaUnidad Lib "MGW_SDK.DLL" (ByVal aNombreUnidad As String, astUnidad As tUnidad) As Long
    'Declare Function fLlenaRegistroUnidad Lib "MGW_SDK.DLL" (astUnidad As tUnidad) As Long


    ' ***** Funciones del Catálogo de Agentes *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaAgente Lib "MGW_SDK.DLL" () As Long
    'Declare Function fEditaAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionAgente Lib "MGW_SDK.DLL" () As Long

    Declare Function fLeeDatoAgente Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long
    Declare Function fSetDatoAgente Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaIdAgente Lib "MGW_SDK.DLL" (ByVal aIdAgente As Long) As Long
    Declare Function fBuscaAgente Lib "MGW_SDK.DLL" (ByVal aCodigoAgente As String) As Long

    Declare Function fPosPrimerAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFAgente Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFAgente Lib "MGW_SDK.DLL" () As Long


    ' ***** Funciones del Catálogo de Almacenes *****
    ' Bajo Nivel - Lectura/Escritura
    Declare Function fInsertaAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fEditaAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fGuardaAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fCancelarModificacionAlmacen Lib "MGW_SDK.DLL" () As Long

    Declare Function fLeeDatoAlmacen Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String, ByVal aLen As Long) As Long
    Declare Function fSetDatoAlmacen Lib "MGW_SDK.DLL" (ByVal aCampo As String, ByVal aValor As String) As Long

    ' Bajo Nivel - Busqueda/Navegación
    Declare Function fBuscaIdAlmacen Lib "MGW_SDK.DLL" (ByVal aIdAlmacen As Long) As Long
    Declare Function fBuscaAlmacen Lib "MGW_SDK.DLL" (ByVal aCodigoAlmacen As String) As Long

    Declare Function fPosPrimerAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosUltimoAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosSiguienteAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosAnteriorAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosBOFAlmacen Lib "MGW_SDK.DLL" () As Long
    Declare Function fPosEOFAlmacen Lib "MGW_SDK.DLL" () As Long

End Module
