
Imports System.Text

Module modFuncionesSDK
    Public lError As Long
    Public lErrorIn As Integer

    Public Const Formato_FechaDia As String = "dd/MM/yyyy"
    Public Const Formato_FechaMes As String = "MM/dd/yyyy"
    Public Const Formato_FechaYear As String = "yyyy-MM-dd"

    Public Function InicizalizaSDK_ADW() As Boolean
        Dim lSetcurrent As String

        InicizalizaSDK_ADW = True
        lSetcurrent = Trim(FC_RutaSDKAdmin)

        lError = SDK_ADMW.SetCurrentDirectory(lSetcurrent)
        lError = SDK_ADMW.fSetNombrePAQ("AdminPAQ")
        If lError <> 0 Then
            MensajeError_ADW(lError, "Al abrir el SDK")
            InicizalizaSDK_ADW = False
        End If
        lError = SDK_ADMW.fInicializaSDK

        If lError <> 0 Then
            MensajeError_ADW(lError, "Al abrir el SDK")
            InicizalizaSDK_ADW = False
        End If
    End Function

    Public Function InicizalizaSDK_Comercial() As Boolean
        Dim lSetcurrent As String

        InicizalizaSDK_Comercial = True
        lSetcurrent = Trim(FC_RutaSDKComercial)

        SDK_Comercial.SetCurrentDirectory(lSetcurrent)
        lError = SDK_Comercial.fSetNombrePAQ("CONTPAQ I COMERCIAL")

        If lError <> 0 Then
            MensajeError_ADW(lError, "Al abrir el SDK")
            InicizalizaSDK_Comercial = False
        End If
    End Function


    Public Function Carga_EmpresaADW(ByVal lEmpresa As String) As Boolean
        'Declaración de variables locales
        Dim lRutaEmpresa As String

        Carga_EmpresaADW = True


        lRutaEmpresa = Space(61)

        If InicizalizaSDK_ADW() = True Then
            lError = SDK_ADMW.fAbreEmpresa(lEmpresa)
            If lError <> 0 Then
                MensajeError_ADW(lError, "Al abrir la Empresa")
                Carga_EmpresaADW = False
            End If
        End If

    End Function


    Public Function Carga_EmpresaComercial(ByVal lEmpresa As String) As Boolean
        ' Declaración de variables locales
        Dim lRutaEmpresa As String

        Carga_EmpresaComercial = True

        lRutaEmpresa = Space(61)

        If InicizalizaSDK_Comercial() = True Then
            lError = SDK_Comercial.fAbreEmpresa(FC_EmpresasComercial & "\" & Trim(lEmpresa))
            If lError <> 0 Then
                MensajeError_Comercial(lError, "Al abrir Empresa")
                Carga_EmpresaComercial = False
            End If
        End If
    End Function

    Public Sub MensajeError_Comercial(aError As Long, text As String)
        Dim aMensaje As StringBuilder = New StringBuilder(512)

        'aMensaje = "" 'String(349, Chr(0))
        ' Recupera el mensaje de error del SDK
        SDK_Comercial.fError(aError, aMensaje, 350)
        MsgBox(text & vbCrLf & aMensaje.ToString, vbExclamation, "Validación")
    End Sub

    Public Sub MensajeError_ADW(aError As Integer, text As String)
        Dim aMensaje As StringBuilder = New StringBuilder(512)

        'aMensaje = ""
        ' Recupera el mensaje de error del SDK
        SDK_ADMW.fError(aError, aMensaje, 350)
        MsgBox(text & vbCrLf & aMensaje.ToString, vbExclamation, "Validación")
    End Sub


    Public Sub CerrarEmpresa_Comercial()
        SDK_Comercial.fCierraEmpresa
        'SDK_Comercial.fTerminaSDK
    End Sub

    Public Sub CerrarEmpresa_ADW()
        SDK_ADMW.fCierraEmpresa
        'SDK_ADMW.fTerminaSDK
    End Sub

    ' Funcion de rellena con blancos
    Public Function fRellenaConBlancos(ByRef aCadena As String, aTamanio As Integer) As String
        Dim lEspacios As String
        Dim lTamanio As Long

        lEspacios = Space(aTamanio)
        lTamanio = aTamanio - Len(Trim(aCadena)) - 1

        aCadena = Trim(aCadena) & Left(lEspacios, lTamanio) & Chr(0)
        fRellenaConBlancos = aCadena
    End Function

    Public Sub Termina_DocumentoADW()
        lErrorIn = SDK_ADMW.fBorraDocumento()
        If lError <> 0 Then
            MensajeError_ADW(lErrorIn, "Al Eliminar Documento")
        End If
        CerrarEmpresa_ADW()

    End Sub

    Public Sub Termina_DocumentoComercial()
        lError = SDK_Comercial.fBorraDocumento()
        If lError <> 0 Then
            MensajeError_Comercial(lError, "Al Eliminar Documento")
        End If
        CerrarEmpresa_Comercial()
    End Sub
End Module
