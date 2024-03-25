namespace HomeWork_13
{
    public class WrongLoginExeption : Exception
    {
        public WrongLoginExeption() { }
        public WrongLoginExeption(string message) : base(message) { }
    }
}
