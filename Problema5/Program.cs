char resposta;
do
{
  Console.WriteLine("Deseja sair? (S/N): ");
  resposta = Console.ReadLine().ToUpper()[0];
}
while (resposta != 'S' || resposta == 'N');
Console.WriteLine("Programa encerrado.");