namespace SingleCharcterPalindrome;

class Program
{
    static void Main(string[] args)
    {
        string s = "madmam";
        char[] reversedArray = s.ToCharArray();
        Array.Reverse(reversedArray);
        char[] stringArray = s.ToCharArray();

        if (new string(stringArray) == new string(reversedArray))
        {
            Console.WriteLine("OK");
        }
        else
        {
            int mismatches = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == reversedArray[i])
                {
                    continue;
                }
                if (stringArray[i] != reversedArray[i])
                {
                    reversedArray[i] = ' ';
                    string result = "";
                    for (int j = 0; j < reversedArray.Length; j++)
                    {
                        if (reversedArray[j] == ' ')
                        {
                            continue;
                        }
                        result += reversedArray[j];
                    }
                    if (result == new string(stringArray))
                    {
                        Console.WriteLine("Remove one letter");
                    }
                    else
                    {
                        Console.WriteLine("Not possible");
                    }
                    break;
                }
            }
        }




    }
}