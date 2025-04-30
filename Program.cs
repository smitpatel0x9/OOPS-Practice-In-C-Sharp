namespace Practice
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("Hello, World!");
    //        //int age = 5;
    //        //float b = 5.5f;
    //        //double d = 16.78;
    //        //decimal e = 0.734m;
    //        ////Console.WriteLine(typeof(String));
    //        ////Console.WriteLine(a^2);
    //        ////if (age >= 18)
    //        ////    Console.WriteLine("Eligible for voting");
    //        ////else
    //        ////    Console.WriteLine("Not eligible for voting");
    //        ////int marks = 75;
    //        ////String grade = marks < 40 ? "F" : marks < 44 ? "P" : marks < 54 ? "C" : marks < 59 ? "B" : marks < 69 ? "B +": marks < 79 ? "A" : marks < 89 ? "A +": "S";
    //        ////Console.WriteLine(grade);
    //        ////Func<int, int, int> add = (a, b) => { Console.WriteLine("Hi"); return a + b; };
    //        ////Console.WriteLine(add(3, 4));
    //        ////Action<int> abc = i => Console.WriteLine(i * 5);
    //        ////abc(1);
    //        ////Predicate<int> check = i => i % 2 == 0;
    //        ////Console.WriteLine(check(age));
    //        //List<int> num = new List<int>();
    //        //num.Add(1);

    //    }
    //}
    public class Example
    {
        public void Method()
        {
            try
            {
                // Some code that might cause an exception
                int result = 10 / 0; // This will cause a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                // Handle the exception
                Console.WriteLine("An error occurred: " + ex.Message);

                // Rethrow the exception
                throw;
            }
        }
    }
}
