Console.WriteLine("-- CÁLCULO DA MÉDIA DE 4 NOTAS DE ALUNO --\n");

Console.WriteLine("Insira as 4 notas do aluno (0 - 10): ");

float nota1, nota2, nota3, nota4;
Console.Write("Nota 1: ");
nota1 = float.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
nota2 = float.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
nota3 = float.Parse(Console.ReadLine());

Console.Write("Nota 4: ");
nota4 = float.Parse(Console.ReadLine());

float mediaAluno = (nota1 + nota2 + nota3 + nota4)/4;

Console.WriteLine("A média do aluno foi: " + mediaAluno + "!");

if(mediaAluno <= 5)
{
    Console.WriteLine("O aluno está REPROVADO!");
}else if (mediaAluno > 5 && mediaAluno < 7)
{
    Console.WriteLine("O aluno está em RECUPERAÇÃO!");
}
else
{
    Console.WriteLine("O aluno está APROVADO :)!");
};