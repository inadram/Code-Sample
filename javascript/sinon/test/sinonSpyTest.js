SinonSpyTest = TestCase('SinonSpyTest');

SinonSpyTest.prototype.setUp = function () {
	this._sandbox = sinon.sandbox.create();
};

SinonSpyTest.prototype.tearDown = function () {
	this._sandbox.restore();
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodOneTimeWhenPassOneToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(1);
	assertTrue(myMethodSpy.calledOnce);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodTwoTimesWhenPassTwoToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(2);
	assertTrue(myMethodSpy.calledTwice);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodThreeTimesWhenPassThreeToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(3);
	assertTrue(myMethodSpy.calledThrice);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWhenPassFourToIt = function () {
	expectAsserts(1);
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(4);
	assertEquals(4,myMethodSpy.callCount);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExpectedArgsWhenPassFourToIt = function () {
	expectAsserts(1);
	var arg1 ='arg number one';
	var arg2 ='arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(4,arg1,arg2);
	assertEquals(4,myMethodSpy.withArgs(arg1,arg2).callCount);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExpectedObjectArgsWhenPassFourToIt = function () {
	expectAsserts(1);
	var arg1 =['1','2','3'];
	var arg2 ={a:'a',b:'b'};
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(4,arg1,arg2);
	assertEquals(4,myMethodSpy.withArgs(arg1,arg2).callCount);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExpectedFirstArgWhenPassFourToIt = function () {
	expectAsserts(3);
	var arg1 ='arg number one';
	var arg2 ='arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(4,arg1,arg2);
	assertEquals(4,myMethodSpy.withArgs(arg1).callCount);
	assertTrue(myMethodSpy.calledWith(arg1));
	var indexOfNumberOfTimeItGetCalled =3;
	var indexOfArgThatPassesToTheMethod = 1
	assertEquals(arg2,myMethodSpy.args[indexOfNumberOfTimeItGetCalled][indexOfArgThatPassesToTheMethod]);
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesWithExactExpectedArgsWhenPassFourToIt = function () {
	expectAsserts(1);
	var arg1 ='arg number one';
	var arg2 ='arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(4,arg1,arg2);
	assertTrue(myMethodSpy.calledWithExactly(arg1,arg2));
};

SinonSpyTest.prototype.testCallMyMethodShouldCallMyMethodFourTimesAlwaysWithExactExpectedArgsWhenPassFourToIt = function () {
	expectAsserts(4);
	var arg1 ='arg number one';
	var arg2 ='arg number two';
	var myMethodSpy = this._sandbox.spy(sinonSpy,'myMethod');
	sinonSpy.callMyMethod(4,arg1,arg2);
	sinonSpy.callMyMethod(4,arg1);
	assertTrue(myMethodSpy.alwaysCalledWith(arg1));
	assertFalse(myMethodSpy.alwaysCalledWith(arg1,arg2));
	assertFalse(myMethodSpy.alwaysCalledWithExactly(arg1));
	assertFalse(myMethodSpy.alwaysCalledWithExactly(arg1,arg2));
};

