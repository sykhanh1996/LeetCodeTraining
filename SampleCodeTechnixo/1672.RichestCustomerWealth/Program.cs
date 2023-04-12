// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[][] a = {
    new [] { 1, 5 },
    new [] { 7, 3 },
    new [] { 3, 5 }
};
var test = MaximumWealth(a);
int MaximumWealth(int[][] accounts)
{
    var dic = new Dictionary<int, int>();
    for (int i = 0; i < accounts.Length; i++)
    {
        var wealth = 0;
        for (int j = 0; j < accounts[i].Length; j++)
        {
            wealth += accounts[i][j];
        }
        dic[i] = wealth;
    }
    var max = dic.Values.Max(); ;

    return max;
}