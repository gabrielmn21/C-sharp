
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite a frase/palavra:");
    string input = Console.ReadLine();
    int contaVogal = numVogal(input);
    
    Console.WriteLine($"Numero de vogais é:{contaVogal}");
    
      
  }
  
  static int numVogal(string texto)
  {
      int contagem = 0;
     char[] vogais = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O', 'U'};
      
      foreach (char c in texto)
      {
          if (Array.Exists(vogais, v => v == c))
          {
              contagem++;
          }
      }
  
      return contagem;
  }
  
  
}