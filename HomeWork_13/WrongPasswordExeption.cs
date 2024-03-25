namespace HomeWork_13
{
    public class WrongPasswordExeption : Exception
    {
        public WrongPasswordExeption() { }
        public WrongPasswordExeption(string message) : base(message) { }


    }
}
