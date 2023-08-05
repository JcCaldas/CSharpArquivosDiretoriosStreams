Console.WriteLine("Exercício 14\n");
/*Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e
subdiretórios, usando a classe Directory e a classe Path.*/

string diretorio = @"C:\Temp\novo";
long tamanhoTotal = GetDirectoryLength(diretorio);
Console.WriteLine($"Tamanho total é: {tamanhoTotal} bytes");

Console.ReadKey();

static long GetDirectoryLength(string diretorio)
{
    if (!Directory.Exists(diretorio))
    {
        throw new DirectoryNotFoundException("Diretório não encontrado.");
    }
    else
    {
        long tamanhoTotal = 0;
        foreach(string files in Directory.GetFiles(diretorio, "*", SearchOption.AllDirectories))
        {
            FileInfo info = new FileInfo(files);
            tamanhoTotal += info.Length;
        }
        return tamanhoTotal;
    }
}