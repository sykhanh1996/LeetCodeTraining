// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var result = firstUniqChar("loveleetcode");
Console.WriteLine(result);
Console.ReadLine();
int firstUniqChar(string s)
{
    char[] arr = s.ToCharArray();
    int[] count = new int[123];

    for (int i = 0; i < arr.Length; i++)
    {
        char c = arr[i];
        int index = (int)c;
        count[index]++;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        char c = arr[i];
        int index = (int)c;
        if (count[index] == 1)
        {
            return i;
        }
    }
    return -1;
}