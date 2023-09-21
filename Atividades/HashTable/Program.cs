using System.Collections;

// Criar HashTable

Hashtable openWith = new Hashtable();

openWith.Add("txt","notepad.exe");
openWith.Add("bmp","paint.exe");
openWith.Add("dib","paint.exe");
openWith.Add("rtf","wordpad.exe");



try
{
openWith.Add("txt","notepad++.exe");
}
catch(ArgumentException aex)
{
    Console.WriteLine("Oops, você tentou adicionar uma paradinha ae.");
    Console.WriteLine($"Detalhes: {aex.Message}");

}

catch(Exception ex)
{
    Console.WriteLine("Erro genérico.");
}

//Acessando o conteúdo da tabela Hash

//Outro jeito de montar string

Console.WriteLine("Na \\ chave = \"rtf\" é {0} ", openWith["rtf"]);

openWith["rtf"] = "WinWord.exe";

Console.WriteLine(
    "Na \\ chave = \"rtf\" é {0}"
    , openWith["rtf"]
);

// TESTAR SE A CHAVE EXISTE NA HASH

if (!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada.");
}

// PERCORRENDO O HASH COM FOREACH 
Console.WriteLine();
foreach(DictionaryEntry de in openWith)
{
    Console.WriteLine("Key = {0} - Value = {1}"
    , de.Key 
    , de.Value
    );
}

// OBTENDO SÓ OS VALORES DO HASH
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("key = {0}", s);
}

//REMOVER REGISTRO DO HASH
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine(
        "Chave \"doc\" foi removida.");
}


Console.WriteLine("Programa ainda em execução.");