Console.WriteLine("-- PROGRAMA DE VERIFICAÇÃO DE ANO BISSEXTO --\n");

//DECLARAÇÃO E INPUT
int ano;

Console.Write("Insira um ano: ");
ano = int.Parse(Console.ReadLine());

//LÓGICA E OUTPUT

if (ano == 0) {
    Console.WriteLine("O ano digitado é INVÁLIDO!");
}
else if (ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)
{
    Console.WriteLine("O ano É BISSEXTO");
}
else
{
    Console.WriteLine("O ano NÃO É BISSEXTO");
}

Console.Write("\nAPLICAÇÃO ENCERRADA!\n");