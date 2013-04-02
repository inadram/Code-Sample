//regular expressions
var someText = "this is some <italic> important </italic> html text with some numbers such as 1, 3 and 6";
var expression = /<italic> (.*) <\/italic>/;
var result = expression.exec(someText);
alert("matched string : " + result[0]);
alert("capture string: " + result[1]);

var numberExpression = /\d/;
var isContainNuber = numberExpression.test(someText);
alert("is the string contain number : " + isContainNuber);

var spaceBetweenTwoWords = /(\w+) (\w+)/g;
var updatedString = someText.replace(spaceBetweenTwoWords, function (match, group1, group2) {
    return group1.toUpperCase();
});

alert("replace each word with uppercase :" + updatedString);
