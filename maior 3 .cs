/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
	
		static int digite(int ord, int tam) {

			int[] posicao = new int[tam];
			for(int o = 0; o < tam; o++) {
				posicao[o] = o+1;
			}
			 try{
			Console.WriteLine($"Digite o {posicao[ord]} num:");
			int num = Int32.Parse(Console.ReadLine());
			return num;
			 }catch{
			 Console.WriteLine("nao e valido");    
			     
			 }


		static void maior(int[] nums) {
			int maximo;
			maximo = nums[0];
			for(int a = 0; a < nums.Length; a++) {
				if(nums[a] > maximo) {
					maximo = nums[a];
				}
			}

			Console.WriteLine($"o maior valor C) : {maximo}");
		}

		static void Main() {
			int tam = Int32.Parse(Console.ReadLine());
			int[] nums = new int[tam];

			for(int i =0; i <nums.Length; i++) {
				nums[i] = digite(i, tam);
			}

			maior(nums);
		} 
	}
}