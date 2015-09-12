import 'sammy'
import 'jquery'
import categoriesController from 'js/controllers/categoriesController.js'
import cookiesController from 'js/controllers/cookiesController.js'
import myCookieController from 'js/controllers/myCookiesController.js'
import usersController from 'js/controllers/usersController.js'

var containerId = '#main';
var sammyApp = new Sammy(containerId, function () {
    this.get('#/', function() {
        this.redirect('#/cookies');
    });

        this.get('#/register', usersController.register);
        this.get('#/login', usersController.login);
        this.get('#/logout', usersController.logout);
        this.get('#/cookies', cookiesController.all);
        this.get('#/my-cookie', myCookieController.all);
        this.get('#/categories', categoriesController.all);
});

sammyApp.run('#/home');
