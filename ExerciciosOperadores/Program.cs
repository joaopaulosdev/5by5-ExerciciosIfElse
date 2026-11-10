//APRESENTAÇÃO

Console.WriteLine("- PROGRAMA DE VERIFICAÇÃO DE PAR OU ÍMPAR -");
Console.Write("Escreva um número inteiro: ");

//DECLARAÇÃO E INPUT
int num = int.Parse(Console.ReadLine());

//PROCESSAMENTO E RESULTADO
if (num % 2 == 0)
{
    Console.WriteLine("O número " + num + " é PAR!");
}
else
{
    Console.WriteLine("O número " + num + " é ÍMPAR!");
}

Console.WriteLine("APLICAÇÃO FINALIZADA!");