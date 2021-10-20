using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("De uma nota de 0 a 10 para o atendimento");
		String notaAtendimento = Console.ReadLine();
		
		Console.WriteLine("De uma nota de 0 a 10 para o produto");
		String notaProduto = Console.ReadLine();
		
		Console.WriteLine("De uma nota de 0 a 10 para o site do produto");
		String notaSite = Console.ReadLine();
		
		Console.WriteLine("Qual seu perfil de cliente? 1 = Exigente, 2 = Moderado, 3 = Complacente");
		String perfil = Console.ReadLine();
		
		int intNotaAtendimento = Int32.Parse(notaAtendimento);
		int intNotaProduto = Int32.Parse(notaProduto);
		int intNotaSite = Int32.Parse(notaSite);
		
		Double media = (intNotaAtendimento + intNotaProduto + intNotaSite) / 3;
		
		switch(perfil) {
			case "1":
				CalcularSatisfacao(8, 5, media);
			break;
			case "2":
				CalcularSatisfacao(6, 4, media);	
			break;
			case "3":
				CalcularSatisfacao(5, 3, media);		
			break;
			default:
				Console.WriteLine("Esse perfil não existe");	
			break;
		}
		
		
	}
	
	public static void CalcularSatisfacao(int primeiroRange, int segundoRange, Double media) {
		if(media >= primeiroRange) {
		   Console.WriteLine("Muito satisfeito");	
		} else {
		   if(media >= segundoRange) {
			  Console.WriteLine("Moderadamente satisfeito");   
		   } else {
			  Console.WriteLine("Risco de cancelamento");   
		   }
		}
	}
}