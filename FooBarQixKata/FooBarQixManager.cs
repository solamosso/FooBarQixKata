﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FooBarQixKata
{
    public class FooBarQixManager : IFooBarQixManager
    {
        private readonly Dictionary<int, string> _rules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix"
        };

        public IDictionary<int, string> GetDico()
        {
            return _rules;
        }
        
        public string Get(int value)
        {
            return _rules[value];
        }


        public string EvalFooBrQix(int number)
        {
            var numberString = number.ToString();
            var result = BuildResultByDivider(number);
            result = numberString.Aggregate(result, (current, t) => current + BuildResultByContains(Int16.Parse(t.ToString())));

            if (string.IsNullOrEmpty(result))
                result = number.ToString();
            return result;
        }


        private string BuildResultByDivider(int number)
        {
            var result = string.Empty;
            foreach (var val in GetDico())
            {
                if (number % val.Key == 0)
                    result += val.Value;
            }
            return result;
        }
        private string BuildResultByContains(int number)
        {
            var result = string.Empty;
            if (GetDico().ContainsKey(number))
                result += Get(number);
            return result;
        }
    }
}
