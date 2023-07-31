Console.WriteLine("07 Bloco Using\n");

/*Importância do bloco Using:
 Não precisa se preocupar em fechar o arquivo, pois assim que
ele termina a execução do código de dentro do bloco, ele mesmo fecha.*/

string caminhoArquivo = @"C:\Jessé Temp\015 - Udemy\C#\Macoratti\ArquivosDiretoriosStreams\06FileStream\txt\poesia.txt";

try
{
    /* Forma utilizada antes do C#8
    using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read))
    {
        using(StreamReader leitor = new StreamReader(fs))
        {
            string? linha;
            while ((linha = leitor.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    } */

    //Forma utlizada após C#8
    //using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    using StreamReader leitor = File.OpenText(caminhoArquivo);//new StreamReader(fs);
    
    string? linha;
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }


}
catch (IOException ex)
{

    Console.WriteLine(ex.Message);
}





Console.ReadKey();