namespace BasicPrograming1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine("Enter The Power");
            int Power = int.Parse(Console.ReadLine());
            int a = 2;
            for (int i = 0; i <= Power; i++)
            {
                result = Math.Pow(a, i);
                Console.WriteLine(a + " power of " + i + " is " + result);
                Console.ReadLine();
            }



        }
    }
}