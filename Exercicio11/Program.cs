Console.WriteLine("Exercício 11\n");
/*Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a
classe DirectoryInfo e a classe Path.*/

try
{
    string caminho = @"C:\Temp\novo";
    var caminhoOrigem = new DirectoryInfo(caminho);

    foreach (var subdir in caminhoOrigem.GetFiles("*", SearchOption.AllDirectories))
    {
        Console.WriteLine(subdir.FullName);
    }

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); ;
}


Console.ReadKey();