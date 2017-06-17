using NFluent;
using NUnit.Framework;

namespace FooBarQixKata
{
    public class FooBarQixTests
    {
        [TestCase(1, "1")]
        public void should_return_number_when_input_is_regular_number(int number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixManager()).Eval(number);
            Check.That(computed).IsEqualTo(expected);
        }

        [TestCase(3, "FooFoo")]
        public void should_return_foo_when_input_is_divisible_by_3_or_contains_3(int number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixManager()).Eval(number);
            Check.That(computed).IsEqualTo(expected);
        }
        [TestCase(5, "BarBar")]
        public void should_return_foo_when_input_is_divisible_by_5_or_contains_5(int number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixManager()).Eval(number);
            Check.That(computed).IsEqualTo(expected);
        }

        [TestCase(7, "QixQix")]
        public void should_return_foo_when_input_is_divisible_by_7_or_contains_7(int number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixManager()).Eval(number);
            Check.That(computed).IsEqualTo(expected);
        }

        [TestCase(53, "BarFoo")]
        [TestCase(21, "FooQix")]
        [TestCase(51, "FooBar")]
        [TestCase(15, "FooBarBar")]
        [TestCase(33, "FooFooFoo")]
        [TestCase(13, "Foo")]
        public void should_return_value_using_foo_bar_qix_rules(int number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixManager()).Eval(number);
            Check.That(computed).IsEqualTo(expected);
        }
    }
}