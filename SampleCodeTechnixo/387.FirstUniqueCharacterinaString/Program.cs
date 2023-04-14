// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var result = firstUniqChar("loveleetcode");
Console.WriteLine(result);
Console.ReadLine();
int firstUniqChar(string s)
{
    var dic = new Dictionary<int, string>();
    for (int i = 0; i < s.Length; i++)
    {
        dic[i] = s[i].ToString();
    }

    var distinct = dic.Distinct();
    foreach (var item in distinct.OrderBy(x=>x.Key))
    {
        return item.Key;
    }

    return -1;
}