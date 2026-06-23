namespace SplitOddAndEven;

class Program
{
    static void Main(string[] args)
    {
        long n = 135246;

        string nString = n.ToString();

        int remainder = 0;
        List<string> result = [];
        int pos = 0;
        for (int i = 0; i<nString.Length; i++)
        {
            if (i == 0)
            {
                remainder = int.Parse(nString[0].ToString()) % 2;
                result.Add(nString[0].ToString());
                continue;
            }

            if (remainder == int.Parse(nString[i].ToString()) % 2)
            {
                remainder = int.Parse(nString[i].ToString()) % 2;
                result[pos] += nString[i];
            }
            else
            {
                remainder = int.Parse(nString[i].ToString()) % 2;
                pos++;
                result.Add(nString[i].ToString());
            }
        }

        long[] t = new long[result.Count];

        for (int j = 0; j < result.Count; j++)
        {
            t[j] = int.Parse(result[j]);
        }
    }
}