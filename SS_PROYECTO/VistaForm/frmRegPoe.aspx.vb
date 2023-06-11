Imports System.Windows.Forms

Public Class frmRegPoe
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If NumCliente.Text <> "" And NumPoe.Text <> "" And NomPoe.Text <> "" And ApPaterno.Text <> "" And
                ApMaterno.Text <> "" And RFC.Text <> "" And Tarjeta_1.Text <> "" And Tarjeta_2.Text <> "" Then
                If Tarjeta_1.Text <> Tarjeta_2.Text Then
                    Dim lc As New ConDoClientes()
                    lc.insertarPoes(NumCliente.Text, CInt(NumPoe.Text), NomPoe.Text, ApPaterno.Text,
                                        ApMaterno.Text, RFC.Text, CInt(Tarjeta_1.Text),
                                        CInt(Tarjeta_2.Text))
                    Limpiar()
                Else
                    MsgBox("Tarjeta 1 y Tarjeta 2 deben ser diferentes")
                End If
            Else
                MsgBox("No se puede insertar el cliente porque faltan algunos datos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Sub Limpiar()
        NumCliente.Text = ""
        NumPoe.Text = ""
        NomPoe.Text = ""
        ApPaterno.Text = ""
        ApMaterno.Text = ""
        RFC.Text = ""
        Tarjeta_1.Text = ""
        Tarjeta_2.Text = ""
        NomCliente.Text = ""
    End Sub

    Function EsNullCvCliente() As Boolean
        If NumCliente.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Function ObtenerNomCliente(cv_cliente As String) As String
        Try
            Dim lc As New ConDoClientes()
            Dim nomCliente As String = lc.ObtenerNombreCliente(cv_cliente)
            Return nomCliente
        Catch ex As Exception
            MsgBox("El número de cliente no existe")
        End Try
    End Function

    Protected Sub btnNumCliente_Click(sender As Object, e As EventArgs) Handles btnNumCliente.Click

        NomCliente.Text = ObtenerNomCliente(NumCliente.Text)

    End Sub

    Protected Sub btnReporteCliente_Click(sender As Object, e As EventArgs) Handles btnReporteCliente.Click
        Dim pdf As New ProcesarPDF()
        pdf.reporteCliente("Reporte 1")
    End Sub

    Protected Sub btnReportePoe_Click(sender As Object, e As EventArgs) Handles btnReportePoe.Click
        Dim pdf As New ProcesarPDF()
        pdf.reportePoe("Reporte 2")
    End Sub
End Class