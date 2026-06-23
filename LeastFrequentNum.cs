namespace LeastFrequentNum;

class Program
{
    static void Main(string[] args)
    {
        string list = "8227878";
        Dictionary<char, int> freqs = [];

        for (int i = 0; i < list.Length; i++)
        {
            if (freqs.ContainsKey(list[i]))
            {
                freqs[list[i]]++;
            }
            else 
            {
                freqs.Add(list[i], 1);
            }
        }

        char minValueLetterKey = freqs.Min(f => f.Key);
        int minValueLetterValue = freqs.Min(f => f.Value);


        bool moreLeastFreq = false;
        foreach (KeyValuePair<char, int> f in freqs)
        {
            if (f.Value == minValueLetterValue && f.Key != minValueLetterKey)
            {
                Console.WriteLine("More than one least-frequent number.");
                moreLeastFreq = true;
                break;
            }
        }

        if (!moreLeastFreq)
        {
            Console.WriteLine(minValueLetterKey);
        }
    }
}