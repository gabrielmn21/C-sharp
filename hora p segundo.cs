/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
      try{



 
    
    Console.WriteLine("Digite a Hora:");
   int hora=Int32.Parse(Console.ReadLine());
       Console.WriteLine("Digite o minuto:");
    int minuto=Int32.Parse(Console.ReadLine());
     Console.WriteLine("Digite o segundo:");
    int segundo= Int32.Parse(Console.ReadLine());
   if(hora <0 || minuto<0 || segundo<0){
        Console.WriteLine("Digite uma hora valida!");
    }else{

 
    int convertHora= hora * 3600;
    int convertMin= minuto * 60;
    int convertSeg= segundo * 1;
    
   
    int convertTotal= convertHora+convertSeg+convertMin;
    Console.WriteLine($"A hora em segundos é:{convertTotal}");
    
   
    
      }}catch{
    
Console.WriteLine("Não e uma hora");
}

  }
}