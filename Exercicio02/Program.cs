Console.WriteLine("Exercício 02\n");
/*Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de
origem e destino devem ser fornecidos pelo usuário.*/


try
{
    Console.WriteLine("Insira o caminho de origem:");
    string caminhoOrigemUsuario = Console.ReadLine();

    if (File.Exists(caminhoOrigemUsuario))
    {
        Console.WriteLine("Insira o caminho de destino:");
        string caminhoDestinoUsuario = Console.ReadLine();

        File.Copy(caminhoOrigemUsuario, caminhoDestinoUsuario);
        Console.WriteLine($"Copiado de: {caminhoOrigemUsuario}\nCopiado para:{caminhoOrigemUsuario}");
    }
    else
    {
        Console.WriteLine("O arquivo não existe.");
    }
}
catch (Exception ex)
{

    Console.WriteLine($"Erro: {ex.Message}");
}




Console.ReadKey();