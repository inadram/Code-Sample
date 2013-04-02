//underscore.js
var numbers = [1, 3, 4];
//functional style
_.each(numbers, function (num) {
    alert('functional :' + num);
});

//object oriental style
_(numbers).each(function (num) {
    alert('oo :' + num);
});

var doubled = _(numbers).map(function (num) {
    return num * 2;
});

_(doubled).each(function (num) { alert('mapped to double : ' + num); });

var reduced = _(doubled).reduce(function (single, num) { return single += num; }, 0);
alert("reduced to single value : " + reduced);

var filter = _(numbers).select(function (num) { return num % 2 === 0; });
alert("filter even numbers by select :" + filter[0]);

var AreAllItemsNumber = _(numbers).all(function (item) { return typeof item === "number"; });
alert("Are all the items in number type : " + AreAllItemsNumber);

var isIncludeItem = _(numbers).include(3);
alert("is include item :" + isIncludeItem);

var maxValue = _(numbers).max();
alert(maxValue);
