namespace SalesReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sales Report application");
            Double[,] SalesData = new Double[4, 4];
            int rows = 4;
            int columns = 4;
            Double EachCellValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Please add value of Salesdata table {i}{j}");
                    string values = Console.ReadLine();
                    if (Double.TryParse(values, out Double value))
                    {
                        SalesData[i, j] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid double value.");
                        j--;
                    }


                }
            }
            Console.WriteLine("Region     Q1     Q2      Q3     Q4");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"  ${SalesData[i, j].ToString("N2")}  ");


                }
                Console.WriteLine();
            }
            double regionData = 0;
            Console.WriteLine("Sales By Region ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    regionData = regionData + SalesData[i, j];
                }

                Console.WriteLine("Region    " + (i+1) + " = $" + regionData.ToString("N2"));
                regionData = 0;

            }
            Console.ReadLine();
            Console.WriteLine("Sales By Quarter");
            Double quarterData = 0;
            for (int j = 0; j < columns; j++)
            {


                for (int i = 0; i < rows; i++)
                {
                    quarterData = quarterData + SalesData[i, j];
                }
                    Console.WriteLine(" $" + quarterData.ToString("N2"));
                    quarterData = 0;

            }
        }
    }
}