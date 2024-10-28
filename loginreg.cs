using System.Collections.Generic;
using System;
class HelloWorld {
	private static Dictionary<string,string> usuarios = new Dictionary <string,string>();
	static void Main(string [] args) {
		while (true)
		{
			Console.WriteLine("Escolha uma opC'C#o :");

			Console.WriteLine("1.Registrar");

			Console.WriteLine("2.Login");

			Console.WriteLine("3.Sair");

			string opcao = Console.ReadLine();

			switch(opcao)
			{
			case "1":
				Registrar();
				break;
			case "2":
				Login();
				break;
			case "3":
				Console.WriteLine("Saindo.....");
				return;
			default:

				Console.WriteLine("OpC'C#o invalida.Tente Novamente!");
				break;
			}
		}

	}


	private static void Registrar()
	{

		Console.WriteLine("Digite um nome de usuario:");
		string usuario = Console.ReadLine();

		Console.WriteLine("Digite uma senha de usuario:");
		string senha = Console.ReadLine();


		if (usuarios.ContainsKey(usuario))
		{

			Console.WriteLine("Usuario jC! existe. Tente outro!");

		} else {
			usuarios.Add(usuario,senha);

			Console.WriteLine("Cadastro Realizado com sucesso!");
		}
	}



	private static void Login() {
		Console.WriteLine("Digite seu nome de usuario:");
		string usuario = Console.ReadLine();

		Console.WriteLine("Digite sua senha de usuario:");
		string senha = Console.ReadLine();
		if(usuarios.TryGetValue(usuario, out string senhaCadastrada))
		{
			if(senhaCadastrada == senha)
			{
				Console.WriteLine("Login Bem Sucedido");
			} else {
				Console.WriteLine("Senha incorreta");
			}

		} else {
			Console.WriteLine("Usuario nC#o encontrado.");
		}

	}
}