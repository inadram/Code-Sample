var sinonStub = {

	callMyMethod: function (number, arg1, arg2) {
		var someValue = '';
		for (var i = 0; i < number; i++) {
			someValue = this.myMethod(arg1, arg2);
		}
		return someValue;
	},

	myMethod: function (arg1, arg2) {
		return 'test'
	}
};