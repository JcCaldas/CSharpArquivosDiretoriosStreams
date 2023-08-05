Console.WriteLine("Exercicio 07\n");

/*Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe
DirectoryInfo.*/

string caminho = @"C:\Temp\NVRTXVoice";

DirectoryInfo dir = new DirectoryInfo(caminho);
foreach (var diretorios in dir.GetDirectories())
{
    Console.WriteLine(diretorios.Name);
}

Console.ReadKey();