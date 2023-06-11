Imports Oracle.DataAccess.Client

Public Class Conexion

    Protected con As New OracleConnection("USER ID=emmanuel;PASSWORD=Embg214VRZ;PERSIST SECURITY INFO=True;DATA SOURCE=localhost:1521/orcl;CONNECTION TIMEOUT=250;")

    Public Function conectar() As Boolean

        Try

            con.Open()
            'MsgBox("Conwxion Existosa")
            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Sub desconectar()
        Try

            If con.State = ConnectionState.Open Then
                con.Close()

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


End Class
