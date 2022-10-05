int[] a = {6,7,4,2,1,7,8,3};
int max = a[0];

for(int i = 1; i < 8; i ++)
{
    if (a[i] > max) max = a[i];
}

Console.WriteLine(max);
