
public class Program
{
    public static async Task Main(string[] args)
    {
        //Print Multiplication Tables ::
        //await PrintMultiplicationTables();


        //Print Half Triangle Pattern::
        await PrintHalfTriangle();
    }
    public static async Task PrintMultiplicationTables()
    {
        try
        {
            for (int table = 1; table < 20 + 1; table++)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(table + " * " + i + " = " + table * i);
                }
                Console.WriteLine("=================");
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    public static async Task PrintHalfTriangle()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("*");
        }
    }
}