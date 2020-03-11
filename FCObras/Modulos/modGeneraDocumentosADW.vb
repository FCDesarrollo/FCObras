Module modGeneraDocumentosADW
    Public Sub Genera_DocumentoADW(ByVal dRuta As String, ByRef Document As clDocumento,
                                        Optional ByVal dIniciaSDK As Boolean = True)
        Dim tDocto As New tDocumento, aIdDocumento As Integer, tMovto As New tMovimiento
        Dim Movi As clMovimiento, aIdMovimiento As Integer, fQue As String

        If dIniciaSDK = True Then
            If Carga_EmpresaADW(dRuta) = False Then Exit Sub
        Else
            lError = SDK_ADMW.fAbreEmpresa(dRuta)

            If lError <> 0 Then
                MensajeError_ADW(lError, "Al abrir la Empresa")
                Exit Sub
            End If
        End If

        Document.Iddoc = 0
        tDocto.aFecha = fRellenaConBlancos(Document.Fechadocto, kLongFecha)
        tDocto.aSerie = Document.Serie
        tDocto.aFolio = CDbl(Document.Folio)
        tDocto.aCodConcepto = fRellenaConBlancos(Document.Codconcepto, kLongCodigo)
        tDocto.aCodigoCteProv = fRellenaConBlancos(Document.Codcliente, kLongCodigo)
        tDocto.aNumMoneda = Document.Idmoneda
        tDocto.aTipoCambio = Document.Tipocambio
        tDocto.aReferencia = Document.Referencia


        'lErrorIn = SDK_ADMW.fAltaDocumentoCargoAbono(tDocto)
        lErrorIn = SDK_ADMW.fAltaDocumento(aIdDocumento, tDocto)

        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al Crear Documento")
            CerrarEmpresa_ADW()
            Exit Sub
        End If

        'buscar documento para edicion
        lErrorIn = SDK_ADMW.fBuscarIdDocumento(aIdDocumento)
        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al Buscar Documento")
            Termina_DocumentoADW()
            Exit Sub
        End If

        SDK_ADMW.fEditarDocumento

        lErrorIn = SDK_ADMW.fSetDatoDocumento("creferen01", Trim(Document.Referencia))
        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al Editar Documento")
            Termina_DocumentoADW()
            Exit Sub
        End If

        lErrorIn = SDK_ADMW.fSetDatoDocumento("CTEXTOEX03", Trim(CStr(Document.Idobra)))
        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al Editar Documento")
            Termina_DocumentoADW()
            Exit Sub
        End If

        'lErrorIn = SDK_ADMW.fSetDatoDocumento("cobserva01", "[" & Document.Observaciones & "]")
        'If lErrorIn <> 0 Then
        '    MensajeError_ADW(lErrorIn, "Al Editar Documento")
        '    Termina_DocumentoADW()
        '    Exit Sub
        'End If

        lErrorIn = SDK_ADMW.fGuardaDocumento()
        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al Guardar Documento")
            Termina_DocumentoADW()
            Exit Sub
        End If

        For Each Movi In Document.DColMovimientos
            tMovto.aCodProdSer = Movi.Codpro
            tMovto.aCodAlmacen = Movi.codAlmacen
            tMovto.aUnidades = Movi.unidades
            tMovto.aPrecio = Movi.Precio

            lErrorIn = SDK_ADMW.fAltaMovimiento(aIdDocumento, aIdMovimiento, tMovto)

            If lErrorIn <> 0 Then
                MensajeError_ADW(lErrorIn, "Al Insertar Movimiento")
                Termina_DocumentoADW()
                Exit Sub
            End If
            Movi.Idmov = CLng(aIdMovimiento)
            lErrorIn = SDK_ADMW.fBuscarIdMovimiento(aIdMovimiento)
            If lErrorIn <> 0 Then
                MensajeError_ADW(lErrorIn, "Al Buscar Movimiento")
                Termina_DocumentoADW()
                Exit Sub
            Else
                SDK_ADMW.fEditarMovimiento

                ''IVA
                If Movi.Impuesto1 <> 0 Then
                    lErrorIn = SDK_ADMW.fSetDatoMovimiento("cimpuesto1", CStr(Movi.Impuesto1))
                    lErrorIn = SDK_ADMW.fSetDatoMovimiento("CPORCENT01", CStr((Movi.Porcenimpuesto1 * IIf(Movi.Porcenimpuesto1 < 1, 100, 1))))
                End If

                '    If lError <> 0 Then GoTo MensajeMovimiento

                '    ''IEPS
                '    If Movi.impuesto2 <> 0 Then
                '        lError = SDK_ADMW.fSetDatoMovimiento("cimpuesto2", CStr(Movi.impuesto2))
                '        lError = SDK_ADMW.fSetDatoMovimiento("CPORCENT02", CStr(Movi.porcenimpuesto2))
                '    End If

                '    If lError <> 0 Then GoTo MensajeMovimiento

                '    ''ISH
                '    If Movi.impuesto3 <> 0 Then
                '        lError = SDK_ADMW.fSetDatoMovimiento("cimpuesto3", CStr(Movi.impuesto3))
                '        lError = SDK_ADMW.fSetDatoMovimiento("CPORCENT03", CStr((Movi.porcenimpuesto3 * IIf(Movi.porcenimpuesto3 < 1, 100, 1))))
                '    End If

                If lErrorIn <> 0 Then GoTo MensajeMovimiento

                ''RETENCION IVA
                If Movi.Retencion2 <> 0 Then
                    lErrorIn = SDK_ADMW.fSetDatoMovimiento("cretenci02", CStr(Movi.Retencion2))
                    lErrorIn = SDK_ADMW.fSetDatoMovimiento("cporcent05", CStr(Movi.Porcenretencion2))
                End If

                If lErrorIn <> 0 Then GoTo MensajeMovimiento

                ''RETENCION ISR
                If Movi.Retencion1 <> 0 Then
                    lErrorIn = SDK_ADMW.fSetDatoMovimiento("cretenci01", CStr(Movi.Retencion1))
                    lErrorIn = SDK_ADMW.fSetDatoMovimiento("cporcent04", CStr(Movi.Porcenretencion1))
                End If

                '    If lError <> 0 Then GoTo MensajeMovimiento

                '    If Movi.descuento1 <> 0 Then
                '        lError = SDK_ADMW.fSetDatoMovimiento("CDESCUEN01", CStr(Movi.descuento1))
                '        lError = SDK_ADMW.fSetDatoMovimiento("CPORCENT06", CStr(Movi.porcen6))
                '    End If

                '    If lError <> 0 Then GoTo MensajeMovimiento

                '    ''SEGMENTO
                '    If Movi.segmento <> "" Then
                '        lError = SDK_ADMW.fSetDatoMovimiento("CSCMOVTO", Movi.segmento)
                '    End If

                '    If lError <> 0 Then GoTo MensajeMovimiento

                '    ''TEXTOEXTRA 1
                '    lError = SDK_ADMW.fSetDatoMovimiento("CTEXTOEX01", Trim(Movi.textoextra1))

                '    If lError <> 0 Then GoTo MensajeMovimiento

                lErrorIn = SDK_ADMW.fGuardaMovimiento()

                If lErrorIn <> 0 Then
                    MensajeError_ADW(lErrorIn, "Al Editar Movimiento")
                    Termina_DocumentoADW()
                    Exit Sub
                End If

            End If

        Next Movi



        Document.Iddoc = CLng(aIdDocumento)
        If dIniciaSDK = True Then
            CerrarEmpresa_ADW()
        Else
            SDK_ADMW.fCierraEmpresa
        End If

        fQue = "UPDATE MGW10008 SET COBSERVA01='" & Document.Observaciones & "' WHERE CIDDOCUM01=" & Document.Iddoc & ""
        Using fCom = New Odbc.OdbcCommand(fQue, FC_CONFOX)
            fCom.ExecuteNonQuery()
        End Using

        Exit Sub
