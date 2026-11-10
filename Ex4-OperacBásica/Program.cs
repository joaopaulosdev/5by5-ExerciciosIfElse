Console.WriteLine("-- PROGRAMA 4 OPERAÇÕES BÁSICAS --");

//CRIAÇÃO DE VARIÁVEIS E INPUT

float num1, num2;

Console.WriteLine("Insira 2 números para as operações matemáticas:\n");

Console.Write("Primeiro Número: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Segundo número: ");
num2 = float.Parse(Console.ReadLine());


//PROCESSAMENTO E OUTPUT

Console.WriteLine("Números digitados: " + num1 + " | " + num2 + "\n");

float soma = num1 + num2;
Console.WriteLine("SOMA: " + soma);

float subtrac = num1 - num2;
Console.WriteLine("SUBTRAÇÃO: " + subtrac);

float multip = num1 * num2;
Console.WriteLine("MULTIPLICAÇÃO: " + multip);

if (num1 == 0|| num2 == 0) {
    Console.WriteLine("DIVISÃO: Não existe divisão por 0!");
}
else {
    float div = num1 / num2;
    Console.WriteLine("DIVISÃO: " +  div);
};