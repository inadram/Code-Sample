var sinonMock = {

	callMyMethod: function (number) {
		for (var i = 0; i < number; i++) {
			this.myMethod();
		}
	},

	myMethod: function () {
		//do something
	}
};



