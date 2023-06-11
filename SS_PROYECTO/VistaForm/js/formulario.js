const formulario = document.getElementById('formulario');
const inputs = document.querySelectorAll('#formulario input');

const expresiones = {
	NumCliente: /^([0-9]{1,7}\*|[0-9]{1,8})$/, // *numeros
	Calle: /^[a-zA-ZÀ-ÿ0-9\.\s]{3,50}$/, // Letras y espacios, pueden llevar acentos.
	Colonia: /^[a-zA-ZÀ-ÿ0-9\.\s]{3,50}$/,
	CodPostal: /^[0-9]{5}$/, // 4 a 12 digitos.
	Telefono: /^[0-9]{10,15}$/, // numero de telefono
	//ClaveOrg: /^([0-9a-zA-Z]{1,7}\*|[0-9a-zA-Z]{1,8})$/, // *numeros
	ClaveOrg: /^([0-9]{1,7}\*|[0-9]{1,8})$/, // *numeros
	NomCliente: /^[a-zA-ZÀ-ÿ\.\s]{3,50}$/, //Nombre del Cliente
	NumExterior: /^[0-9]{1,6}$/, // numero de exterior
	NomContacto: /^[a-zA-ZÀ-ÿ\.\s]{3,50}$/, //Nombre de Contacto
	//password: /^.{4,12}$/, // 4 a 12 digitos.
	Correo: /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/
}

const campos = {
	NumCliente: false,
	Calle: false,
	Colonia: false,
	CodPostal: false,
	Telefono: false,
	ClaveOrg: false,
	NomCliente: false,
	NumExterior: false,
	NomContacto: false,
	Correo: false
}

const validarFormulario = (e) => {
	switch (e.target.name) {
		case "NumCliente":
			validarCampo(expresiones.NumCliente, e.target, 'NumCliente');
			break;
		case "Calle":
			validarCampo(expresiones.Calle, e.target, 'Calle');
			break;
		case "Colonia":
			validarCampo(expresiones.Colonia, e.target, 'Colonia');
			break;
		case "CodPostal":
			validarCampo(expresiones.CodPostal, e.target, 'CodPostal');
			break;
		case "Telefono":
			validarCampo(expresiones.Telefono, e.target, 'Telefono');
			break;
		case "ClaveOrg":
			validarCampo(expresiones.ClaveOrg, e.target, 'ClaveOrg');
			break;
		case "NomCliente":
			validarCampo(expresiones.NomCliente, e.target, 'NomCliente');
			break;
		case "NumExterior":
			validarCampo(expresiones.NumExterior, e.target, 'NumExterior');
			break;
		case "NomContacto":
			validarCampo(expresiones.NomContacto, e.target, 'NomContacto');
			break;
		case "Correo":
			validarCampo(expresiones.Correo, e.target, 'Correo');
			break;
	}
}

const validarCampo = (expresion, input, campo) => {
	if (expresion.test(input.value)) {
		document.getElementById(`grupo__${campo}`).classList.remove('formulario__grupo-incorrecto');
		document.getElementById(`grupo__${campo}`).classList.add('formulario__grupo-correcto');
		document.querySelector(`#grupo__${campo} i`).classList.add('fa-check-circle');
		document.querySelector(`#grupo__${campo} i`).classList.remove('fa-times-circle');
		document.querySelector(`#grupo__${campo} .formulario__input-error`).classList.remove('formulario__input-error-activo');
		campos[campo] = true;
	} else {
		document.getElementById(`grupo__${campo}`).classList.add('formulario__grupo-incorrecto');
		document.getElementById(`grupo__${campo}`).classList.remove('formulario__grupo-correcto');
		document.querySelector(`#grupo__${campo} i`).classList.add('fa-times-circle');
		document.querySelector(`#grupo__${campo} i`).classList.remove('fa-check-circle');
		document.querySelector(`#grupo__${campo} .formulario__input-error`).classList.add('formulario__input-error-activo');
		campos[campo] = false;
	}
}

inputs.forEach((input) => {
	input.addEventListener('keyup', validarFormulario);
	input.addEventListener('blur', validarFormulario);
});

formulario.addEventListener('submit', (e) => {
	//e.preventDefault();
	if (campos.NumCliente && campos.Calle && campos.Colonia && campos.CodPostal && campos.Telefono && campos.ClaveOrg && campos.NomCliente && campos.NumExterior && campos.NomContacto && campos.Correo) {
		//formulario.reset();

		document.getElementById('formulario__mensaje-exito').classList.add('formulario__mensaje-exito-activo');
		setTimeout(() => {
			document.getElementById('formulario__mensaje-exito').classList.remove('formulario__mensaje-exito-activo');
		}, 5000);

		document.querySelectorAll('.formulario__grupo-correcto').forEach((icono) => {
			icono.classList.remove('formulario__grupo-correcto');
		});
	} else {
		document.getElementById('formulario__mensaje').classList.add('formulario__mensaje-activo');
	}

});