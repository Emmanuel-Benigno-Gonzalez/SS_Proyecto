Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Web.Services.Description
Imports Oracle.DataAccess.Client

Public Class ModPOES
    Inherits Conexion
    Private _CV_CLIENTE As String
    Private _CV_POE As Integer
    Private _NOMBRE As String
    Private _AP_PATERNO As String
    Private _AP_MATERNO As String
    Private _RFC As String
    Private _TARJETA_1 As Integer
    Private _TARJETA_2 As Integer

    Private cmd As OracleCommand

    Public Sub New(cv_cli As String, cv_poe As Integer, nom As String, ap_pat As String, ap_mat As String, rfc As String, tarjet_1 As Integer, tarjet_2 As Integer)

        _CV_CLIENTE = cv_cli
        _CV_POE = cv_poe
        _NOMBRE = nom
        _AP_PATERNO = ap_pat
        _AP_MATERNO = ap_mat
        _RFC = rfc
        _TARJETA_1 = tarjet_1
        _TARJETA_2 = tarjet_2

    End Sub

    Public Sub New()

    End Sub

    Public Property CV_CLIENTE() As String
        Get
            Return _CV_CLIENTE
        End Get
        Set(ByVal value As String)
            _CV_CLIENTE = value
        End Set
    End Property

    Public Property CV_POE() As Integer
        Get
            Return _CV_POE
        End Get
        Set(ByVal value As Integer)
            _CV_POE = value
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property

    Public Property AP_PATERNO() As String
        Get
            Return _AP_PATERNO
        End Get
        Set(ByVal value As String)
            _AP_PATERNO = value
        End Set
    End Property

    Public Property AP_MATERNO() As String
        Get
            Return _AP_MATERNO
        End Get
        Set(ByVal value As String)
            _AP_MATERNO = value
        End Set
    End Property

    Public Property AP_RFC() As String
        Get
            Return _RFC
        End Get
        Set(ByVal value As String)
            _RFC = value
        End Set
    End Property

    Public Property TARJETA_1() As Integer
        Get
            Return _TARJETA_1
        End Get
        Set(ByVal value As Integer)
            _TARJETA_1 = value
        End Set
    End Property

    Public Property TARJETA_2() As Integer
        Get
            Return _TARJETA_2
        End Get
        Set(ByVal value As Integer)
            _TARJETA_2 = value
        End Set
    End Property

    Public Function insertarPoes(dc As ModPOES) As Boolean

        If ExistePoe(dc._CV_POE) <> True Then
            Try
                conectar()

                Dim sql As String = "INSERT INTO POES(CV_CLIENTE,CV_POE,NOMBRE_POE,AP_PATERNO,AP_MATERNO,RFC,
            TARJETA_1,TARJETA_2)VALUES('" & dc.CV_CLIENTE & "'," & dc.CV_POE & ",'" &
                dc.NOMBRE & "','" & dc.AP_PATERNO & "','" & dc.AP_MATERNO & "','" & dc._RFC & "'," &
                dc.TARJETA_1 & "," & dc.TARJETA_2 & ")"

                cmd = New OracleCommand(sql, con)

                If cmd.ExecuteNonQuery() Then
                    MsgBox("El Poe se agrego exitosamente")
                    Return True
                Else
                    MsgBox("El Poe no se agrego")
                    Return False
                End If

            Catch ex As Exception

                MsgBox(ex.Message)
                Return False

            Finally
                desconectar()

            End Try
        Else
            MsgBox("El POE ya cuenta con un Registro")
        End If

    End Function

    'OBTENER LA CLAVE DE LOS CLIENTES DISPONIBLES'
    Public Function ObtenerClaveCliente() As List(Of ModPOES)
        Dim salida As New List(Of ModPOES)
        Dim respuesta As OracleDataReader

        Try
            conectar()
            Dim sql As String = "SELECT CV_CLIENTE from DO_CLIENTES"
            cmd = New OracleCommand(sql, con)

            respuesta = cmd.ExecuteReader()

            While respuesta.Read
                salida.Add(respuesta.Item(CV_CLIENTE))
            End While
            respuesta.Close()
            Return salida

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'OBTENER EL NOMBRE DEL CLIENTE A TRAVES DEL CV_CLIENTE'
    Public Function ObntenerNombreCliente(cv_cli As String) As String
        Dim salida As String
        Try
            conectar()
            Dim sql As String = "SELECT NOMBRE_CLIENTE from DO_CLIENTES WHERE CV_CLIENTE='" & cv_cli & "'"
            cmd = New OracleCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New OracleDataAdapter(cmd)
                Dim dr As DataRow

                adp.Fill(dt)
                dr = dt.Rows.Item(0)
                salida = dr.Item("NOMBRE_CLIENTE")
                Return salida
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'OBTENER CLIENTE'
    Public Function ObtenerReporte() As DataTable

        Try
            conectar()
            Dim sql As String = "SELECT * from POES  INNER JOIN DO_CLIENTES ON POES.CV_CLIENTE=DO_CLIENTES.CV_CLIENTE"
            cmd = New OracleCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New OracleDataAdapter(cmd)
                adp.Fill(dt)

                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    'Verificar que los POES no se repitan, es decir que tengan varios clientes
    Public Function ExistePoe(cv_poe As String) As Boolean
        Try
            conectar()
            Dim sql As String = "SELECT * from POES WHERE CV_POE='" & cv_poe & "'"
            cmd = New OracleCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adp As New OracleDataAdapter(cmd)
                Dim dr As DataRow

                adp.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return Nothing
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectar()

        End Try

    End Function

End Class
