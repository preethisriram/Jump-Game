// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static bool jumpgame(int[] nums)
{
    int n = nums.Length;
    int reachable = 0;
    for (int i = 0; i < n; i++)
    {
        if (i > reachable)
        {
            return false;
        }
       reachable = Math.Max(reachable, i+nums[i]);
    }
    return true;
}

int[] jumps = new int[] { 1, 1, 2, 5, 2, 1, 0, 0, 1, 3 };
bool res = jumpgame(jumps);
Console.WriteLine(res);
