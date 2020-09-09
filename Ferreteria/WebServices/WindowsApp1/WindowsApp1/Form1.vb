Imports System.Data


Public Class Form1
    Dim servicio As New ni.gob.bcn.servicios.Tipo_Cambio_BCN
    Dim tbl As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        tbl = servicio.RecuperaTC_Mes()

    End Sub
End Class
