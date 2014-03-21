SinonMockTest = TestCase('SinonMockTest');

SinonMockTest.prototype.setUp = function () {
	this._sandbox = sinon.sandbox.create();
};

SinonMockTest.prototype.tearDown = function () {
	this._sandbox.restore();
};

SinonMockTest.prototype.testThatMyMethodGetCalledOnce = function () {
	var theSinonMock = this._sandbox.mock(sinonMock);
	theSinonMock.expects("myMethod").once();
	sinonMock.myMethod();
	theSinonMock.verify();
};

SinonMockTest.prototype.testThatMyMethodGetCalledTwice = function () {
	var theSinonMock = this._sandbox.mock(sinonMock);
	theSinonMock.expects("myMethod").twice();
	sinonMock.callMyMethod(2);
	theSinonMock.verify();
};

SinonMockTest.prototype.testThatMyMethodGetCalledThreeTimes = function () {
	var theSinonMock = this._sandbox.mock(sinonMock);
	theSinonMock.expects("myMethod").thrice();
	sinonMock.callMyMethod(3);
	theSinonMock.verify();
};

SinonMockTest.prototype.testThatMyMethodGetCalledExactlySevenTimes = function () {
	var theSinonMock = this._sandbox.mock(sinonMock);
	theSinonMock.expects("myMethod").exactly(7);
	sinonMock.callMyMethod(7);
	theSinonMock.verify();
};

SinonMockTest.prototype.testThatMyMethodGetCalledAtLeastTwiceAndAtMostFourTimes = function () {
	var theSinonMock = this._sandbox.mock(sinonMock);
	theSinonMock.expects("myMethod").atLeast(2);
	theSinonMock.expects("myMethod").atMost(4);
	sinonMock.callMyMethod(4);
	theSinonMock.verify();
};

SinonMockTest.prototype.testThatMyMethodGetNeverCalled = function () {
	var theSinonMock = this._sandbox.mock(sinonMock);
	theSinonMock.expects("myMethod").never();
	sinonMock.callMyMethod(0);
	theSinonMock.verify();
};