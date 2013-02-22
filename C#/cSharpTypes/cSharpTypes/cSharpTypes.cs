using System;
using System.Text;
using NUnit.Framework;

namespace cSharpTypes
{
    public class cSharpTypes
    {
        public void ChangeValue(someDto dto)
        {
            dto.Number = dto.Number*2;
            dto.DecimalNumber = dto.DecimalNumber * 2;
            dto.DoubleNumber = dto.DoubleNumber * 2;
            dto.StringValue = dto.StringValue + dto.StringValue;
            dto.PropertyNumber = dto.PropertyNumber + dto.PropertyNumber;
            dto.PropertyString = dto.PropertyString + dto.PropertyString;
        }

        public void ChangeValue(someStruct _struct)
        {
            _struct.Number = _struct.Number * 2;
            _struct.DecimalNumber = _struct.DecimalNumber * 2;
            _struct.DoubleNumber = _struct.DoubleNumber * 2;
            _struct.StringValue = _struct.StringValue + _struct.StringValue;
        }


        public void ChangeValue(ref someStruct _struct)
        {
            _struct.Number = _struct.Number * 2;
            _struct.DecimalNumber = _struct.DecimalNumber * 2;
            _struct.DoubleNumber = _struct.DoubleNumber * 2;
            _struct.StringValue = _struct.StringValue + _struct.StringValue;
        }

        public void ChangeValueOut(out someStruct _struct)
        {
            _struct.Number = 0;
            _struct.DecimalNumber = 0m;
            _struct.DoubleNumber = 0;
            _struct.StringValue = string.Empty;
        }

        public void ChangeValueOfStringBuilder(StringBuilder stringBuilder)
        {
            stringBuilder.Append("Test 2");
        }
        public void ChangeValueOfString(string str)
        {
            str.Remove(0, 1);
        }

    }

    public class someDto
    {
        public int Number;
        public decimal DecimalNumber;
        public double DoubleNumber;
        public string StringValue;

        public int PropertyNumber { get; set; }
        public string PropertyString { get; set; }
    }

    public struct someStruct
    {
        public int Number;
        public decimal DecimalNumber;
        public double DoubleNumber;
        public string StringValue;
      
    }

    [TestFixture]
    public class TestCSharpTypes
    {
        private int myNumber;
        private decimal myDecimalNumber;
        private double myDoubleNumber;
        private string myStringValue;
        private int myPropertyNumber;
        private string myPropertystring;
        private someStruct someStruct;
        private someDto myDto;

      
        private void InitialiseStruct()
        {
            myNumber = 10;
            myDecimalNumber = 10.20m;
            myDoubleNumber = 10.10;
            myStringValue = "Test String";
            myPropertyNumber = 20;
            myPropertystring = "Test property string";
            someStruct = new someStruct();

            someStruct.Number = myNumber;
            someStruct.DecimalNumber = myDecimalNumber;
            someStruct.DoubleNumber = myDoubleNumber;
            someStruct.StringValue = myStringValue;
           
        }

        private void InitialiseDto()
        {
            myNumber = 10;
            myDecimalNumber = 10.20m;
            myDoubleNumber = 10.10;
            myStringValue = "Test String";
            myPropertyNumber = 20;
            myPropertystring = "Test property string";
            myDto = new someDto();

            myDto.Number = myNumber;
            myDto.DecimalNumber = myDecimalNumber;
            myDto.DoubleNumber = myDoubleNumber;
            myDto.StringValue = myStringValue;
            myDto.PropertyNumber = myPropertyNumber;
            myDto.PropertyString = myPropertystring;
        }

        [Test]
        public void Given_dto_when_ChangeValue_Then_ValueShouldBeChange()
        {
            var cSharpTypes = new cSharpTypes();
            InitialiseDto();
            cSharpTypes.ChangeValue(myDto);

            Assert.That(myDto.DecimalNumber,Is.Not.EqualTo(myDecimalNumber));
            Assert.That(myDto.DoubleNumber,Is.Not.EqualTo(myDoubleNumber));
            Assert.That(myDto.Number,Is.Not.EqualTo(myNumber));
            Assert.That(myDto.PropertyNumber,Is.Not.EqualTo(myPropertyNumber));
            Assert.That(myDto.PropertyString,Is.Not.EqualTo(myPropertystring));
            Assert.That(myDto.StringValue,Is.Not.EqualTo(myStringValue));

        }

        [Test]
        public void Given_struct_when_ChangeValue_Then_ValueShouldNotBeChange()
        {
            var cSharpTypes = new cSharpTypes();
            InitialiseStruct();
            cSharpTypes.ChangeValue(someStruct);

            Assert.That(someStruct.DecimalNumber, Is.EqualTo(myDecimalNumber));
            Assert.That(someStruct.DoubleNumber, Is.EqualTo(myDoubleNumber));
            Assert.That(someStruct.Number, Is.EqualTo(myNumber));
            Assert.That(someStruct.StringValue, Is.EqualTo(myStringValue));

        }


        [Test]
        public void Given_Refstruct_when_ChangeValue_Then_ValueShouldNotBeChange()
        {
            var cSharpTypes = new cSharpTypes();
            InitialiseStruct();
            cSharpTypes.ChangeValue(ref someStruct);

            Assert.That(someStruct.DecimalNumber, Is.Not.EqualTo(myDecimalNumber));
            Assert.That(someStruct.DoubleNumber, Is.Not.EqualTo(myDoubleNumber));
            Assert.That(someStruct.Number, Is.Not.EqualTo(myNumber));
            Assert.That(someStruct.StringValue, Is.Not.EqualTo(myStringValue));

        }

        [Test]
        public void Given_Outstruct_when_ChangeValueOut_Then_ValueShouldBeChange()
        {
            var cSharpTypes = new cSharpTypes();
            cSharpTypes.ChangeValueOut(out someStruct);

            Assert.That(someStruct.DecimalNumber, Is.Not.EqualTo(myDecimalNumber));
            Assert.That(someStruct.DoubleNumber, Is.Not.EqualTo(myDoubleNumber));
            Assert.That(someStruct.Number, Is.Not.EqualTo(myNumber));
            Assert.That(someStruct.StringValue, Is.Not.EqualTo(myStringValue));

        }

        [Test]
        public void Given_StringBuilder_when_ChangeValueOfStringBuilder_Then_ValueShouldBeChange()
        {
            var stringBuilder=new StringBuilder();
            stringBuilder.Append(myStringValue);

            var cSharpTypes=new cSharpTypes();
            cSharpTypes.ChangeValueOfStringBuilder(stringBuilder);
            Assert.That(myStringValue, Is.Not.EqualTo(stringBuilder));
        }

        [Test]
        public void Given_StringBuilder_when_NullifyStringBuilder_Then_ValueShouldBeChange()
        {
            char[] strAlphabet={'A','B','C'};
            string str = new string(strAlphabet);
            string strpassing = str;
            var cSharpTypes = new cSharpTypes();
            cSharpTypes.ChangeValueOfString(strpassing);
            Assert.That(strpassing, Is.EqualTo(str));
        }
    }
}
