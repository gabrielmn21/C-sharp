using System;
class HelloWorld {
	static void Main() {
	try{
		Console.WriteLine("Digite o numero");
		int num = Int32.Parse(Console.ReadLine());

		int dobroNum = num*2;
		Console.WriteLine($"O dobro do numero C): {dobroNum}");
	
	}catch{
	    Console.WriteLine("Digite um numero!");
	} 
	    
	}
}