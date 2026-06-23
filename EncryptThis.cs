using System.Text;
using System.Text.Encodings.Web;

namespace EncryptThis;

class Program
{
    static void Main(string[] args)
    {
        string s = "72olle 103doo 100ya";
        string[] stringArray = s.Split(" ");

        string ASCIINum = "";
        string result = "";

        char temp1;
        char temp2;
        for (int i = 0; i < stringArray.Length; i++)
        {
            char[] temp = [];
            temp = stringArray[i].ToCharArray();
            for (int j = 0; j < stringArray[i].Length; j++)
            {
                if (Char.IsDigit(stringArray[i][j]))
                {
                    ASCIINum += stringArray[i][j].ToString();
                    temp[j] = ' ';
                    continue;
                }
                char letter = (char)int.Parse(ASCIINum);
                temp1 = temp[j];
                temp2 = temp[^1];
                temp[j] = temp2;
                temp[^1] = temp1;
                

                result += $"{letter}{new string(temp).Trim()} ";
                ASCIINum = "";
                break;
            }
        }
        Console.WriteLine(result.Trim());


    }
}