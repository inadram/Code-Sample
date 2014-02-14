var sinonSpy = {

	callMyMethod: function (number,arg1,args2) {
		for (var i = 0; i < number; i++) {
			this.myMethod(arg1,args2);
		}
	},

	myMethod: function (arg1,arg2) {
		//do something
	}
};
