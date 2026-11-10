Console.WriteLine("-- PROGRAMA DE COMPARAÇÃO DE DECIMAIS --\n");

float num1, num2;

Console.WriteLine("Insira 2 números decimais: ");

Console.Write("Primeiro Número: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Segundo número: ");
num2 = float.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Os números são iguais!");
}
else if (num1 > num2)
{
    Console.WriteLine("O número " + num1 + " é maior que: " + num2 + "!");
}
else
{
    Console.WriteLine("O número " + num1 + " é menor que: " + num2 + "!");
}


Console.Write("\n-- APLICAÇÃO FINALIZADA! -- \n");