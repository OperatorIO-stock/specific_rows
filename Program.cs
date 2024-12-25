namespace specific_rows;

class Program
{
    static void Main(string[] args)
    {
        int columnNumber = 0;
        int lineNumber = 1;
        int sum = 0;
        int multiplication = 1;

        int[,] array = { { 123, 56, 18 }, 
                         { 66, 12, 4 }, 
                         { 2, 90, 797 } };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]} ");
                
            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(1); i++)
            sum += array[lineNumber, i];

        for (int i = 0; i < array.GetLength(0); i++)
            multiplication *= array [i, columnNumber];

        Console.WriteLine($"Сумма = {sum}\nПроизведение = {multiplication}");
    }
}
