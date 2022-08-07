int a = 4;
int b = 10;
int c = 19;
int d = 12;
int e = 23;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("max = ");
Console.WriteLine (max);