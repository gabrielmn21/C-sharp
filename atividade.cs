/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite os valores:");
    int index = 1;
    int maior = 0;
    int valor1 = Convert.ToInt32(Console.ReadLine());
    int valor2 = Convert.ToInt32(Console.ReadLine());
    int valor3 = Convert.ToInt32(Console.ReadLine());

     if (valor1 < valor2){
         maior = valor2;
         index = 2;
         
         
     }else{
         maior = valor1;

     }
     
     if (maior < valor3 ){
        maior = valor3;
         index = 3;
     }
    Console.WriteLine(maior+" " +index);
  }
}