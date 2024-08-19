namespace ForatiHw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestPolygon test = new TestPolygon();
                test.DynamicTest();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
