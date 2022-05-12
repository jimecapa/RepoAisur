function LoguearUsuario() {
    $.ajax({
        type: 'post',
        url: '/Home/LoginUsuario',
        data: { user: $('#txtUsuario').val(), password: $('#txtPassword').val() },
        dataType: 'json',
        success: function (data) {
            if (data[0]?.id) {
                window.location.href = '/Home/Index?login=' + true;
            }
        },
        error: function () {
            alert('Login Erroneo');

        }
    });
}


function CerrarUsuario() {
    $.ajax({
        type: 'post',
        url: '/Home/Logout',
        dataType: 'json',
        success: function (data) {
            alert(data);
            window.location.href = '/Home/Login';
        },
        error: function () {
            alert('Se cerro incorrectamente');

        }
    });
}