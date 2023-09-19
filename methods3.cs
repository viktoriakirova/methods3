//Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
using System;
public class methods3 {
  public static void Main (string [] args){
    Console.Write("Enter a number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The Fibonacci series of {a} th term is " + fib (a+1));
  }
  public static int fib (int num){
    int result = 0;
    if (num == 1){
      return 0;
    }
    else if (num == 2){
      return 1;
    }
    else{
        result += fib(num-1) + fib(num-2);
        return result;
    }
  }
}
