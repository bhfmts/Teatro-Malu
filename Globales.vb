Option Explicit On
Module Globales
    '**************************************************************************************************************
    'Declaración de variables a utilizar
    'Estas variables globales o públicas las ocupo para traspasar los datos a otro formulario
    Public intUltimoRegisEven As Integer
    Public ValidaCamposNulos As Integer
    Public intContar As Integer = 0
    Public camposnull As Boolean
    Public strNombreVendedor As String
    Public strNombreAdministrador As String
    Public strRUNEncargadoo As String
    Public strNombreProduccion As String
    Public strRUNUsuarioAnular As String
    Public strRUNVendedorr As String
    Public intPerfilUsuario As Integer
    Public strRUNUsuario As String
    Public strNombreEvento As String
    Public strFechaEvento As String
    Public dbEntradaGeneral As Double
    Public strTipoEntrada As String
    Public strFormaPago As String
    Public strFechaVenta As String
    Public dbEntradaTerceraEdad As Double
    Public dbEntradaNiño As Double
    Public dbEntradaEstudiante As Double
    Public dbPorcentTerceraEdad As Double = 0.7
    Public dbPorcentNiño As Double = 0.5
    Public dbPorcentEstudiante As Double = 0.8
    Public strInforVentas As String
    Public intIDEvento As Integer 'Sirve para descontar el "EstadoEvento"
    Public strNombreEventobusca As String
    Public intUltimaVenta As Integer 'Obtener el último valor del campo numeroventa
    Public intCantidadEntradas As Integer
    Public strUbicacion As String
    Public intJornada As Integer
    Public intUltimaBoleta As Integer
    Public dbPrecioTipo As Double
    'Public blnLimpiaTxt As Boolean
    'Public strLastFechaEvento As String
    Public intIDEventoTemporal As Integer
    Public strFechaTemporal As String
    'Public blnVolverTB As Boolean = False
    'Public blnvolverTB2 As Boolean = True
    Public strJornadaSeleccion As String
    Public dtFechaNac As Date
    Public strDia As String
    Public strMes As String
    Public strAño As String
    Public strJornada As String
    Public intEntradasVendidas As Integer
    Public strDesde As String
    Public strHasta As String
    Public dtDesde As Date
    Public dtHasta As Date
    'Variables para pronostico de ingresos
    Public intBalconesAdulto As Integer
    Public intBalconesTerceraEdad As Integer
    Public intBalconesNiño As Integer
    Public intBalconesEstudiante As Integer
    Public intPlateaAdulto As Integer
    Public intPlateaTerceraEdad As Integer
    Public intPlateaNiño As Integer
    Public intPlateaEstudiante As Integer
    Public intPlateaNuAdulto As Integer
    Public intPlateaNuTerceraEdad As Integer
    Public intPlateaNuNiño As Integer
    Public intPlateaNuEstudiante As Integer
    Public intPlatea As Integer = 2000
    Public intPlateaNumerada As Integer = 3500
    Public dbValorEntradaGeneral As Double
    Public dbTotalPronostico As Double
    Public strNotaMatine As String = "Hora: 11:00 horas" & vbCrLf & "Nota: Ud. tiene un plazo mínimo de tres días antes de la producción del evento, para hacer anulación de las entradas que adquirió. En caso contrario no tiene derecho alguno, sólo por motivos de fuerza mayor. Por ejemplo, la ausencia el/los artistas a presentarse"
    Public strNotaTarde As String = "Hora: 17:00 horas" & vbCrLf & "Nota: Ud. tiene un plazo mínimo de tres días antes de la producción del evento, para hacer anulación de las entradas que adquirió. En caso contrario no tiene derecho alguno, sólo por motivos de fuerza mayor. Por ejemplo, la ausencia el/los artistas a presentarse"
    Public strNotaNoche As String = "Hora: 20:00 horas" & vbCrLf & "Nota: Ud. tiene un plazo mínimo de tres días antes de la producción del evento, para hacer anulación de las entradas que adquirió. En caso contrario no tiene derecho alguno, sólo por motivos de fuerza mayor. Por ejemplo, la ausencia el/los artistas a presentarse"
End Module
