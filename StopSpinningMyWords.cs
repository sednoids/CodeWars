namespace StopSpinningMyWords;

class Program
{
    static void Main(string[] args)
    {
        string text = "Stop spinning my words";
        string[] words = text.Split(" ");

        string result = "";
        for (int i = 0; i < words.Length; i++)
        {
            char[] temp;
            if (words[i].Length >= 5)
            {
                temp = words[i].Reverse().ToArray();
                result += $"{new string(temp)} ";
            }
            else
            {
                result += $"{words[i]} ";
            }
        }
        Console.WriteLine(result.Trim());

    }
}
