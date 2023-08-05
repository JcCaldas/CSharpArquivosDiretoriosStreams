Console.WriteLine("Exercício 10\n");
/*Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File
e a classe Path*/

string caminhoOrigem = @"C:\Temp\novo\mover.txt";
string caminhoDestino = @"C:\Temp\novo2\";

string arquivo = Path.GetFileName(caminhoOrigem);

caminhoDestino = Path.Combine(caminhoDestino, arquivo);

File.Move(caminhoOrigem, caminhoDestino);


Console.ReadKey();