using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite a operação que quer realizar: 1 - soma, 2 - substracao, 3 - divisao, 4 - multiplicacao");	
		String operacao = Console.ReadLine();
		
		Console.WriteLine("Digite o primeiro numero da operação: ");
		String primeiroNumero = Console.ReadLine();
		
		Console.WriteLine("Digite o segundo numero da operação: ");
		String segundoNumero = Console.ReadLine();
		
		Double doublePrimeiroNumero = Double.Parse(primeiroNumero);
		Double doubleSegundoNumero = Double.Parse(segundoNumero);
		
		switch(operacao) {
			case "1":
				Console.WriteLine("O resultado é " + (doublePrimeiroNumero + doubleSegundoNumero));
			break;
			case "2":
				Console.WriteLine("O resultado é " + (doublePrimeiroNumero - doubleSegundoNumero));
			break;
			case "3":
				Console.WriteLine("O resultado é " + (doublePrimeiroNumero / doubleSegundoNumero));
			break;
			case "4":
				Console.WriteLine("O resultado é " + (doublePrimeiroNumero * doubleSegundoNumero));
			break;
			default:
				Console.WriteLine("Operação inválida");
			break;
		}
	}
}