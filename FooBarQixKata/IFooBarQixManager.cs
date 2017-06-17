using System.Collections.Generic;

namespace FooBarQixKata
{
    public interface IFooBarQixManager
    {
        string Get(int value);
        IDictionary<int, string> GetDico();
        string EvalFooBrQix(int nunmber);
    }
}