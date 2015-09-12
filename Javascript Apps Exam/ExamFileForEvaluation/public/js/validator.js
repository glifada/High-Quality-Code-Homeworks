export default {
    length: function (text, min, max){
        return new Promise(function(resolve, reject) {
            if (text.length >= min && text.length <= max) {
                resolve('OK');
            } else {
                reject('Text too long');
            }
        });
    },
    lengthAndLatin: function (text) {
        return new Promise(function (resolve, reject) {
            if (text.matches("^[a-zA-Z._]") &&
                text.length >= min && text.length <= max) {
                resolve('OK');
            } else {
                reject('Username is invalid!');
            }
        });
    }
}