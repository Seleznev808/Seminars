int FunctionAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else 
    {
        if (m > 0 && n == 0) return FunctionAckermann(m - 1, 1);
        else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    }
}

int m = 3;
int n = 3;
Console.WriteLine(FunctionAckermann(m, n));