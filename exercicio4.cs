using System;
					
public class Program
{
	public static void Main()
	{
		int numero1 = gerarNumeroRandomico(100);
		int numero2 = gerarNumeroRandomico(100);
		
		String[] operacoes = {"+", "-", "/", "*"};
		
		string operacaoSelecionada = operacoes[gerarNumeroRandomico(4)];
		
		Console.WriteLine("" + numero1, numero2, operacaoSelecionada);
		
		Double resultado = calcular(numero1, numero2, operacaoSelecionada);
		Console.WriteLine("Qual é o resultado de: " + numero1 + " " + operacaoSelecionada + " " + numero2 + " ?");
		string respostaUsuario = Console.ReadLine();
		Double doubleRespostaUsuario = Double.Parse(respostaUsuario);
		
		Console.WriteLine("" + numero1, numero2, operacaoSelecionada);
		if(doubleRespostaUsuario.Equals(resultado)) {
			Console.WriteLine("Parabéns, você acertou");
		} else {
			Console.WriteLine("Vá estudar " + nomeOperacao(operacaoSelecionada));
		}
		
		
	}
	
	public static Double calcular(int v1, int v2, string operacao) {
		switch(operacao){
			case "+":
				return v1 + v2;
			case "-":
				return v1 - v2;
			case "*":
				return v1 * v2;
			case "/":
				return v1 / v2;
			default:
				return 0;
		}
	}
	
	public static String nomeOperacao(string operacao) {
		switch(operacao){
			case "+":
				return "Soma";
			case "-":
				return "Subtração";
			case "*":
				return "Multiplicação";
			case "/":
				return "Divisão";
			default:
				return "Não encontrado";
		}
	}
	
	public static int gerarNumeroRandomico(int max) {
		Random random = new Random();
		return random.Next(0, max);
	}
}