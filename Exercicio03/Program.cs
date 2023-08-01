Console.WriteLine("Exercício 03\n");
/*Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo
novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na
tela.*/

try
{
    //caminho do arquivo
    string caminhoOrigem = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\Exercicio03\txt\texto.txt";

    //criar arquivo
    Console.WriteLine("Criando arquivo\n");
    using FileStream fs = new FileStream(caminhoOrigem, FileMode.Create, FileAccess.Write);
    
    //escrever no arquivo primeria parte
    Console.WriteLine("Escrevendo parte 1\n");
    using StreamWriter sw = new StreamWriter(caminhoOrigem, true);
    sw.WriteLine("Batatinha quando nasce, espalha rama pelo chão...");

    //escrever no arquivo segunda parte
    Console.WriteLine("Escrevendo parte 2\n");
    using StreamWriter sw2 = new StreamWriter(caminhoOrigem, true);
    sw2.WriteLine("Quando estudo C#, eu fico felizão!");

    //exibição de conteúdo no tela
    Console.WriteLine("Escrevendo parte 2\n");
    using StreamReader sr = new StreamReader(caminhoOrigem);

    string? linha;
    while((linha = sr.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }

}

catch (IOException ex)
{
    Console.WriteLine($"Erro IOException: {ex.Message}\n");
}

catch (Exception ex)
{

    Console.WriteLine($"Erro Exception: {ex.Message}");
}

finally
{
    Console.WriteLine("\nFim da execução...");
}



Console.ReadKey();