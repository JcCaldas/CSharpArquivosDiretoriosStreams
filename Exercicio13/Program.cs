Console.WriteLine("Exercício 13\n");
/*Criar um programa que renomeie um arquivo usando a classe File e a classe Path.*/

string diretorio = @"C:\Temp\novo\novo2";
string arquivo = "arquivo.txt";
string arquivoRenomeado = "arquivoNovo.txt";

string caminhoCompleto = Path.Combine(diretorio, arquivo);
string caminhoCopia = Path.Combine(diretorio, arquivoRenomeado);
File.Copy(caminhoCompleto, caminhoCopia);
File.Delete(caminhoCompleto);





Console.ReadKey();