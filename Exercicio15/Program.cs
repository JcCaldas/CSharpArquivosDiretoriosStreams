Console.WriteLine("Exercício 15\n");
/*Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe
DirectoryInfo e a classe Path.*/

string diretorio = @"C:\Temp\novo\novo2";

var dir = new DirectoryInfo(diretorio);
DateTime arquivoRecente = DateTime.Now;
string nomeArquivo = "";
foreach (var files in dir.GetFiles())
{
    if (files.CreationTime < arquivoRecente)
    {
        arquivoRecente = files.CreationTimeUtc;
        nomeArquivo = files.Name;
    }

}

Console.WriteLine($"O arquivo mais recente no diretório informado é o {Path.Combine(diretorio, nomeArquivo)}, criado em {arquivoRecente}");

Console.ReadKey();