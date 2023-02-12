int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 43;
int b1 = 23;
int c1 = 87;
int a2 = 56;
int b2 = 82;
int c2 = 74;
int a3 = 39;
int b3 = 22;
int c3 = 19;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);