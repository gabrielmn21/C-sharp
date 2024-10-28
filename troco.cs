/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class troco {
  static void Main() {
    double nota100=0, nota50=0, nota20=0, nota20int=0;
    double salario=0.0;
    Console.WriteLine("Digite o salario:");
    salario = double.Parse(Console.ReadLine());
    
    nota100 = (int) (salario/100.0);
    salario = salario%100.0;
    

    
    Console.WriteLine(nota100);
    
    nota50 =  (int)(salario/50.0);
    salario =(salario%50.0);
    
     Console.WriteLine(nota50);
     nota20 = (salario/20.0);
     nota20int = (int)(salario/20.0);

     salario =(salario%20.0);
     
     nota20int += 1%(nota20 - nota20int+1);
     

    Console.WriteLine(nota20int);
    
    // % resto
    // 1452 numero/100 => 14,52 => 0,2 => 0,52 * 100 = 52 => 1º 50 => 2 <=> 20 || +18
    
 
   
    
    
    
  }
}