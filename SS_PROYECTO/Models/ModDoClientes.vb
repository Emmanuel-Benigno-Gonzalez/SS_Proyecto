Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports Oracle.DataAccess.Client
Public Class ModDoClientes
    Inherits Conexion
    Private _CV_CLIENTE As String
    Private _NOMBRE As String
    Private _TIPO_CLI As String
    Private _CALLE As String
    Private _NUMERO As String
    Private _COLONIA As String
    Private _ESTADO As String
    Private _COP As String
    Private _NOMBRE_CONTACTO As String
    Private _TELEFONO As String
    Private _CORREO_ELECT As String
    Private _PASSWORD As String
    Private _CV_ORGANIZACION As String

    Private cmd As OracleCommand

    Public Sub New(cv_cli As String, nom As String, tip_cli As String, calle As String, num As String, col As String, est As String, cop As String, nom_cont As String, tel As String, addres As String, pass As String, cv_org As String)

        _CV_CLIENTE = cv_cli
        _NOMBRE = nom
        _TIPO_CLI = tip_cli
        _CALLE = calle
        _NUMERO = num
        _COLONIA = col
        _ESTADO = est
        _COP = cop
        _NOMBRE_CONTACTO = nom_cont
        _TELEFONO = tel
        _CORREO_ELECT = addres
        _PASSWORD = pass
        _CV_ORGANIZACION = cv_org

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

    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property
    Public Property TIPO_CLI() As String
        Get
            Return _TIPO_CLI
        End Get
        Set(ByVal value As String)
            _TIPO_CLI = value
        End Set
    End Property
    Public Property CALLE() As String
        Get
            Return _CALLE
        End Get
        Set(ByVal value As String)
            _CALLE = value
        End Set
    End Property
    Public Property NUMERO() As String
        Get
            Return _NUMERO
        End Get
        Set(ByVal value As String)
            _NUMERO = value
        End Set
    End Property
    Public Property COLONIA() As String
        Get
            Return _COLONIA
        End Get
        Set(ByVal value As String)
            _COLONIA = value
        End Set
    End Property
    Public Property ESTADO() As String
        Get
            Return _ESTADO
        End Get
        Set(ByVal value As String)
            _ESTADO = value
        End Set
    End Property
    Public Property COP() As String
        Get
            Return _COP
        End Get
        Set(ByVal value As String)
            _COP = value
        End Set
    End Property
    Public Property NOMBRE_CONTACTO() As String
        Get
            Return _NOMBRE_CONTACTO
        End Get
        Set(ByVal value As String)
            _NOMBRE_CONTACTO = value
        End Set
    End Property
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal value As String)
            _TELEFONO = value
        End Set
    End Property
    Public Property CORREO_ELECT() As String
        Get
            Return _CORREO_ELECT
        End Get
        Set(ByVal value As String)
            _CORREO_ELECT = value
        End Set
    End Property
    Public Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(ByVal value As String)
            _PASSWORD = value
        End Set
    End Property
    Public Property CV_ORGANIZACION() As String
        Get
            Return _CV_ORGANIZACION
        End Get
        Set(ByVal value As String)
            _CV_ORGANIZACION = value
        End Set
    End Property

    Public Function insertarClientes(dc As ModDoClientes) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO DO_CLIENTES(CV_CLIENTE,NOMBRE_CLIENTE,TIPO_CLI,CALLE,NUMERO,COLONIA,ESTADO,
            COP,NOMBRE_CONTACTO,TELEFONO,CORREO_ELECT,PASSWORD,CV_ORGANIZACION)VALUES('" & dc.CV_CLIENTE & "','" &
            dc.NOMBRE & "','" & dc.TIPO_CLI & "','" & dc.CALLE & "','" & dc.NUMERO & "','" & COLONIA & "','" &
            ESTADO & "','" & COP & "','" & NOMBRE_CONTACTO & "','" & TELEFONO & "','" & CORREO_ELECT & "','" &
            PASSWORD & "','" & CV_ORGANIZACION & "')"

            cmd = New OracleCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
                MsgBox("El cliente se agrego exitosamente")
                Return True
            Else
                MsgBox("El cliente no se agrego")
                Return False
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally
            desconectar()

        End Try

    End Function

End Class
