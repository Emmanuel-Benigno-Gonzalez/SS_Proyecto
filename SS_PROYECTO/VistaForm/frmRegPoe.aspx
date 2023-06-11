<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRegPoe.aspx.vb" Inherits="SS_PROYECTO.frmRegPoe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Registro Poes</title>
    <link rel="preload" href="css/normalize.css" as="style"/>
    <link rel="stylesheet" href="css/normalize.css"/>
    <link rel="preload" href="css/estilos.css" as="style"/>
    <link href="css/estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="formulario" runat="server">
        <header class="header">
            <div class="encabezados">
                <section class="encabezado">
                    <div class="logo">
                        <img id="inin" src="img/Inin.png" />
                    </div>
                </section>
                <section class="encabezado">
                    <h1>Instituto Nacional de Investigaciones Nucleares <br>
                        Metrología de Radiaciones Ionizantes <br>
                        Dosimetría Personal
                    </h1>
                </section>
            </div>
        </header>
        <main>
            <h2 id="Subtext">Registro del Catálogo de Poes</h2>

            <div class="contenidoGeneral">
                <div class="opciones">
                    <div class="opcion-tabla">
                        <table class="tabla-usuarios">
                            <tr>
                                <th class="th">Usuarios Externos</th>
                            </tr>
                            <tr>
                                <td class="td">
                                    <a href="frmRegCli.aspx">Registro</a><br />
                                    <a href="frmRegPoe.aspx">Registro POES</a><br />
                                    <a href="index.html">Consultar</a>
                                </td>
                            </tr>
                            <tr>
                                <th class="th">Usuarios Internos</th>
                            </tr>
                            <tr>
                                <td class="td">
                                    <a href="index.html">POES</a>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="opcion-boton">
                        <div>
                            <asp:Button class="boton" ID="btnAv_priv" runat="server" Text="Aviso de Privacidad" />
                        </div>
                        <div>
                            <asp:Button class="boton" ID="btnAyuda" runat="server" Text="Ayuda" />
                        </div>
                        <div>
                            <asp:Button class="boton" ID="btnClose_sesion" runat="server" Text="Cerrar Sesion" />
                        </div>
                        <div>
                            <asp:Button class="boton" ID="btnReporteCliente" runat="server" Text="Reporte por Cliente" />
                        </div>
                        <div>
                            <asp:Button class="boton" ID="btnReportePoe" runat="server" Text="Reporte por Poe" />
                        </div>
                    </div>
                </div>
                <div id="contenedor-campos" class="formulario">
                    <div class="campo divicion">                
                        <!-- Grupo: Numero de Cliente -->
                        <div class="contenedor-NumCliente">
                            <div class="campo-NumCliente">
                                <div class="formulario__grupo" id="grupo__NumCliente">
                                    <asp:Label runat="server" for="NumCliente" class="formulario__label" Text="Número de Cliente:"></asp:Label>
				                    <div class="formulario__grupo-input">
                                        <asp:TextBox ID="NumCliente" runat="server" type="text" class="formulario__input" name="NumCliente" placeholder="Número de Cliente"></asp:TextBox>
                                        <i class="formulario__validacion-estado fas fa-times-circle"></i>
				                    </div>
				                    <p class="formulario__input-error">El número de cliente deben ser números con un rango <br>máximo de 8 dígitos, con opción de un "*" al final.</p>
			                    </div>
                            </div>
			                <div class="campo-NumCliente">   
                                <asp:Button ID="btnNumCliente" runat="server" type="submit" Text="Buscar" />                   
			                </div>
                        </div>
                        
                        <!-- Grupo: NumPoe -->
                        <div class="formulario__grupo" id="grupo__NumPoe">
                            <asp:Label runat="server" for="NumPoe" class="formulario__label" Text="Número de POE:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="NumPoe" runat="server" type="text" class="formulario__input" name="NumPoe" placeholder="Número de POE"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo acepta 4 dígitos.</p>
			            </div>
                        <!-- Grupo: ApPaterno -->
                        <div class="formulario__grupo" id="grupo__ApPaterno">
                            <asp:Label runat="server" for="ApPaterno" class="formulario__label" Text="Apellido Paterno:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="ApPaterno" runat="server" type="text" class="formulario__input" name="ApPaterno" placeholder="Apellido Paterno"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo como mínimo debe tener 3 caracteres <br>y como máximo 60 caracteres.</p>
			            </div>
                        <!-- Grupo: RFC -->
                        <div class="formulario__grupo" id="grupo__RFC">
                            <asp:Label runat="server" for="RFC" class="formulario__label" Text="RFC:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="RFC" runat="server" type="text" class="formulario__input" name="RFC" placeholder="RFC"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo debe tener 10 caracteres.</p>
			            </div>
                        <!-- Grupo: Tarjeta_2 -->
                        <div class="formulario__grupo" id="grupo__Tarjeta_2">
                            <asp:Label runat="server" for="Tarjeta_2" class="formulario__label" Text="Tarjeta 2:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="Tarjeta_2" runat="server" type="text" class="formulario__input" name="Tarjeta_2" placeholder="Tarjeta 2"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo debe contener 7 dígitos.</p>
			            </div>
                    </div>
                    <div class="campo">
                        <!-- Grupo: Nombre de Cliente -->
                        <div class="formulario__grupo" id="grupo__NomCliente">
                            <asp:Label runat="server" for="NomCliente" class="formulario__label" Text="Nombre de Cliente:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="NomCliente" runat="server" type="text" class="formulario__input" name="NomCliente" placeholder="Razón Social" ReadOnly="True"></asp:TextBox>     
				            </div>
			            </div>
                        <!-- Grupo: NomPoe -->
                        <div class="formulario__grupo" id="grupo__NomPoe">
                            <asp:Label runat="server" for="NomPoe" class="formulario__label" Text="Nombre:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox id="NomPoe" runat="server" type="text" class="formulario__input" name="NomPoe" placeholder="Nombre del POE"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo como mínimo debe tener 3 caracteres <br>y como máximo 60 caracteres.</p>
			            </div>
                        <!-- Grupo: ApMaterno -->
                        <div class="formulario__grupo" id="grupo__ApMaterno">
                            <asp:Label runat="server" for="ApMaterno" class="formulario__label" Text="Apellido Materno:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="ApMaterno" runat="server" type="text" class="formulario__input" name="ApMaterno" placeholder="Apellido Materno"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo como mínimo debe tener 3 caracteres <br>y como máximo 60 caracteres.</p>
			            </div>
                        <!-- Grupo: Tarjeta_1 -->
                        <div class="formulario__grupo" id="grupo__Tarjeta_1">
                            <asp:Label runat="server" for="Tarjeta_1" class="formulario__label" Text="Tarjeta 1:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="Tarjeta_1" runat="server" type="text" class="formulario__input" name="Tarjeta_1" placeholder="Tarjeta 1"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo debe contener 7 dígitos.</p>
			            </div>    
                    </div>
                    <div class="campo">
                         <div class="formulario__mensaje" id="formulario__mensaje">
				            <p><i class="fas fa-exclamation-triangle"></i> <b>Error:</b> Por favor rellena el formulario correctamente. </p>
			            </div>
                    </div>
                    <div class="campo">
                        <div class="formulario__grupo formulario__grupo-btn-enviar">
                            <asp:Button ID="btnAceptar" runat="server" type="submit" class="formulario__btn" Text="Aceptar" />
                            <p class="formulario__mensaje-exito" id="formulario__mensaje-exito">Formulario enviado exitosamente!</p>                       
                        </div>
                    </div>
                    <div class="campo">
                        <div class="formulario__grupo formulario__grupo-btn-limpiar">
                            <asp:Button ID="btnLimpiar" runat="server" type="submit" class="formulario__btn" Text="Limpiar" />
                        </div>
                    </div>
                </div>
            </div> 
        </main>
    </form> 
  <script src="js/ValidacionPoes.js"></script>
  <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script> 
</body>
</html>
