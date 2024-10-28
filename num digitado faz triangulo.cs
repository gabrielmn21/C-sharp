/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite a altura");
    int altura= int.Parse(Console.ReadLine());
    imprimirTriangulo(altura);
  }
  
    static void imprimirTriangulo (int altura){
        int i;
        
         for( i = 1; i<= altura; i++){
             Console.WriteLine(new string('X',i));
         }
          
        }
    }