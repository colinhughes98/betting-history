$('document')
    .ready(function() {
        $('#btnLogin')
            .click(function() {

                //get token
                $.ajax({
                    url: "http://localhost/BettingAPI/token",
                    method: "POST",
                    contentType: "application/x-www-form-urlencoded",
                    data: "username=colinhughes98@gmail.com&password=P@scal12&grant_type=password",
                    success: function(res) {
                        alert(res.access_token);
                        sessionStorage.setItem('access_token', res.access_token);


                    },
                    failure: function() {
                        alert('Something went wrong');
                    }
                });


                //$.ajax({
                //    url: "http://localhost/BettingAPI/api/v1/bet",
                //    method: "GET",
                //    succes : function(res) {
                //        alert(res);
                //    }
                //});                
            });
    });

