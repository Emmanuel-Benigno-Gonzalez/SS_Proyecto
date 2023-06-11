<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRegCli.aspx.vb" Inherits="SS_PROYECTO.frmRegCli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>

    <title>Registro Clientes</title>
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
            <h2 id="Subtext">Registro del Catálogo de Clientes</h2>
            
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
                    </div>
                </div>
                <div id="contenedor-campos" class="formulario">
                    <div class="campo">                
                        <!-- Grupo: Numero de Cliente -->
			            <div class="formulario__grupo" id="grupo__NumCliente">
                            <asp:Label runat="server" for="NumCliente" class="formulario__label" Text="Número de Cliente:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="NumCliente" runat="server" type="text" class="formulario__input" name="NumCliente" placeholder="Número de Cliente"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">El número de cliente deben ser números <br /> con un máximo de 8 dígitos.</p>
			            </div>
                        <!-- Grupo: Calle -->
                        <div class="formulario__grupo" id="grupo__Calle">
                            <asp:Label runat="server" for="Calle" class="formulario__label" Text="Calle:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox id="Calle" runat="server" type="text" class="formulario__input" name="Calle" placeholder="Domicilio"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Mínimo debe de tener 3 caracteres y máximo 50.</p>
			            </div>
                        <!-- Grupo: Colonia -->
                        <div class="formulario__grupo" id="grupo__Colonia">
                            <asp:Label runat="server" for="Colonia" class="formulario__label" Text="Colonia:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="Colonia" runat="server" type="text" class="formulario__input" name="Colonia" placeholder="Sector, delegación"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Mínimo debe de tener 3 caracteres y máximo 50.</p>
			            </div>
                        <!-- Grupo: Codigo Postal -->
                        <div class="formulario__grupo" id="grupo__CodPostal">
                            <asp:Label runat="server" for="CodPostal" class="formulario__label" Text="Código Postal:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="CodPostal" runat="server" type="text" class="formulario__input" name="CodPostal" placeholder="C.P."></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo debe contener 5 dígitos.</p>
			            </div>
                        <!-- Grupo: Telefono -->
                        <div class="formulario__grupo" id="grupo__Telefono">
                            <asp:Label runat="server" for="Telefono" class="formulario__label" Text="Teléfono:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="Telefono" runat="server" type="text" class="formulario__input" name="Telefono" placeholder="Teléfono de Contacto"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">El número de Teléfono debe contener 10 dígitos.</p>
			            </div>
                        <!-- Grupo: Clave de Organizacion -->
                        <div class="formulario__grupo" id="grupo__ClaveOrg">
                            <asp:Label runat="server" for="ClaveOrg" class="formulario__label" Text="Clave Organizacion:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="ClaveOrg" runat="server" type="text" class="formulario__input" name="ClaveOrg" placeholder="Clave de Organizacion"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo como máximo acpeta 8 caracteres.</p>
			            </div>
                    </div>
                    <div class="campo">
                        <!-- Grupo: Nombre de Cliente -->
                        <div class="formulario__grupo" id="grupo__NomCliente">
                            <asp:Label runat="server" for="NomCliente" class="formulario__label" Text="Nombre de Cliente:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="NomCliente" runat="server" type="text" class="formulario__input" name="NomCliente" placeholder="Razón Social"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo como mínimo debe tener 3 caracteres <br>y como máximo 50 caracteres.</p>
			            </div>
                        <!-- Grupo: Numero Exterior -->
                        <div class="formulario__grupo" id="grupo__NumExterior">
                            <asp:Label runat="server" for="NumExterior" class="formulario__label" Text="Número Exterior:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="NumExterior" runat="server" type="text" class="formulario__input" name="NumExterior" placeholder="Número Exterior"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo acepta de 1-6 dígitos.</p>
			            </div>
                        <!-- Grupo: Estado -->
                        <div class="formulario__grupo" id="grupo__Estado">
                            <asp:Label runat="server" for="Estado" class="formulario__label" Text="Estado:"></asp:Label>
                            <div class="formulario__grupo-input">
                                <asp:DropDownList runat="server" id="Estado" name="Estado" aria-label="Estado" AppendDataBoundItems="true" class="formulario__input">
                                        <asp:ListItem Text="Selecciona una Opción" Value="" />
                                        <asp:listitem text="Aguascalientes" value="1"></asp:listitem>
                                        <asp:listitem text="Baja California" value="2"></asp:listitem>
                                        <asp:listitem text="Baja California Sur" value="3"></asp:listitem>
                                        <asp:listitem text="Campeche" value="4"></asp:listitem>
                                        <asp:listitem text="Chiapas" value="5"></asp:listitem>
                                        <asp:listitem text="Chihuahua" value="6"></asp:listitem>
                                        <asp:listitem text="Ciudad de México" value="7"></asp:listitem>
                                        <asp:listitem text="Coahuila" value="8"></asp:listitem>
                                        <asp:listitem text="Colima" value="9"></asp:listitem>
                                        <asp:listitem text="Durango" value="10"></asp:listitem>
                                        <asp:listitem text="Estado de México" value="11"></asp:listitem>
                                        <asp:listitem text="Guanajuato" value="12"></asp:listitem>
                                        <asp:listitem text="Guerrero" value="13"></asp:listitem>
                                        <asp:listitem text="Hidalgo" value="14"></asp:listitem>
                                        <asp:listitem text="Jalisco" value="15"></asp:listitem>
                                        <asp:listitem text="Michoacán" value="16"></asp:listitem>
                                        <asp:listitem text="Morelos" value="17"></asp:listitem>
                                        <asp:listitem text="Nayarit" value="18"></asp:listitem>
                                        <asp:listitem text="Nuevo León" value="19"></asp:listitem>
                                        <asp:listitem text="Oaxaca" value="20"></asp:listitem>
                                        <asp:listitem text="Puebla" value="21"></asp:listitem>
                                        <asp:listitem text="Querétaro" value="22"></asp:listitem>
                                        <asp:listitem text="Quintana Roo" value="23"></asp:listitem>
                                        <asp:listitem text="San Luis Potosí" value="24"></asp:listitem>
                                        <asp:listitem text="Sinaloa" value="25"></asp:listitem>
                                        <asp:listitem text="Sonora" value="26"></asp:listitem>
                                        <asp:listitem text="Tabasco" value="27"></asp:listitem>
                                        <asp:listitem text="Tamaulipas" value="28"></asp:listitem>
                                        <asp:listitem text="Tlaxcala" value="29"></asp:listitem>
                                        <asp:listitem text="Veracruz" value="30"></asp:listitem>
                                        <asp:listitem text="Yucatán" value="31"></asp:listitem>
                                        <asp:listitem text="Zacatecas" value="32"></asp:listitem>
                                    </asp:DropDownList>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Seleccione una opción valida.</p>
			            </div>
                        <!-- Grupo: Persona de Contacto -->
                        <div class="formulario__grupo" id="grupo__NomContacto">
                            <asp:Label runat="server" for="NomContacto" class="formulario__label" Text="Nombre de Contacto:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="NomContacto" runat="server" type="text" class="formulario__input" name="NomContacto" placeholder="Persona de Contacto"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">Este campo como mínimo debe tener 3 caracteres <br>y como máximo 50 caracteres.</p>
			            </div>
                         <!-- Grupo: Correo -->
                        <div class="formulario__grupo" id="grupo__Correo">
                            <asp:Label runat="server" for="Correo" class="formulario__label" Text="Correo Electrónico:"></asp:Label>
				            <div class="formulario__grupo-input">
                                <asp:TextBox ID="Correo" runat="server" type="text" class="formulario__input" name="Correo" placeholder="Dirección de Correo"></asp:TextBox>
                                <i class="formulario__validacion-estado fas fa-times-circle"></i>
				            </div>
				            <p class="formulario__input-error">El correo solo puede contener letras, <br>numeros, puntos, guiones y guion bajo.</p>
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
        
        <script src="js/formulario.js"></script>
	    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script>        
</body>
</html>
