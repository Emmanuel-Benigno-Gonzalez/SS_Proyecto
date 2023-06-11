Public Class frmRegCli
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If NumCliente.Text <> "" And Calle.Text <> "" And Colonia.Text <> "" And CodPostal.Text <> "" And
                Telefono.Text <> "" And ClaveOrg.Text <> "" And NomCliente.Text <> "" And NumExterior.Text <> "" And
                Estado.SelectedValue.ToString() <> "" And NomContacto.Text <> "" And Correo.Text <> "" Then

                Dim lc As New ConDoClientes()

                lc.insertarClientes(NumCliente.Text, NomCliente.Text, "EXT", Calle.Text, NumExterior.Text,
                                Colonia.Text, Estado.SelectedItem.ToString(), CodPostal.Text, NomContacto.Text,
                                Telefono.Text, Correo.Text, "", ClaveOrg.Text)
                Limpiar()
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

    Public Sub Limpiar()
        NumCliente.Text = ""
        NomCliente.Text = ""
        Calle.Text = ""
        NumExterior.Text = ""
        Colonia.Text = ""
        Estado.ClearSelection()
        CodPostal.Text = ""
        NomContacto.Text = ""
        Telefono.Text = ""
        Correo.Text = ""
        ClaveOrg.Text = ""
    End Sub

End Class