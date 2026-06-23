using System.Linq.Expressions;

namespace Main;

class Program
{
    static void Main(string[] args)
    {
        bool validString = false;

        do
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            bool lengthCheck = true;

            if (!(s.Length >= 5 && s.Length <= 7))
            {
                lengthCheck = false;
                Console.WriteLine("Invalid string: length check not met.");
            }

            bool caseCheck = true;

            if (s.ToUpper() != s)
            {
                caseCheck = false;
                Console.WriteLine("Invalid string: case check not met.");
            }

            bool uniqueCheck = true;
            List<char> seen = [];

            for (int i = 0; i < s.Length; i++)
            {
                if (seen.Contains(s[i]))
                {
                    uniqueCheck = false;
                    Console.WriteLine("Invalid string: uniqueness check not met.");
                    break;
                }
                seen.Add(s[i]);
            }

            bool sumCheck = true;
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += (int) s[i];
            }

            if (!(sum >= 420 && sum <= 600))
            {
                sumCheck = false;
                Console.WriteLine("Invalid string: ASCII code sum check not met.");
            }

            if (lengthCheck && caseCheck && uniqueCheck && sumCheck)
            {
                validString = true;
            }


        } while (!validString);
        Console.WriteLine("Valid string!");
    }
}
