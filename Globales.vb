Option Explicit On
Module Globales
    '**************************************************************************************************************
    'Declaraci�n de variables a utilizar
    'Estas variables globales o p�blicas las ocupo para traspasar los datos a otro formulario
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
    Public dbEntradaNi�o As Double
    Public dbEntradaEstudiante As Double
    Public dbPorcentTerceraEdad As Double = 0.7
    Public dbPorcentNi�o As Double = 0.5
    Public dbPorcentEstudiante As Double = 0.8
    Public strInforVentas As String
    Public intIDEvento As Integer 'Sirve para descontar el "EstadoEvento"
    Public strNombreEventobusca As String
    Public intUltimaVenta As Integer 'Obtener el �ltimo valor del campo numeroventa
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
    Public strA�o As String
    Public strJornada As String
    Public intEntradasVendidas As Integer
    Public strDesde As String
    Public strHasta As String
    Public dtDesde As Date
    Public dtHasta As Date
    'Variables para pronostico de ingresos
    Public intBalconesAdulto As Integer
    Public intBalconesTerceraEdad As Integer
    Public intBalconesNi�o As Integer
    Public intBalconesEstudiante As Integer
    Public intPlateaAdulto As Integer
    Public intPlateaTerceraEdad As Integer
    Public intPlateaNi�o As Integer
    Public intPlateaEstudiante As Integer
    Public intPlateaNuAdulto As Integer
    Public intPlateaNuTerceraEdad As Integer
    Public intPlateaNuNi�o As Integer
    Public intPlateaNuEstudiante As Integer
    Public intPlatea As Integer = 2000
    Public intPlateaNumerada As Integer = 3500
    Public dbValorEntradaGeneral As Double
    Public dbTotalPronostico As Double
    Public strNotaMatine As String = "Hora: 11:00 horas" & vbCrLf & "Nota: Ud. tiene un plazo m�nimo de tres d�as antes de la producci�n del evento, para hacer anulaci�n de las entradas que adquiri�. En caso contrario no tiene derecho alguno, s�lo por motivos de fuerza mayor. Por ejemplo, la ausencia el/los artistas a presentarse"
    Public strNotaTarde As String = "Hora: 17:00 horas" & vbCrLf & "Nota: Ud. tiene un plazo m�nimo de tres d�as antes de la producci�n del evento, para hacer anulaci�n de las entradas que adquiri�. En caso contrario no tiene derecho alguno, s�lo por motivos de fuerza mayor. Por ejemplo, la ausencia el/los artistas a presentarse"
    Public strNotaNoche As String = "Hora: 20:00 horas" & vbCrLf & "Nota: Ud. tiene un plazo m�nimo de tres d�as antes de la producci�n del evento, para hacer anulaci�n de las entradas que adquiri�. En caso contrario no tiene derecho alguno, s�lo por motivos de fuerza mayor. Por ejemplo, la ausencia el/los artistas a presentarse"
End Module
