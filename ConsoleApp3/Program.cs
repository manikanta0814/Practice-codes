using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Welcome to C# Programming!");
        Main1();
    }

    static void Main1()
    {
        //even or odd number
        Console.WriteLine("Enter a Number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("Even Number");
        else
            Console.WriteLine("Odd Number");

        //prime number
        Console.WriteLine("Enter a Prime Number:");
        int num = Convert.ToInt32(Console.ReadLine());

       if (IsPrime(num))
            Console.WriteLine("Prime Number");
       else
            Console.WriteLine("Not a Prime Number");

        //palindrome string
        Console.WriteLine("Enter a String: ");
        string str = Console.ReadLine();

        if (IsPalindromeString(str))
            Console.WriteLine("String is Palindrome");
        else
            Console.WriteLine("String is not Palindrome");
    }

    static bool IsPrime(int num)
    {
        if (num<= 1)  
            return false;
        for (int i = 2; i * i<=num; i++)
        {
            if (num % i ==0)
                return false;
        }
        return true;
    }

    static bool IsPalindromeString(string str)
    {
        if(string.IsNullOrEmpty(str))
            return true;
        str = str.Replace (" ", "").ToLower();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

   
}