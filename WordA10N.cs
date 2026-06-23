string input = "elephant-rides are really fun!";
string[] inputSplit = input.Split(" ");


string result = "";
int length2 = 0;
for (int i = 0; i < inputSplit.Length; i++)
{
    if (inputSplit[i].Length < 4)
    {
        result += inputSplit[i];
        continue;
    }
    if (inputSplit[i].Contains("-"))
    {
        string[] secondSplit = inputSplit[i].Split("-");

        int length = 0;
        for (int k = 0; k < secondSplit.Length; k++)
        {
            length = secondSplit[k].Substring(1, secondSplit[k].Length - 1).Length - 1;
            result += $"{secondSplit[k][0]}{length}{secondSplit[k][secondSplit[k].Length - 1]}";

            if (k != secondSplit.Length - 1)
            {
                result += "-";
            }
        }
    } 
    else 
    {

        if (!Char.IsLetter(inputSplit[i][inputSplit[i].Length - 1]))
        {
            length2 = inputSplit[i].Substring(1, inputSplit[i].Length - 2).Length - 1;
            result += $"{inputSplit[i][0]}{length2}{inputSplit[i][inputSplit[i].Length - 2]}";
        }
        else
        {
            length2 = inputSplit[i].Substring(1, inputSplit[i].Length - 1).Length - 1;
            result += $"{inputSplit[i][0]}{length2}{inputSplit[i][inputSplit[i].Length - 1]}";
        }
    }
}
Console.WriteLine(result);