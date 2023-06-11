Imports Microsoft.Ajax.Utilities
Imports Oracle.DataAccess.Client
Public Class ConDoClientes

    Public Function insertarClientes(cv_cli As String, nom As String, tip_cli As String, calle As String, num As String, col As String, est As String, cop As String, nom_cont As String, tel As String, addres As String, pass As String, cv_org As String)
        Dim dc As New ModDoClientes(cv_cli, nom, tip_cli, calle, num, col, est, cop, nom_cont, tel, addres, pass, cv_org)

        If dc.insertarClientes(dc) = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function insertarPoes(cv_cli As String, cv_poe As Integer, nom As String, ap_pat As String,
                                 ap_mat As String, rfc As String, tarjet_1 As Integer, tarjet_2 As Integer)

        Dim dc As New ModPOES(cv_cli, cv_poe, nom, ap_pat, ap_mat, rfc, tarjet_1, tarjet_2)

        If dc.insertarPoes(dc) = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ObtenerNombreCliente(cv_cli As String)

        Try
            Dim dc As New ModPOES
            Dim NombreCliente As String

            NombreCliente = dc.ObntenerNombreCliente(cv_cli)

            Return NombreCliente

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try


    End Function

    Public Function ObtenerClaveCliente()

        Try
            Dim dc As New ModPOES
            Dim ClaveCliente As List(Of ModPOES)

            ClaveCliente = dc.ObtenerClaveCliente()

            Return ClaveCliente

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try


    End Function

End Class
