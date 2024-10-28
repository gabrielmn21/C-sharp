/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite o numero");
    int Calculo = int.Parse(Console.ReadLine());
    
    double eAproximado = CalcularE(Calculo);
    Console.WriteLine (eAproximado);
    
  }
    static double CalcularE(int Calculo)
        {
            double eAproximado = 0.0;
            double a = 1.0;
            int i;
            for (i = 1; i <= Calculo; i++){

                eAproximado+= 1/a;

            
                a++;
           
            }
        
            return eAproximado;
        }
        
    
}
  
