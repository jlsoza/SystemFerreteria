Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class WebService
    Inherits System.Web.Services.WebService
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function

    <WebMethod()>
    Public Function ListarTipoCambio() As DataTable
        Dim dt As New DataTable("tabla")
        Dim cn As New SqlConnection(cnx.ConnectionString)
        Try
            Dim cmd As New SqlCommand("Sp_ListarTipoCambio", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter
        Catch ex As Exception

        End Try

    End Function

End Class