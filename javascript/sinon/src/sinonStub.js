var sinonStub = {

	callMyMethod: function (number, arg1, arg2) {
		var someValue = '';
		for (var i = 0; i < number; i++) {
			someValue = this.myMethod(arg1, arg2);
		}
		return someValue;
	},

	myMethod: function (arg1, arg2) {
		try {
			this.exceptionMethod();
		}
		catch (exception) {
		}
		return 'test'
	},

	myMethodWithCallBack: function () {
		var status;
		this.methodWithCallBack({
			onSuccess: function (arg1, arg2) {
				status = 'success' + arg1 + arg2;
			},
			onError: function () {
				status = 'failure'
			}
		});
		return status;
	},

	methodWithCallBack: function (callback) {
		return true;
	},
	exceptionMethod: function () {
		return 'some value';
	}
};

