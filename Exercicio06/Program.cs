Console.WriteLine("Exercício 06\n");

/*Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a
classe Path.*/

string caminho = @"C:\Temp\NVRTXVoice";
Console.WriteLine($"Listagem do diretório.");

string[] arquivos = Directory.GetFiles(caminho);
foreach (string arquivo in arquivos)
{
    Console.WriteLine(Path.GetFileName(arquivo));
}

Console.ReadKey();