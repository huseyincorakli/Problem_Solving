//Verilen bir tamsayı dizisi ve bir hedef sayı, dizideki hangi iki elemanın hedef sayıyı verdiğini bulan bir algoritma tasarlayın. Örneğin, [2, 7, 11, 15] dizisi ve hedef 9 ise, çözüm [2, 7] olacaktır.

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 150,100,50,150 };
        int target = 157;
        int[] result = FindTwoSum(nums, target);

        if (result != null)
        {
            Console.WriteLine("Çözüm: [" + result[0] + ", " + result[1] + "]");
        }
        else
        {
            Console.WriteLine("Çözüm bulunamadı.");
        }
    }

    static int[] FindTwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { nums[i], nums[j] };
                }
            }
        }

        return null;
    }
}
