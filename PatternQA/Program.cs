
public class Program
{
    public static async Task Main(string[] args)
    {
        //Print Multiplication Tables ::
        //await PrintMultiplicationTables();


        //Print Half Triangle Pattern::
        await PrintHalfTriangle();

        //Print Half Triangle Pattern::
        await PrintHalfTriangle2();
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
        // Number of rows to print
        int numberOfRows = 5;

        // Loop through each row
        for (int i = numberOfRows; i < 0; i--)
        {
            // For each row, print asterisks
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            // Move to the next line after printing a row
            Console.WriteLine();
        }
    }

    public static async Task PrintHalfTriangle2()
    {
        // Number of rows to print
        int numberOfRows = 5;

        // Loop through each row
        for (int i = 0; i < numberOfRows; i++)
        {
            // For each row, print asterisks
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            // Move to the next line after printing a row
            Console.WriteLine();
        }
    }
}