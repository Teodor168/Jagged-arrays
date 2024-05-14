namespace MaksimalnaPloshtadka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] arrays = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arrays[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    int curSum = arrays[i, j] + 
                        arrays[i, j + 1] +
                        arrays[i + 1, j] + 
                        arrays[i + 1, j + 1];

                    if (curSum > bestSum)
                    {
                        bestSum = curSum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            Console.WriteLine($"{arrays[bestRow, bestCol]} {arrays[bestRow, bestCol + 1]}");
            Console.WriteLine($"{arrays[bestRow + 1, bestCol]} {arrays[bestRow + 1, bestCol + 1]}");
        }
    }
}
