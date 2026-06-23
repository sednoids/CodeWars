namespace TwoSum;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 2, 3 };
        int target = 4;

        int i = 0;
        int j = 1;
        do
        {
            if (nums[i] + nums[j] == target)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
                break;
            }
            if (j != nums.Length - 1)
            {
                j++;
                continue;
            }
            if (j == nums.Length - 1)
            {
                i++;
            }
        } while (true);
    }
}