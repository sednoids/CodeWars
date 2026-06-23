namespace SplitStrings;

class Program
{
    static void Main(string[] args)
    {
        string text = "T";

        int length = 0;
        if (text.Length % 2 == 0) {
            length = text.Length / 2;
        } else {
            length = (text.Length + 1) / 2;
        }
        string[] splitStrings = new string[length];

        int n = 0;
        if (text.Length == 1) {
            splitStrings[0] = text[0].ToString();
        } else {
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0) {
                    splitStrings[0] = text[0].ToString();
                    continue;
                }
                if (i % 2 == 0) {
                    n++;
                    splitStrings[n] = text[i].ToString();
                    if (i == text.Length - 1 && text.Length % 2 == 1)
                    {
                        splitStrings[n] += "_";
                    }
                } else {
                    splitStrings[n] += text[i].ToString();
                }
            }
        }

        string result = string.Join(",", splitStrings);
        Console.WriteLine(result);
    }
}