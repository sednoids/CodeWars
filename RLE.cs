namespace RLE;

class Program
{
    static void Main(string[] args)
    {
        string run = "RRRRRYYYYRRRGGGBBB";

        int colourCount = 0;
        char currentColour = ' ';
        string result = "";

        for (int i = 0; i < run.Length; i++)
        {
            if (i == 0)
            {
                currentColour = run[i];
                colourCount++;
                continue;
            }

            if (run[i] != currentColour)
            {
                result += $"{colourCount} {currentColour} ";
                currentColour = run[i];
                colourCount = 1;
            }
            else
            {
                colourCount++;
            }
        }

        result += $"{colourCount} {currentColour} ";
        Console.WriteLine(result);
    }
}