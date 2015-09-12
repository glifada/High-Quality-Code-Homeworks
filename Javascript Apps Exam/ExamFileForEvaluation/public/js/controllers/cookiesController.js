import 'jquery'
import data from 'js/data.js'
import validator from 'js/validator.js'
import notifier from 'js/notifier.js'
import templates from 'js/templates.js'

export default {
    all: function(sammy) {
        var likes = +sammy.params['likes'],
            dislikes = +sammy.params['dislikes'];

        templates.load('cookies')
            .then(function (templateHtml) {
                $('#main').html(templateHtml());
            });

        //$('#main').on('click', '#btn-filter', function(ev) {
        //    var size = $('#dd-page-size option:selected').text(),
        //        page = 0;
        //    sammy.redirect('#/posts/' + size + '/' + page);
        //});

        $('#main').on('click', '#btn-share', function(ev) {
            data.cookies.share()
                .then(function(data) {
                    notifier.success(data);
                    sammy.redirect('#/');
                }, function(err) {
                    sammy.redirect('#/cookies');
                });
        });

        $('#main').on('click', '#btn-like', function(ev) {
            return data.cookies.likes += 1;
        });

        $('#main').on('click', '#btn-dislike', function(ev) {
            return data.cookies.likes -= 1;
        })
    }
}