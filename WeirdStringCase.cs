namespace WeirdStringCase;

class Program
{
    static void Main(string[] args)
    {
        string text = "Weird string case";
        char[] textArray = text.ToCharArray();

        int j = 0;
        for (int i = 0; i < textArray.Length; i++)
        {
            if (j % 2 == 0)
            {
                textArray[i] = Char.ToUpper(textArray[i]);
            }
            j++;
            if (textArray[i] == ' ')
            {
                j = 0;
            }
        }

        string res = new string(textArray);
        Console.WriteLine(res);


    }
}