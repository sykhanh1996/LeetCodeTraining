// See https://aka.ms/new-console-template for more information

int[] demo = {3,2,2,3 };
var count = RemoveElement(demo, 3);
Console.WriteLine(count.ToString());
Console.ReadLine();
int RemoveElement(int[] nums, int val)
{
    int n = nums.Length;
    for (int i = 0; i < n;)
    {
        if (nums[i] == val)
        {
            for (int j = i; j <= (n-2); j++)
            {
                nums[j] = nums[j+1];
            }

            n--;
        }
        else
        {
            i++;
        }
        
    }
    return n;
}

int RemoveElementKhanhSolution(int[] nums, int val)
{
    var dic = new Dictionary<int,int>();
    var count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            dic[i] = nums[i];
        }
    }
    return dic.Count;
}