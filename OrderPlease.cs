namespace OrderPlease;

class Program {
    static void Main(string[] args)
    {
        string text = "is2 Thi1s T4est 3a";
        string[] textArray = text.Split(" ").ToArray();
        string[] result = new string[textArray.Length];

        string nums = "123456789";

        for (int i = 0; i < textArray.Length; i++)
        {
            for (int j = 0; j < textArray[i].Length; j++)
            {
                if (nums.Contains(textArray[i][j]))
                {
                    result[int.Parse(textArray[i][j].ToString()) - 1] = textArray[i];
                }
            }
        }

        string resultStr = string.Join(" ", result);
        Console.WriteLine(resultStr);
    }
}