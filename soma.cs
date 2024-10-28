/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite os numero:");
    int num1= Int32.Parse(Console.ReadLine());
    int num2= Int32.Parse(Console.ReadLine());
   int soma = num1+num2;
    Console.WriteLine("A soma é:" + soma);
    
  }
}