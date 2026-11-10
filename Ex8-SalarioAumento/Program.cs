Console.WriteLine("-- PROGRAMA PARA CÁLCULO DE PORCENTAGEM DE AUMENTO --\n");

//DECLARAÇÃO E INPUT
float salario;

Console.Write("Insira seu salario (em reais): ");
salario = float.Parse(Console.ReadLine());

//PROCESSAMENTO E OUTPUT
if (salario <= 2000)
{
    salario = salario * 1.15f;
    Console.WriteLine("Aumento de 15%!");
}
else if (salario > 2000 && salario <= 4000)
{
    salario = salario * 1.1f;
    Console.WriteLine("Aumento de 10%!");
}
else{
    salario = salario * 1.05f;
    Console.WriteLine("Aumento de 5%!");
}

Console.WriteLine("O salário após o aumento é: R$ " + salario);

Console.Write("\nAPLICAÇÃO ENCERRADA!\n");