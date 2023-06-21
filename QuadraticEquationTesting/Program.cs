using QuadraticEquationTesting;

var result = QuadraticEquation.Solve(1, 0, 1);
{
    for(int i = result.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(result[i]);
    }
}
