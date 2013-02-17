using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace IoC
{
    public class Resolver
    {
        Dictionary<Type, Type> dictionaryType = new Dictionary<Type, Type>();

        public ITypeOfPrinter ResolvePrinterType()
        {
            ITypeOfPrinter typeOfPrinter;
            var random = new Random();
            if (random.Next(2) == 1)
            {
                typeOfPrinter = new ColorfullPrinter();
            }
            else
            {
                typeOfPrinter = new BlackAndWhitePrinter();
            }
            return typeOfPrinter;

        }
        
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }
      
        private object Resolve(Type type)
        {
            Type resolveType=null;
        
            try
            {
                resolveType = dictionaryType[type];

            }
            catch
            {
                throw new Exception(string.Format("The requested type {0} is not in registered dictionary",type));
            }
          
            ConstructorInfo firstConstructorInfo = resolveType.GetConstructors().First();

            ParameterInfo[] constructorParameters = firstConstructorInfo.GetParameters();
            if(!constructorParameters.Any())
            {
                return Activator.CreateInstance(resolveType);
            }
            var resolveParameterList= constructorParameters.Select(parameterToResolve => Resolve(parameterToResolve.ParameterType)).ToList();
            return firstConstructorInfo.Invoke(resolveParameterList.ToArray());
        }

        public void Register<TFrom, TTo>()
        {
            dictionaryType.Add(typeof(TFrom),typeof(TTo));
        }
    }
}