function add(first, second) {
    sum = first + second;
    return sum;
}
var someVar = add(10, 5);
alert(typeof someVar + ' ' + someVar);

someVar = add("Test", "it");
alert(typeof someVar + ' ' + someVar);

//global variable

alert(typeof sum + ' ' + sum);
if (window.sum) {
    alert("sum is global variable");
}

//variable are accessible outside the block
if (true) {
    var someVariable = "test";
}
alert(someVariable);

// null and undefined
var someNull = null;
if (!someNull) {
    alert("null default value is false");
}

var someUnDefined;
if (!someUnDefined) {
    alert(someUnDefined);
    alert("UnDefined default value is false");
}


//objects
var emptyObject = {};
alert(typeof emptyObject + emptyObject.toString());

var amir = {};
amir.name = "Amir";
alert(amir.name);

var amir =
    {
        fullname:
        {
            firstName: "amir",
            LastName: "mardani"
        },
        name: "my name is amir",
        age: 26
    };

alert(amir.name);
alert(amir.age);
alert(amir.fullname.LastName);

amir.giveFullDetail = function () {
    return this.name + " and my age is " + this.age;
};
alert(amir.giveFullDetail());


// object are refrence type
var amir = { name: "amir" };

function changeName(obj, newName) {
    obj.name = newName;
}
alert(amir.name);
changeName(amir, "Amir");
alert(amir.name);

//equality

alert("0==''" + (0 == ''));
alert("0===''" + (0 === ''));

//functions naming function show themself in call stack
var MultipleByName = function (x, y) {
    return x * y;
};

function Multiple(x, y, z) {
    return x * y * z;
}

function Multiple(x, y) {
    return x * y;
}


alert(Multiple(12, 5));
alert(Multiple(12, 5, 10));

alert(MultipleByName(10, 5));

(function (x, y) {
    alert(x * y);
})(10, 10);


//input arguments are array
function NameLength(newName) {
    var total = '';
    for (i = 0; i < arguments.length; i++) {
        total += arguments[i];
    }
    return total;
}
alert(NameLength("amir"));
alert(NameLength("amir", "John"));

//recursion
function factorial(number) {
    if (number === 1 || number === 0) {
        return 1;
    }
    return number * factorial(number - 1);
}


alert(factorial(5));

//closure
var OuterFuncVar = "outer function var";
function outer() {

    var OuterVar = "outer var";
    function inner() {
        alert(OuterVar + ' ' + OuterFuncVar);
    }
    inner();
}
outer();


//iteration... for in
var amir =
    {
        name: "amir",
        age: 26
    };

(function (obj) {
    for (var arg in obj) {
        alert(arg + ' : ' + obj[arg]);
    }
})(amir);

//Error handling 
(function () {
    try {
        throw {
            name: "errorex",
            message: "some exception occured"
        };
    }
    catch (e) {
        alert(e.name + " : " + e.message);
    }
    finally {
        alert("finally always happen !");
    }
})();

//string functionality
var name = "amir";
alert("charAt(0): " + name.charAt(0));

alert("indexOf('m'):" + name.indexOf('m'));

name = name.replace("a", "m");
alert("replace('a','m'): " + name.charAt(0));

alert("slice(0,3) :" + name.slice(0, 3));

alert("search(/m/) : " + name.search(/m/));
alert("split('m') :" + name.split('m'));

alert("toUpperCase :" + name.toUpperCase());

//array can store anything
var collection = [1, "test", 3, 11];
alert("integer value  in collection :" + collection[0]);
alert("string value in collection : " + collection[1]);
collection.push('test2');
alert("push : " + collection[4]);
collection.pop();
alert("pop to remove: " + collection[4]);

collection.reverse();
alert("reverse :" + collection[0]);

collection.sort();
alert("sort collection[0] :" + collection[0]);
alert("sort collection[1] :" + collection[1]);

collection.sort(function (first, second) { return first - second; });
alert("sort numerical collection[0] :" + collection[0]);
alert("sort numerical collection[1] :" + collection[1]);

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

//date 1 month diffrent as it start from 0 11 => december
var mydate = new Date(2010, 11, 21);
alert(mydate);
alert(mydate.toUTCString());
//do not use eval

//isNaN
alert("is string not a number ? :" + isNaN("test"));

alert("is number not a number ? :" + isNaN(1));

//parseFloat
alert("convert 41 to number :" + parseFloat("41"));

alert("convert 0.0654E+2 to nuber :" + parseFloat("0.0654E+2"));

//math
function circle(diameter) {
    return diameter * Math.PI;
}

alert(circle(2).toFixed(2));
alert("abs -4 :" + Math.abs(-4));

alert("floor 1.2 :" + Math.floor(1.2));
alert("floor -1.2 :" + Math.floor(-1.2));

alert("ceil 1.2 :" + Math.ceil(1.2));
alert("ceil -1.2 :" + Math.ceil(-1.2));

alert("pow (3,2) :" + Math.pow(3, 2));

alert("random () :" + Math.random());

alert("round (2.4) :" + Math.round(2.4));
alert("round (2.5) :" + Math.round(2.5));
alert("round (-2.4) :" + Math.round(-2.4));