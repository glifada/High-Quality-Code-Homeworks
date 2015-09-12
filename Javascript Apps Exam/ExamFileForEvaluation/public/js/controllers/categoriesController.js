import 'jquery'
import data from 'js/data.js'
import templates from 'js/templates.js'
import validator from 'js/validator.js'

export default {
    all: function (name) {
        templates.load('categories')
            .then(function(templateHtml) {
                $('#main').html(templateHtml);
            });

        validator.length(name, 6, 30)
            .then(function () {
                return data.cookies.category;
            })
    }
}