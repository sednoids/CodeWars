using System.Globalization;

namespace TranspositionCipher;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Enter number of columns: ");
        int numOfCol = int.Parse(Console.ReadLine());
        int numOfRows;

        if (text.Length % numOfCol != 0)
        {
            numOfRows = (text.Length / numOfCol) + 1;
        }
        else 
        {
            numOfRows = text.Length / numOfCol;
        }

        char[,] cipher = new char[numOfRows, numOfCol];

        int n = 0;
        for (int i = 0; i < numOfRows; i++)
        {
            for (int j = 0; j < numOfCol; j++)
            {
                cipher[i, j] = text[n];
                n++;
            }
        }

        string result = "";
        for (int i = 0; i < numOfCol; i++)
        {
            for (int j = 0; j < numOfRows; j++)
            {
                result += cipher[j, i];
            }
        }
        Console.WriteLine(result);
    }
}