const formulario = document.getElementById('formulario');
const inputs = document.querySelectorAll('#formulario input');

const expresiones = {
	NumCliente: /^([0-9]{1,7}\*|[0-9]{1,8})$/, // *numeros
	NomPoe: /^[a-zA-ZÀ-ÿ\.\s]{3,60}$/, //Nombre del Poe
	ApMaterno: /^[a-zA-ZÀ-ÿ\s]{3,60}$/, //Apellido Materno
	Tarjeta_1: /^[0-9]{7}$/, // Trajeta 1 --> 7 digitos.
	NumPoe: /^[0-9]{4}$/, // NumPoe --> 4 digitos.
	ApPaterno: /^[a-zA-ZÀ-ÿ\s]{3,60}$/, //Apellido Paterno
	RFC: /^[A-Z0-9]{10}$/, // RFC
    Tarjeta_2: /^[0-9]{7}$/ // Trajeta 2 --> 7 digitos.
}

const campos = {
	NumCliente: false,
	NomPoe: false,
	ApMaterno: false,
	Tarjeta_1: false,
	NumPoe: false,
	ApPaterno: false,
	RFC: false,
	Tarjeta_2: false,
}

const validarFormulario = (e) => {
	switch (e.target.name) {
		case "NumCliente":
			validarCampo(expresiones.NumCliente, e.target, 'NumCliente');
			break;
		case "NomPoe":
			validarCampo(expresiones.NomPoe, e.target, 'NomPoe');
			break;
		case "ApMaterno":
			validarCampo(expresiones.ApMaterno, e.target, 'ApMaterno');
			break;
		case "Tarjeta_1":
			validarCampo(expresiones.Tarjeta_1, e.target, 'Tarjeta_1');
			break;
		case "NumPoe":
			validarCampo(expresiones.NumPoe, e.target, 'NumPoe');
			break;
		case "ApPaterno":
			validarCampo(expresiones.ApPaterno, e.target, 'ApPaterno');
			break;
		case "RFC":
			validarCampo(expresiones.RFC, e.target, 'RFC');
			break;
		case "Tarjeta_2":
			validarCampo(expresiones.Tarjeta_2, e.target, 'Tarjeta_2');
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
	if (campos.NumCliente && campos.NomPoe && campos.ApMaterno && campos.Tarjeta_1 && campos.NumPoe && campos.ApPaterno && campos.RFC && campos.Tarjeta_2) {
		formulario.reset();

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