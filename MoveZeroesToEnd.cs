namespace MoveZeroesToEnd;

class Program
{
    static void Main(string[] args) 
    {
        int[] array = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
        int[] result = new int[array.Length];
        int n = 0;


        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] != 0)
            {
                result[n] = array[j];
                n++;
            }
           
        }

        foreach (int v in result)
        {
            Console.WriteLine(v);
        }
    }
}