import 'jquery'
import usersController from 'js/controllers/usersController.js'
import cookiesController from 'js/controllers/cookiesController.js'
import notifier from 'js/notifier.js'

function getPassHash(password) {
    return sha1(password);
}

function getAuthKey(username, password) {
    return sha1(username + password);
}

export default {
    users: {
        register: function (username, password) {
            var passHash = getPassHash(password);
            return $.ajax({
                url: '/users',
                type: 'post',
                data: {
                    username: username,
                    passHash: passHash
                }
            })
        },
        login: function (username, password) {
            var passHash = getPassHash(password);
            return $.ajax({
                url: '/auth',
                type: 'put',
                data: {
                    username: username,
                    passHash: passHash
                }
            })
        },
        logout: function () {
            return $.ajax({
                url: '/user',
                type: 'put'
            })
        },
        get: function () {
            return $.ajax({
                url: '/users',
                type: 'get'
            })
            .then(function () {
               return data.users;
            });
        }
    },
    cookies: {
        all: function() {
            return $.ajax({
                url: '/cookies',
                type: 'get'
            });
        },
        share: function() {
            return $.ajax({
                url: '/cookies',
                type: 'post',
                body: { likes, shareDate, img },
                headers: {
                    'x-auth-key': getAuthKey()
                }
            })
        }
    },
    myCookie: {
        get: function () {
            return $.ajax({
                url: '/my-cookie',
                type: 'get'
            })
        }
    },
    categories: {
        all: function (name) {
            return $.ajax({
                url: '/categories',
                type: 'get'
            })
        }
    }
}