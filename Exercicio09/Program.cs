Console.WriteLine("Exercício 09\n");
/*Criar um programa que permita ao usuário copiar um arquivo de um diretório para outro usando a classe File
e a classe Path.*/

string caminhoOrigem = @"C:\Temp\novo\arquivo.txt";
string caminhoDestino = @"C:\Temp\novo2\";
string arquivo = Path.GetFileName(caminhoOrigem);
caminhoDestino = Path.Combine(caminhoDestino, arquivo);

File.Copy(caminhoOrigem, caminhoDestino);



Console.ReadKey();