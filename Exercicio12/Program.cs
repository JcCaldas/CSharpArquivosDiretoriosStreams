Console.WriteLine("Exercício 12\n");
/*Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a
classe DirectoryInfo e a classe Path.*/

try
{
    string caminho = @"C:\Temp\novo";
    string arquivo = "arquivo.txt";
    string caminhoCompleto = Path.Combine(caminho, arquivo);
    string caminho2 = @"C:\Temp\novo\novo";

    // Exclui o arquivo
    File.Delete(caminhoCompleto);
    // Exclui o diretório
    Directory.Delete(caminho2, true);




}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); ;
}

Console.ReadKey();