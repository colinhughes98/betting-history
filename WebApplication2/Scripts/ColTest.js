$('documen')
    .ready(function () {

        $('#btnLogin')
            .click(function () {
                sessionStorage.removeItem('access_token');
                var username = $('#inputEmail3').val();
                var password = $('#inputPassword3').val();
                getToken(username, password);
            });

        function getToken(username, password) {
            //get token
            $.ajax({
                url: "http://localhost/BettingAPI/token",
                method: "POST",
                contentType: "application/x-www-form-urlencoded",
                data: "username="+username+"&password="+password+"&grant_type=password",
                success: function (res) {
                    sessionStorage.setItem('access_token', res.access_token);
                },
                error: function () {
                    alert('Something went wrong');
                },
                complete: function () {
                    var token = sessionStorage.getItem('access_token');
                    if (token != null) {
                        logIn(token);
                    }
                }
            });
        }

        function logIn(token) {
           
                $.ajax({
                    url: "http://localhost/BettingAPI/api/v1/bet",
                    method: "GET",
                    headers: {
                        'Authorization':"Bearer "+token
                    },
                    success : function(res) {
                        $('#lbl1').html(res.Bets.FirstName);
                    },
                    error: function(err) {
                        alert('failed');
                    }
                });           
        };
    });

