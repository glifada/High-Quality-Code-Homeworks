import 'jquery'
import data from 'js/data.js'
import templates from 'js/templates.js'
import cookiesController from 'js/controllers/cookiesController.js'
import usersController from 'js/controllers/usersController.js'

function getRandomCookie() {
    var cookies = db('cookies').value();
    var index = Math.floor(Math.random() * cookies.length);
    return cookies[index];
}

export default {
    all: function () {
        templates.load('myCookie')
            .then(function(templateHtml) {
                $('#main').html(templateHtml);
            });

        $('#main').on('click', '#btn-get', function (ev) {
            var myCookie;

            if (user.myCookies) {
                myCookie = _.last(user.myCookies);
                var now = new Date().getHours();
                var myCookieTime = myCookie.hours;
                if (myCookieTime !== now) {
                    myCookie = getRandomCookie();
                }
            } else {
                myCookie = getRandomCookie();
            }

            return myCookie;
        })
    }
}