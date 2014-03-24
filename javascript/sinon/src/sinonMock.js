var sinonMock = {

	callMyMethod: function (number, firstArgument, secondArgument) {
		for (var i = 0; i < number; i++) {
			this.myMethod(firstArgument, secondArgument);
		}
	},

	myMethod: function () {
		//do something
	}
};



