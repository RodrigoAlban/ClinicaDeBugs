using System.Globalization;
using System.Threading;

// Define a cultura padrão para pt-BR
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

Console.WriteLine("Por favor, digite seu primeiro nome:");
string primeiroNome = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Agora, digite sua idade:");
int idade = int.Parse(Console.ReadLine()!);
Console.WriteLine("Por fim, digite sua altura em metros (ex: 1,80):");
float altura = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Resumo do Cadastro: Nome: {primeiroNome}, Idade: {idade} anos, Altura: {altura}m.");