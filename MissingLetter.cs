namespace MissingLetter;

class Program
{
    static void Main(string[] args)
    {
        char[] array = ['O','Q','R','S'];
        string alphabet = "abcdefghijklmnopqrstuvwxyz";


        int index = alphabet.IndexOf(Char.ToLower(array[0]));
        char result = ' ';
        for (int i = 0; i < array.Length; i++)
        {
            if (index == alphabet.IndexOf(Char.ToLower(array[i])))
            {
                index++;
                continue;
            }
            result = alphabet[index];
        }

        if (alphabet.ToUpper().Contains(array[0]))
        {
            Console.WriteLine(Char.ToUpper(result));
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}