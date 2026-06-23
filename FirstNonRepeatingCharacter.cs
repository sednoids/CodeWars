namespace FirstNonRepeatingCharacter;

class Program
{
    static void Main(string[] args)
    {
        string text = "sTreSS";
        Dictionary<char, int> frequencies = [];

        for (int i = 0; i < text.Length; i++)
        {
            if (frequencies.ContainsKey(text[i]))
            {
                frequencies[text[i]]++;
            }
            else if (frequencies.ContainsKey(Char.ToLower(text[i])))
            {
                frequencies[Char.ToLower(text[i])]++;
            }
            else
            {
                frequencies.Add(text[i], 1);
            }
        }

        foreach (KeyValuePair<char, int> f in frequencies)
        {
            if (f.Value == 1)
            {
                Console.WriteLine(f.Key);
                break;
            }
        }

    }
}