namespace M1_01;

public class Recursion
{
    //method for calculating area of a square
    //it keeps adding the width to the result until the width is 1
    public static int Areal(int bredde) {
        int resultat;
        if (bredde == 1) 
        {
            resultat = 1;
        } 
        else 
        {
            resultat = bredde + Areal(bredde - 1);
        }
        return resultat;
    }
    
    //Method for calculating Faculty of a number,
    //it keeps multiplying the number with the number minus one until it reaches 1
    public static int Faculty(int num)
    {
        int resultat;
        if (num == 1)
        {
            resultat = 1;
        } 
        else 
        {
            resultat = num * Faculty(num - 1);
        }

        return resultat;
    }
    
    //Method for finding the two biggest positive numbers  by using Euclids algorithm,
    //it keeps subtracting the smaller number from the bigger number until they are equal
    public static int Euclid(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        else if (a > b)
        {
            return Euclid(a - b, b);
        }
        else
        {
            return Euclid(a, b - a);
        }
    }

    //method for calculating power (potens) of a number
    //it keeps multiplying the number with itself until the power is 1
    public static int Power(int n, int p)
    {
        if (p == 1)
            return n;
        else
        {
            return n * Power(n, p - 1);
        }
    }
    
    //recursion method for calculating a * b
    // it keeps adding a to the result until b is 1
    public static int Multiply(int a, int b)
    {
        if (b == 1)
            return a;
        else
        {
            return a + Multiply(a, b - 1);
        }
    }
    
    //recursion method for reverse string
    //it keeps adding the last letter of the string to the result until the string is empty
    public static string Reverse(string s)
    {
        if (s.Length == 0)
            return s;
        else
        {
            return Reverse(s.Substring(1)) + s[0];
        }
    }
}