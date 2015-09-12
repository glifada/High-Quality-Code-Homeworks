import 'jquery'
import data from 'js/data.js'
import validator from 'js/validator.js'
import notifier from 'js/notifier.js'
import templates from 'js/templates.js'

export default {
    register: function(username, password) {
        templates.load('register')
            .then(function(templateHtml) {
                $('#main').html(templateHtml);
            });

        $('#main').on('click', '#btn-register', function(ev) {
            var username = $('#inputEmail')[0].value,
                password = $('#inputPassword')[0].value;

            validator.lengthAndLatin(username, 6, 30)
                .then(function(){
                    return data.users.register(username, password)
                })
                .then(function(data) {
                    notifier.success('User registered');
                })
                .catch(function(err) {
                    notifier.error(err);
                });
        });
    },
    login: function(username, password) {
        templates.load('login')
            .then(function(templateHtml) {
                $('#main').html(templateHtml);
            });

        $('#main').on('click', '#btn-login', function(ev) {
            var username = $('#inputEmail')[0].value,
                password = $('#inputPassword')[0].value;

            data.users.login(username, password)
                .then(function(data) {
                    notifier.success('User logged in');
                    window.location = window.location.origin;
                })
                .catch(function(err) {
                    notifier.error(err);
                });
        });
    },
    logout: function(username, password) {
        data.users.logout()
            .then(function(data) {
                notifier.success('Logged out');
                window.location = window.location.origin;
            })
            .catch(function(err) {
                notifier.error(err);
            });
    },
    like: function () {
        data.users.like()
            .then(function (data) {
                notifier.success('You liked this fortune cookie!');
            })
            .catch(function (err) {
                notifier.error(err);
            })
    },
    dislike: function () {
        data.users.dislike()
            .then(function (data) {
                notifier.success('You disliked this fortune cookie!');
            })
            .catch(function (err) {
                notifier.error(err);
            })
    },
    share: function () {
        data.users.share()
            .then(function (data) {
                notifier.success('You successfully shared this fortune cookie!');
            })
            .catch(function (err) {
                notifier.error(err);
            })
    }
}