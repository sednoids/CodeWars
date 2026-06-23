namespace Harshad;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int found = 0;
        int curr = 1;

        while (found < n)
        {
            int result = 0;
            char[] cArray = curr.ToString().ToArray();
            foreach (char c in cArray)
            {
                result += Convert.ToInt32(c.ToString());
            }

            if (curr % result == 0)
            {
                found++;
            }
            curr++;
        }
        Console.WriteLine(curr - 1);

    }
}