using static System.Console;
using static System.Convert;
using static System.Math;


string[] str = new string[3];
char[] res = new char[3];
char y = ' ';
int a, b, c;
a = b = c = 0;

for (int i = 0; i < 3; i++)
{
    str[i] = ReadLine();
    string x = str[i];
    switch (x[1])
    {
        case '>':
            y = x[0];
            break;
        case '<':
            y = x[2];
            break;
    }
    switch (y)
    {
        case 'A':
            a++;
            break;
        case 'B':
            b++;
            break;
        case 'C':
            c++;
            break;

    }
}
if (a == b || b == c || c == a)
{
    WriteLine("Impossible");
}
else
{
    res[a] = 'A';
    res[b] = 'B';
    res[c] = 'C';
    for (int i = 0; i < 3; i++)
    {
        Write(res[i]);
    }
    WriteLine();
}