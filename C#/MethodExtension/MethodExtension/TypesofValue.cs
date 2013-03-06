using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace MethodExtension
{
    public class TypesofValue
    {
        public IEnumerable<string> GetAllNames()
        {
            IEnumerable<string> enumerable=new string[]{"Amir","Jim","John","Tom","Jack"};
            return enumerable;
        }

        public IEnumerable<int> GetAllNumbers()
        {
            IEnumerable<int> enumerable = new int[] { 1,2,3,4,5,6,7 };
            return enumerable;
        }

        public IEnumerable<string> GetNamesWithJ()
        {
            IEnumerable<string> allNames = GetAllNames();
            IEnumerable<string> startWithJ = Extentions.StartWithJ(allNames);
            return startWithJ;
        }

        public IEnumerable<string> GetNamesStartWithJByEnumerable()
        {
            IEnumerable<string> allNames = GetAllNames();
            IEnumerable<string> startWithJ = allNames.EmbededStartWithJ();
            return startWithJ;
        }

        public IEnumerable<string> GetNamesStartWithByEnumerable(string character)
        {
            IEnumerable<string> allNames = GetAllNames();
            IEnumerable<string> embededStartWith = allNames.EmbededStartWith(character);
            return embededStartWith;
        }

        public IEnumerable<int> GetEvenNumber()
        {
            IEnumerable<int> allNumbers = GetAllNumbers();
            IEnumerable<int> embededFilter = allNumbers.EmbededFilter(IsEvenNumber);
            return embededFilter;
        }

        public IEnumerable<int> GetEvenNumberWithAnynomousMethod()
        {
            IEnumerable<int> allNumbers = GetAllNumbers();
            IEnumerable<int> embededFilter = allNumbers.EmbededFilter(delegate(int item) { return item%2 == 0; });
            return embededFilter;
        }

        public IEnumerable<int> GetEvenNumberWithLamda()
        {
            IEnumerable<int> allNumbers = GetAllNumbers();
            IEnumerable<int> embededFilter = allNumbers.EmbededlambdaFilter(item => item % 2 == 0);
            return embededFilter;
        }

        public bool IsEvenNumber(int input)
        {
            return input%2==0;
        }
    }

    public static class Extentions
    {
        public static IEnumerable<string> StartWithJ(IEnumerable<string> NamesCollection)
        {
            foreach (var name in NamesCollection)
            {
                if (name.StartsWith("J"))
                {
                    yield return name;
                }    
            }
            
        }
        public static IEnumerable<string> EmbededStartWithJ(this IEnumerable<string> NamesCollection)
        {
            foreach (var name in NamesCollection)
            {
                if (name.StartsWith("J"))
                {
                    yield return name;
                }
            }

        }
        public static IEnumerable<string> EmbededStartWith(this IEnumerable<string> NamesCollection,string character )
        {
           foreach(var Name in NamesCollection)
           {
               if(Name.StartsWith(character))
               {
                   yield return Name;
               }
           }
        }

        public static IEnumerable<T> EmbededFilter<T>(this IEnumerable<T> Collection, Filter<T> filter )
        {
            foreach (var item in Collection)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }
        public delegate bool Filter<T>(T item);
        public static IEnumerable<T> EmbededlambdaFilter<T>(this IEnumerable<T> Collection, Func<T,bool> filter)
        {
            foreach (var item in Collection)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }

      
    }

    [TestFixture]
    public class TestSomeFunctionality
    {
        [Test]
        public void When_GetNamesStartWithJCalled_Then_ShouldReturnAllNamesStartWithJ()
        {
            var names=new TypesofValue();
            IEnumerable<string> NamesCollection = names.GetNamesWithJ();
            Assert.IsTrue(NamesCollection.Contains("John"));
            Assert.IsTrue(NamesCollection.Count()==3);
        }

        [Test]
        public void When_GetAllNamesCalled_Then_ShouldReturnAllNames()
        {
            var names = new TypesofValue();
            IEnumerable<string> NamesCollection = names.GetAllNames();
            Assert.IsTrue(NamesCollection.Contains("Amir"));
            Assert.IsTrue(NamesCollection.Count() == 5);
        }

        [Test]
        public void When_EmbededStartWithJInEnumerableCalled_Then_ShouldReturnAllNamesStartWithJ()
        {
            var names = new TypesofValue();
            IEnumerable<string> NamesCollection = names.GetNamesStartWithJByEnumerable();
            Assert.IsTrue(NamesCollection.Contains("Jim"));
            Assert.IsTrue(NamesCollection.Count() == 3);
        }

        [Test]
        public void Given_charecter_When_EmbededStartWithInEnumerableCalled_Then_ShouldReturnAllNamesStartWithJ()
        {
            var names = new TypesofValue();
            IEnumerable<string> NamesCollection = names.GetNamesStartWithByEnumerable("A");
            Assert.IsTrue(NamesCollection.Contains("Amir"));
            Assert.IsTrue(NamesCollection.Count() == 1);
        }

        [Test]
        public void When_GetEvenNumbers_Then_ShouldReturnAllNumbers()
        {
            var types = new TypesofValue();
            IEnumerable<int> NumberCollection = types.GetEvenNumber();
            Assert.IsTrue(NumberCollection.Contains(2));
            Assert.IsTrue(NumberCollection.Count() == 3);
        }

        [Test]
        public void When_GetEvenNumberWithAnynomousMethod_Then_ShouldReturnAllNumbers()
        {
            var types = new TypesofValue();
            IEnumerable<int> NumberCollection = types.GetEvenNumberWithAnynomousMethod();
            Assert.IsTrue(NumberCollection.Contains(2));
            Assert.IsTrue(NumberCollection.Count() == 3);
        }

        [Test]
        public void When_GetEvenNumberWithLamda_Then_ShouldReturnAllNumbers()
        {
            var types = new TypesofValue();
            IEnumerable<int> NumberCollection = types.GetEvenNumberWithLamda();
            Assert.IsTrue(NumberCollection.Contains(2));
            Assert.IsTrue(NumberCollection.Count() == 3);
        }

    }
}
