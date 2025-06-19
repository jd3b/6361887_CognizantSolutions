using System;
class FinancialForecast
{
    static double CalculateFutureValueMemoized(double p, double r, int y, double[] memo)
    {
        if (y == 0) return p;
        if (memo[y] != 0) return memo[y];

        memo[y] = CalculateFutureValueMemoized(p, r, y - 1, memo) * (1 + r);
        return memo[y];
    }
    static void Main(string[] args)
    {
        double principal = 1000; 
        double rate = 0.05;      
        int years = 10;          
        double[] memo = new double[years + 1];      
        double futureValue = CalculateFutureValueMemoized(principal, rate, years, memo);
        Console.WriteLine($"Future Value after {years} years: {futureValue:F2}");
    }
}
