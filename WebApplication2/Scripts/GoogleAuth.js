/// <reference path="jquery-3.1.1.min.js" />

function getAccessToken() {
    if (location.hash) {
        if (location.hash.split('access_token=')) {
            var accessToken = location.hash.split('access_token=')[1].split('&')[0];

            if (accessToken) {
                isUserRegistered(accessToken);
                
            }
        }
    }
}

function isUserRegistered(accessToken){
    $.ajax({
        url: "http://localhost/BettingAPI/api/Account/UserInfo",
        method: "GET",
        headers: {'Authorization' :'Bearer '+accessToken},
        success: function(data) {
            alert(data.Email);
        },
        error: function() {
            alert('error');
        }
    });
}
    


