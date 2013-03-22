using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace HigherFunctions
{
    public static class HigherFunctionalMethod
    {
        
        public static IEnumerable<int> FindNumberType(IEnumerable<int> numbers, TypeOfNumber TypeofNumber)
        {
            switch (TypeofNumber)
            {
                case TypeOfNumber.odd:
                    return numbers.Find(IsOdd);
                case TypeOfNumber.even:
                    return numbers.Find(IsEven);
                case TypeOfNumber.prime:
                    return numbers.Find(IsPrime);
                    case TypeOfNumber.perfect:
                    return numbers.Find(IsPerfect);
                default:
                    throw new ArgumentOutOfRangeException("TypeofNumber");
            }
        }

        private static bool IsPerfect(int number)
        {
            int sum =0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }


        private static bool IsPrime(int number)
        {         
            bool isPrime = true;
            if (number == 1)
            {
                isPrime = false;
            }
            else
            {
                for (var i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            
            return isPrime;
        }
        private static bool IsOdd(int number)
        {
            bool isOdd = number%2 != 0;
            return isOdd;
        }


        private static bool IsEven(int number)
        {
            bool isEven = number % 2 == 0;
            return isEven;
        }

       
        private static IEnumerable<int> Find(this IEnumerable<int> list, Func<int, bool> NumberMatchFormat)
        {
            return list.Where(NumberMatchFormat).ToList();
        }

    
    }
    public enum TypeOfNumber
    {
        odd = 1,
        even = 2,
        prime = 3,
        perfect =4
    };
   
    [TestFixture]
    public class HigherFunctionalMethodTests
    {
        private int[] numbers;
       
        [SetUp]
        public void SetUp()
        {
            numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        [Test]
        public void Given_ListOfNumbers_When_FindEvenNumbers_Then_ShouldReturnEvenNumbersList()
        {
            IEnumerable<int> findNumberType = HigherFunctionalMethod.FindNumberType(numbers, TypeOfNumber.even);
            var ExpectedEvenNumbers = new[] { 2,4,6,8 };
            Assert.That(findNumberType, Is.EqualTo(ExpectedEvenNumbers));
        }

        [Test]
        public void Given_ListOfNumbers_When_FindOddNumbers_Then_ShouldReturnOddNumbersList()
        {
            IEnumerable<int> findNumberType = HigherFunctionalMethod.FindNumberType(numbers, TypeOfNumber.odd);
            var expectedOddNumbers = new[] {1, 3, 5, 7, 9};
            Assert.That(findNumberType,Is.EqualTo(expectedOddNumbers));
        }

        [Test]
        public void Given_ListOfNumbers_When_FindPrimeNumbers_Then_ShouldReturnPrimeNumbersList()
        {
            IEnumerable<int> findNumberType = HigherFunctionalMethod.FindNumberType(numbers, TypeOfNumber.prime);
            var expectedprimeNumbers = new[] { 2, 3, 5, 7 };
            Assert.That(findNumberType, Is.EqualTo(expectedprimeNumbers));
        }

        [Test]
        public void Given_ListOfNumbers_When_FindPerfectNumbers_Then_ShouldReturnPerfectNumbersList()
        {
            IEnumerable<int> findNumberType = HigherFunctionalMethod.FindNumberType(numbers, TypeOfNumber.perfect);
            var expectedperfectNumbers = new[] { 6 };
            Assert.That(findNumberType, Is.EqualTo(expectedperfectNumbers));
        }

    }
}
