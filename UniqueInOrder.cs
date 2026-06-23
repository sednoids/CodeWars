using System.Threading.Channels;

namespace UniqueInOrder;

class Program
{
    static void Main(string[] args)
    {
        string blob = "AAAABBBCCDAABBB";
        List<char> uniqueList = [];

        char currentUniqueChar = ' ';
        for (int i = 0; i < blob.Length; i++)
        {
            if (i == 0)
            {
                uniqueList.Add(blob[0]);
                currentUniqueChar = blob[0];
                continue;
            }

            if (currentUniqueChar != blob[i])
            {
                uniqueList.Add(blob[i]);
                currentUniqueChar = blob[i];
            }
            
        }

        string result = string.Join("", uniqueList.ToArray());
        Console.WriteLine(result);
    }
}