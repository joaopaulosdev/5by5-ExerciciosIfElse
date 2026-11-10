Console.WriteLine("-- PROGRAMA DE CLASSIFICAÇÃO DE TRIÂNGULO --\n");

//DECLARAÇÃO E INPUT
int lado1, lado2, lado3;

Console.WriteLine("Insira os valores para os lados do Triângulo: ");

Console.Write("Lado 1: ");
lado1 = int.Parse(Console.ReadLine());

Console.Write("Lado 2: ");
lado2 = int.Parse(Console.ReadLine());

Console.Write("Lado 3: ");
lado3 = int.Parse(Console.ReadLine());

//VALIDAÇÃO
Console.WriteLine("\nLados: " +  lado1 + " | " + lado2 + " | " + lado3);

if(lado1 > 0 && lado2 > 0 && lado3 > 0 &&
   lado1 + lado2 > lado3 &&
   lado2 + lado3 > lado1 &&
   lado3 + lado1 > lado2)
{
    Console.WriteLine("Triângulo válido!");
}
else
{
    Console.WriteLine("Triângulo é inválido! \nOs valores inseridos não formam um triângulo.");
    return;
}

Console.WriteLine("\nAnalisando...\n");
//CLASSIFICAÇÃO

if(lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é EQUILÁTERO!");
}else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é ISÓSCELES!");
}
else
{
    Console.WriteLine("O triângulo é ESCALENO!");
}


Console.Write("\nAPLICAÇÃO ENCERRADA!\n");