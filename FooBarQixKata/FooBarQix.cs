namespace FooBarQixKata
{
    public class FooBarQix
    {
        private readonly IFooBarQixManager _fooBarQixManager;

        public FooBarQix(IFooBarQixManager fooBarQixManager)
        {
            _fooBarQixManager = fooBarQixManager;
        }
        public string Eval(int number)
        {
            return _fooBarQixManager.EvalFooBrQix(number);
        }
    }
}