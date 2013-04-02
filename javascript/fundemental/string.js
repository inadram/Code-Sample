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

//isNaN
alert("is string not a number ? :" + isNaN("test"));

alert("is number not a number ? :" + isNaN(1));