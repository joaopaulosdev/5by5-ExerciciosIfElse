Console.WriteLine("-- PROGRAMA DE CLASSIFICAÇÃO DE FAIXA ETÁRIA --\n");

//DECLARAÇÃO E INPUT
int idade;

Console.Write("Insira sua idade (em anos): ");
idade = int.Parse(Console.ReadLine());

//LÓGICA E OUTPUT
if(idade <= 12)
{
    Console.WriteLine("Vocé é uma CRIANÇA!");
}else if(idade >= 13 && idade <= 17)
{
    Console.WriteLine("Vocé é um ADOLESCENTE!");
}else if(idade >= 18 && idade <= 59)
{
    Console.WriteLine("Vocé é um ADULTO!");
}
else
{
    Console.WriteLine("Vocé é um(a) IDOSO(A)!");
}

Console.Write("\nAPLICAÇÃO ENCERRADA!\n");