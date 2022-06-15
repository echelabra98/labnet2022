const nombre = document.getElementById("myname");
const apellidos = document.getElementById("surname");
const correo = document.getElementById("email");
const celular = document.getElementById("mobile");
const contrasenia = document.getElementById("password");
const contrasenia2 = document.getElementById("repeatPassword");
const empresa1 = document.getElementById("empresa");
const terminosYcondiciones = document.getElementById("termsAndConditions");
const form = document.getElementById("form");
const listInputs = document.querySelectorAll(".form-input");
const fechaNacimiento = document.getElementById("fechaNacimiento");
const edad = document.getElementById("edad");

const calcularEdad =(fechaNacimiento)=>{
  const fechaActual = new Date();
  const anoActual = parseInt(fechaActual.getFullYear());
  const mesActual = parseInt(fechaActual.getMonth())+1;
  const diaActual = parseInt(fechaActual.getDate());

  const anoNacimiento=parseInt(String(fechaNacimiento).substring(0,4));
  const mesNacimiento=parseInt(String(fechaNacimiento).substring(5,7));
  const diaNacimiento=parseInt(String(fechaNacimiento).substring(8,10));

  let edad = anoActual-anoNacimiento;
  if(mesActual<mesNacimiento){
    edad--;
  }else if(mesActual ===mesNacimiento){
    if(diaActual<diaNacimiento){
      edad--;
    }
  }
  return edad;
};

window.addEventListener('load', function() {
  fechaNacimiento.addEventListener('change', function(){
    if(this.value){
      edad.innerHTML = `Usted tiene ${calcularEdad(this.value)} años`;
    }
  });
});


form.addEventListener("submit", (e) => {
  e.preventDefault();
  let condicion = validacionForm();
  if (condicion) {
    enviarFormulario();
  }
  
});



function validacionForm() {
  form.lastElementChild.innerHTML = "";
  let condicion = true;
  listInputs.forEach((element) => {
    element.lastElementChild.innerHTML = "";
  });

  if (nombre.value.length < 1 || nombre.value.trim() == "") {
    mostrarMensajeError("myname", "Nombre no valido*");
    condicion = false;
  }
  if (apellidos.value.length < 1 || apellidos.value.trim() == "") {
    mostrarMensajeError("surname", "Apellido no valido");
    condicion = false;
  }
  if (correo.value.length < 1 || correo.value.trim() == "") {
    mostrarMensajeError("email", "Correo no valido*");
    condicion = false;
  }
  if (
    celular.value.length != 9 ||
    celular.value.trim() == "" ||
    isNaN(celular.value)
  ) {
    mostrarMensajeError("mobile", "Celular no valido*");
    condicion = false;
  }
  if (contrasenia.value.length < 1 || contrasenia.value.trim() == "") {
    mostrarMensajeError("password", "Contraseña no valido*");
    condicion = false;
  }
  if (contrasenia2.value != contrasenia.value) {
    mostrarMensajeError("repeatPassword", "Contraseña error*");
    condicion = false;
  }
  if (empresa1.value.length < 1 || empresa1.value.trim() == "") {
    mostrarMensajeError("empresa", "Empresa no valida*");
    condicion = false;
  }
  if (!terminosYcondiciones.checked) {
    mostrarMensajeError("termsAndConditions", "Acepte*");
    condicion = false;
  } else {
    mostrarMensajeError("termsAndConditions", "");
  }
  return condicion;
}

function mostrarMensajeError(claseInput, mensaje) {
  let elemento = document.querySelector(`.${claseInput}`);
  elemento.lastElementChild.innerHTML = mensaje;
}

function enviarFormulario() {
  form.reset();
  form.lastElementChild.innerHTML = "El formulario ha sido enviado con éxito";
}