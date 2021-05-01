using System;
					
public class Program
{
	public static void Main()
	{
		//Nome do Vendedor
		Console.WriteLine("Nome do Vendedor:");
		string vendedor = Console.ReadLine();
		Console.WriteLine(vendedor);
		
		//Salario do Vendedor
		Console.WriteLine("Salário Fixo:");
		string salario = Console.ReadLine();
		Console.WriteLine(salario);
		decimal salarioFixo = Convert.ToDecimal(salario);
		
		//Valor obtido em vendas
		Console.WriteLine("Informe o valor obtido em vendas no mês:");
		string vendas = Console.ReadLine();
		decimal totalVendas = Convert.ToDecimal(vendas);
		
		//Instancia o método do cálculo do salário
		CalculaSalario calculo = new CalculaSalario();
		decimal salarioFinal = calculo.calculaSalario(salarioFixo, totalVendas);
		
		//Imprime os resultados
		Console.WriteLine($"TOTAL = R$ {salarioFinal} ");
	}
}

class CalculaSalario
{
	public decimal calculaSalario(decimal salario, decimal vendas)
	{
		return salario + vendas + (vendas * Convert.ToDecimal(0.15));
	}
}