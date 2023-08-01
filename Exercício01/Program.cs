Console.WriteLine("Exercício 01\n");
/*Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo
existe. Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem
informando que o arquivo não foi encontrado.*/



try
{

    Console.WriteLine("Insira o caminho do arquivo:");
    string? caminho = Console.ReadLine();

    FileInfo caminhoUsuario = new FileInfo(caminho);

    if (caminhoUsuario.Exists)
    {
        Console.WriteLine($"Data de criação: {caminhoUsuario.CreationTime}");
    }
    else
    {
        Console.WriteLine("O arquivo não existe");
    }

}
catch (Exception ex)
{

    Console.WriteLine($"Erro: {ex.Message}");
}

Console.ReadKey();