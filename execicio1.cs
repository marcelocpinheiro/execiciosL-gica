using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o ano de nascimento:");
		String ano = Console.ReadLine();
		
		Console.WriteLine("Digite o mes de nascimento:");
		String mes = Console.ReadLine();
		
		Console.WriteLine("Digite o dia de nascimento:");
		String dia = Console.ReadLine();
		
		int intAno = Int32.Parse(ano);
		int intMes = Int32.Parse(mes);
		int intDia = Int32.Parse(dia);
		
		// Ano atual - o ano de nascimento > 18
		if((DateTime.Now.Year - intAno) < 18) {
			Console.WriteLine("Você é menor de idade");
		} else {
			if(DateTime.Now.Month < intMes) {
				Console.WriteLine("Você é menor de idade");
			} else {
				if(DateTime.Now.Month > intMes) {
						Console.WriteLine("Você é maior de idade");	
				} else {
				     if(DateTime.Now.Day < intDia) {
						 Console.WriteLine("Você é menor de idade");
					 } else {
						 Console.WriteLine("Você é maior de idade");	
					 }
				}
			}
		}
	}
}