// See https://aka.ms/new-console-template for more information

double soma = 0;
int totalNotas = 4;


for (int i = 1; i <= totalNotas; i++)
{
    double nota;

    
    while (true)
    {
        Console.Write($"Digite a nota {i} em % (0 a 100): ");
        nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 0 && nota <= 100) break; 
        else Console.WriteLine(" Nota inválida! Digite novamente.");
    }

    soma += nota; 
}


double media = soma / totalNotas;
Console.WriteLine($"\nMédia final: {media:F1}%");


if (media >= 70)
    Console.WriteLine("Situação: Aprovado ");
else
    Console.WriteLine("Situação: Reprovado ");