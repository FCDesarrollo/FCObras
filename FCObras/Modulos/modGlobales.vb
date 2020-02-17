Module modGlobales
    Public Const tAdmin As Integer = 0
    Public Const tSupervisor As Integer = 1
    Public Const tUsuario As Integer = 2

    Public sSystema As Integer ' 0.- IGUAL SIN INSTALAR , 1.- YA INSTALADO
    Public Const UserAdmin As String = "FCPREMIUM"
    Public Const PassAdmin As String = "FC2019"

    Public GL_cParam As clParametros
    Public GL_cUsuario As clUsuario

    Public Const mApi As String = "http://apicrm.dublock.com/"

    Public Const GL_ModActual As String = "Construccion"

    Public Enum iColCuentas
        iFechaini = 1
        iFechaFin
        iCodigo
        iCuenta
        iSubcuenta
        iTipoInsumo
        iNOmInsumo
        iFechaPrecio
        iCantidad
        iUnidad
        iPrecio
        iImporte
        iPresupuesto
        iClasi1
        iClasi2
        iClasi3
    End Enum
End Module
