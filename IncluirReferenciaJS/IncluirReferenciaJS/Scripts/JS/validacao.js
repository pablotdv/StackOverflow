function Mascara(formato, objeto) {
    campo = eval(objeto);
    // CEP
    if (formato == 'CEP') {
        var CodCar = event.keyCode;
        if (CodCar < 48 || CodCar > 57) {
            campo.focus();
            event.returnValue = false;
        }
        separador = '-';
        conjunto1 = 5;
        if (campo.value.length == conjunto1) {
            campo.value = campo.value + separador;
        }
    }
}