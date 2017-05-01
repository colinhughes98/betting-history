$('documen')
    .ready(function () {

        $('#btnLogin')
            .click(function () {
                sessionStorage.removeItem('access_token');
                var username = $('#inputEmail3').val();
                var password = $('#inputPassword3').val();
                getToken(username, password);
            });

        $('#btnGoogleLogin')
            .click(function () {

                window.location
                    .href =
                    "http://localhost/BettingAPI/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=http%3A%2F%2Flocalhost%2FWebApplication2%2Fdefault%2Findex&state=oMWO-IfflfeIoZUgQz6b4uk68fEXSbeG4tFUBZwyY6s1";

                getAccessToken();

                //$.ajax({
                //    url: "http://localhost/BettingAPI/api/Account/ExternalLogin?provider=Google&response_type=token&client_id=self&redirect_uri=http%3A%2F%2Flocalhost%2FWebApplication2%2Fdefault%2Findex&state=oMWO-IfflfeIoZUgQz6b4uk68fEXSbeG4tFUBZwyY6s1",
                //    method: "GET",
                //    success: function() {
                //        alert('done');
                //    },
                //    error: function() {
                //        alert('error');
                //    }
                //});
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

