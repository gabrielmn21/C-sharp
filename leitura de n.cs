using System;
using System.Linq;

class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite a quantidade de valores:");
    int[] numN = new int[int.Parse(Console.ReadLine())];
    int i;
    
    for(i = 0; i< numN.Length; i++ ){
   
        
            
        Console.WriteLine($"Digite os valores.");
        numN[i] = int.Parse(Console.ReadLine());
         
    }  
        
        
        int maior = numN.Max();
        int menor = numN.Min();
        
        int indexmaior = Array.IndexOf(numN, maior);
        int indexmenor = Array.IndexOf(numN, menor);
        Console.WriteLine($"O maior valor é: {maior} na ordem de numero {indexmaior +1 }");
         Console.WriteLine($"O menor valor é: {menor} na ordem de numero {indexmenor +1 }");
        
        
        
}
}