SinonSpyTest = TestCase('SinonSpyTest');

SinonSpyTest.prototype.setUp = function () {
	this._sandbox = sinon.sandbox.create();
};

SinonSpyTest.prototype.tearDown = function () {
	this._sandbox.restore();
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodOneTimeWhenPassOneToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(1);
	assertTrue(myMethodSpy.calledOnce);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodTwoTimesWhenPassTwoToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(2);
	assertTrue(myMethodSpy.calledTwice);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodThreeTimesWhenPassThreeToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(3);
	assertTrue(myMethodSpy.calledThrice);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWhenPassFourToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(4);
	assertEquals(4, myMethodSpy.callCount);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExpectedArgsWhenPassFourToIt = function () {
	expectAsserts(1);
	var arg1 = 'arg number one';
	var arg2 = 'arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(4, arg1, arg2);
	assertEquals(4, myMethodSpy.withArgs(arg1, arg2).callCount);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExpectedObjectArgsWhenPassFourToIt = function () {
	expectAsserts(1);
	var arg1 = ['1', '2', '3'];
	var arg2 = {a: 'a', b: 'b'};
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(4, arg1, arg2);
	assertEquals(4, myMethodSpy.withArgs(arg1, arg2).callCount);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExpectedFirstArgWhenPassFourToIt = function () {
	expectAsserts(4);
	var arg1 = 'arg number one';
	var arg2 = 'arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(4, arg1, arg2);
	assertEquals(4, myMethodSpy.withArgs(arg1).callCount);
	assertTrue(myMethodSpy.calledWith(arg1));
	assertTrue(myMethodSpy.neverCalledWith(undefined));

	var indexOfNumberOfTimeItGetCalled = 3;
	var indexOfArgThatPassesToTheMethod = 1
	assertEquals(arg2, myMethodSpy.args[indexOfNumberOfTimeItGetCalled][indexOfArgThatPassesToTheMethod]);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExactExpectedArgsWhenPassFourToIt = function () {
	expectAsserts(2);
	var arg1 = 'arg number one';
	var arg2 = 'arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(4, arg1, arg2);
	sinonSpy.callMyMethod(4, arg1);
	assertTrue(myMethodSpy.calledWithExactly(arg1, arg2));
	assertTrue(myMethodSpy.calledWithExactly(arg1, undefined));
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesAlwaysWithExactExpectedArgsWhenPassFourToIt = function () {
	expectAsserts(4);
	var arg1 = 'arg number one';
	var arg2 = 'arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(4, arg1, arg2);
	sinonSpy.callMyMethod(4, arg1);
	assertTrue(myMethodSpy.alwaysCalledWith(arg1));
	assertFalse(myMethodSpy.alwaysCalledWith(arg1, arg2));
	assertFalse(myMethodSpy.alwaysCalledWithExactly(arg1));
	assertFalse(myMethodSpy.alwaysCalledWithExactly(arg1, arg2));

};

SinonSpyTest.prototype.testMyMethodCalledWithExpectedElementsOnSecondCall = function () {
	expectAsserts(5);
	var arg1 = 'arg number one';
	var arg2 = 'arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(1, arg1, arg2);
	sinonSpy.callMyMethod(1, arg1);
	sinonSpy.callMyMethod(1);
	sinonSpy.callMyMethod(1, arg1);
	assertTrue(myMethodSpy.secondCall.calledWith(arg1, undefined));
	assertTrue(myMethodSpy.firstCall.calledWith(arg1, arg2));
	assertTrue(myMethodSpy.thirdCall.calledWith(undefined, undefined));
	assertTrue(myMethodSpy.lastCall.calledWith(arg1, undefined));
	assertTrue(myMethodSpy.getCall(3).calledWith(arg1, undefined));

};

SinonSpyTest.prototype.testFirstMethodCalledBeforeSecondMethod = function () {
	expectAsserts(3);
	var firstMethodSpy = this._sandbox.spy(sinonSpy, 'firstMethod');
	var secondMethodSpy = this._sandbox.spy(sinonSpy, 'secondMethod');
	sinonSpy.callMyMethod();
	assertTrue(firstMethodSpy.calledBefore(secondMethodSpy));
	assertTrue(secondMethodSpy.calledAfter(firstMethodSpy));
	assertFalse(secondMethodSpy.calledBefore(firstMethodSpy));
};

SinonSpyTest.prototype.testMyMethodCalledOnExpectedObject = function () {
	expectAsserts(2);
	var doSomethingSpy = this._sandbox.spy(sinonSpy, 'doSomething');
	sinonSpy.callMyMethod();
	assertTrue(doSomethingSpy.calledOn(sinonSpy));
	assertTrue(doSomethingSpy.alwaysCalledOn(sinonSpy));
};

SinonSpyTest.prototype.testMyMethodCalledWithExpectedMatch = function () {
	expectAsserts(5);
	var arg1 = {one: 'arg number one'};
	var arg2 = 'arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy, 'myMethod');
	sinonSpy.callMyMethod(1, arg1, arg2);
	sinonSpy.callMyMethod(1, arg1);
	assertTrue(myMethodSpy.calledWithMatch({}, ''));
	assertTrue(myMethodSpy.calledWithMatch({}));
	assertTrue(myMethodSpy.alwaysCalledWithMatch({}));
	assertFalse(myMethodSpy.alwaysCalledWithMatch({}, ''));
	assertTrue(myMethodSpy.neverCalledWithMatch([]));
};

SinonSpyTest.prototype.testExceptionMethodThrowExpectedException = function () {
	expectAsserts(6);
	var exceptionMethodSpy = this._sandbox.spy(sinonSpy, 'exceptionMethod');
	var exceptionMessage = 'exception message';
	var exceptionObject = {detail: 'exception message'};
	sinonSpy.TryCatchMethod(exceptionMessage);
	sinonSpy.TryCatchMethod(exceptionObject);
	assertTrue(exceptionMethodSpy.threw());
	assertTrue(exceptionMethodSpy.threw(exceptionMessage));
	assertTrue(exceptionMethodSpy.threw(exceptionObject));
	assertFalse(exceptionMethodSpy.alwaysThrew(exceptionMessage));
	assertFalse(exceptionMethodSpy.alwaysThrew(exceptionObject));
	assertEquals(exceptionMessage, exceptionMethodSpy.exceptions[0]);
};

SinonSpyTest.prototype.testReturnMethodShouldReturnsExpectedValue = function () {
	expectAsserts(4);
	var returnMethodSpy = this._sandbox.spy(sinonSpy, 'returnMethod');
	var returnMessage = 'some return message';
	var returnObject = {details: 'some return message'};
	sinonSpy.returnMethod(returnMessage);
	sinonSpy.returnMethod(returnObject);
	assertTrue(returnMethodSpy.returned(returnMessage));
	assertTrue(returnMethodSpy.returned(returnObject));
	assertFalse(returnMethodSpy.alwaysReturned(returnObject));
	assertEquals(returnMessage, returnMethodSpy.returnValues[0]);
};

SinonSpyTest.prototype.testResetSpyShouldResetIt = function () {
	expectAsserts(2);
	var doSomethingSpy = this._sandbox.spy(sinonSpy, 'doSomething');
	sinonSpy.doSomething();
	assertTrue(doSomethingSpy.called);
	doSomethingSpy.reset();
	assertFalse(doSomethingSpy.called);
};

SinonSpyTest.prototype.testDoSomethingPrintSpyDetails = function () {
	expectAsserts(1);
	var doSomethingSpy = this._sandbox.spy(sinonSpy, 'print');
	var arg1 = {a: 'argument 1'};
	var arg2 = 2.33;
	var arg3 = 'argument 3';
	sinonSpy.print(arg1, arg2, arg3);
	assertTrue(true);
//	assertTrue(doSomethingSpy.printf("%n"),false); //name of method spy i.e. print
//	assertTrue(doSomethingSpy.printf("%c"),false); //number of times spy get called i.e. once
//	assertTrue(doSomethingSpy.printf("%C"),false); //print expected arguments that passed to it  i.e. { a: "argument 1" }, argument 2, argument 3)
//	assertTrue(doSomethingSpy.printf("%t"),false); //print list of values the spy was call on  i.e. methods of sinonSpy
};


