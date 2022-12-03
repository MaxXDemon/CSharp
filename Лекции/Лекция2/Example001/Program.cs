int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a1 = 51;
int a2 = 65;
int a3 = 31;

int b1 = 41;
int b2 = 451;
int b3 = 16;

int c1 = 71;
int c2 = 18;
int c3 = 99;

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

// if (a2>max) max=a2;
// if (a3>max) max=a3;

// if (b1>max) max=b1;
// if (b2>max) max=b2;
// if (b3>max) max=b3;

// if (c1>max) max=c1;
// if (c2>max) max=c2;
// if (c3>max) max=c3;

Console.WriteLine (max);