MensajeMovimiento:
        MensajeError_ADW(lErrorIn, "Al Editar Movimiento")
        Termina_DocumentoADW()
    End Sub

    Public Sub Genera_DocumentoComercial(ByVal dRuta As String, ByRef Document As clDocumento,
                                        Optional ByVal dIniciaSDK As Boolean = True)
        Dim tDocto As New tDocumento, dIDoc As Integer
        'Dim Movi As MovimientoClass

        If dIniciaSDK = True Then
            If Carga_EmpresaComercial(dRuta) = False Then Exit Sub
        Else
            lError = SDK_Comercial.fAbreEmpresa(dRuta)
            If lError <> 0 Then
                MensajeError_Comercial(lError, "Al abrir la Empresa")
                Exit Sub
            End If
        End If

        Document.Iddoc = 0
        tDocto.aFecha = Document.Fechadocto
        tDocto.aSerie = Document.Serie
        tDocto.aFolio = CDbl(Document.Folio)
        tDocto.aCodConcepto = Document.Codconcepto
        tDocto.aCodigoCteProv = Document.Codcliente
        tDocto.aNumMoneda = Document.Idmoneda
        tDocto.aTipoCambio = Document.Tipocambio
        tDocto.aImporte = Document.Total
        tDocto.aReferencia = Document.Referencia

        lError = SDK_Comercial.fAltaDocumento(dIDoc, tDocto)
        If lError <> 0 Then
            MensajeError_ADW(lError, "Al Crear Documento")
            CerrarEmpresa_ADW()
            Exit Sub
        End If

        Document.Iddoc = CLng(dIDoc)
        If dIniciaSDK = True Then
            CerrarEmpresa_Comercial()
        Else
            SDK_Comercial.fCierraEmpresa
        End If
    End Sub

    Public Function Borrar_DocumentoADW(ByVal dRuta As String, ByVal idDocumento As Integer,
                                        Optional ByVal dIniciaSDK As Boolean = True) As Boolean
        If dIniciaSDK = True Then
            If Carga_EmpresaADW(dRuta) = False Then
                Return False
                Exit Function
            End If
        Else
            lError = SDK_ADMW.fAbreEmpresa(dRuta)

            If lError <> 0 Then
                MensajeError_ADW(lError, "Al abrir la Empresa")
                Return False
                Exit Function
            End If
        End If

        lErrorIn = SDK_ADMW.fBuscarIdDocumento(idDocumento)
        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al buscar el Documento.")
            Return False
            Exit Function
        End If

        lErrorIn = SDK_ADMW.fBorraDocumento()
        If lErrorIn <> 0 Then
            MensajeError_ADW(lErrorIn, "Al borrar el Documento.")
            Return False
            Exit Function
        End If

        If dIniciaSDK = True Then
            CerrarEmpresa_ADW()
        Else
            SDK_ADMW.fCierraEmpresa
        End If
        Return True
    End Function

End Module
