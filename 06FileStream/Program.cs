Console.WriteLine("06 FileStream\n");

string caminhoArquivo = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\06FileStream\txt\poesia.txt";

//FileStream fs = null;
StreamReader leitor = null;

try
{
    //cria nova instância, indica o caminho do aquivo, abre e indica o modo de acesso (leitura)
    //fs = new FileStream (caminhoArquivo, FileMode.Open, FileAccess.Read);

    //Para simplificar pode-se utilizar a classe 'File'
    leitor = File.OpenText(caminhoArquivo); //new StreamReader (fs);

    string? linha;
    /*enquanto a variavel leitor estiver utilizando o método
     'ReadLine' para lera a linha, e isso for diferente de 'null'
    continua lendo a linha*/
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine (linha);
    }

}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
finally
{
    //Garantir que os recursos sejam fechados de forma manual
    //if (fs != null) fs.Close();
    if (leitor != null) leitor.Close();
}

Console.ReadKey();