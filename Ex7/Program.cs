Console.WriteLine("-- PROGRAMA DE CÁLCULO DO IMC --\n");

//DECLARAÇÃO E INPUT
float pesoKg, altura;

Console.Write("Insira seu peso (em Kg): ");
pesoKg = float.Parse(Console.ReadLine());

Console.Write("Insira sua altura (em centímetros): ");
altura = float.Parse(Console.ReadLine());

altura /= 100;
float resultadoIMC = pesoKg / (altura * altura);

Console.WriteLine("Seu IMC é: " + resultadoIMC);

Console.Write("- CLASSIFICAÇÃO: ");
if(resultadoIMC < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if(resultadoIMC < 25)
{
    Console.WriteLine("Peso normal");
}
else if (resultadoIMC < 30)
{
    Console.WriteLine("Sobrepeso");
}
else if (resultadoIMC < 35)
{
    Console.WriteLine("Obesidade grau I");
}
else if (resultadoIMC < 40)
{
    Console.WriteLine("Obesidade grau II");
}
else 
{
    Console.WriteLine("Obesidade grau III");
}

Console.Write("\nAPLICAÇÃO ENCERRADA!\n");