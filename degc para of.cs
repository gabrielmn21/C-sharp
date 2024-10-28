/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class HelloWorld {
    public string Nome;
    public HelloWorld(string nome){
         Nome = nome;
    }
	public void Temp() {

        conversaoTemp();

		}
		
	public void conversaoTemp(){
		try {
			Console.WriteLine("Digite o grau em °C:");
			int celsius = Int32.Parse(Console.ReadLine());

			int convertF = (9*celsius/5 + 32);



			Console.WriteLine($"O grau convertido em °F é: {convertF}");
		} catch{
		    
		    Console.WriteLine("Não é uma temp válida");
		}
	}
}

class Nova{
    static void Main(){
        HelloWorld nome = new HelloWorld("Gabriel");
        nome.Temp();
        Console.WriteLine(nome.Nome);
    }
    
    
}