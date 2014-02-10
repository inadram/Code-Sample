SinonTest = TestCase('SinonTest');

SinonTest.prototype.setUp = function () {
	this._sandbox = sinon.sandbox.create();
};

SinonTest.prototype.tearDown = function () {
	this._sandbox.restore();
};

SinonTest.prototype.testRun = function () {
	expectAsserts(1);

	assertTrue(true);
};