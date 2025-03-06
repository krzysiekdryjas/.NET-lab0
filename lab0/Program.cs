//namespace lab0
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}

namespace lab0
{
    class Program
    {
        static void Main()
        {
            int zakres = int.Parse(Console.ReadLine());

            FizzBuzz fizzbuzz = new FizzBuzz(zakres);
            fizzbuzz.Wyswietlanie();
        }
    }
}
