var sinonSpy = {

	callMyMethod: function (number, arg1, args2) {
		for (var i = 0; i < number; i++) {
			this.myMethod(arg1, args2);
		}
		this.firstMethod();
		this.secondMethod();
		this.doSomething();
	},

	myMethod: function (arg1, arg2) {
		//do something
	},

	firstMethod: function () {
		//do something
	},

	secondMethod: function () {
		//do something
	},

	doSomething: function () {
		//do something
	},

	TryCatchMethod: function (message) {
		try {
			this.exceptionMethod(message);
		} catch (err) {
		}
	},

	exceptionMethod: function (message) {
		throw  message;
	},

	returnMethod: function(someValue){
		return someValue;
	},

	print: function(arg1,arg2,arg3){
		//do something
	}

};



