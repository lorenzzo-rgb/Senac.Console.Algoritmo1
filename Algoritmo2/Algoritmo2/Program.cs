// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

int idade = 10;
string nomeCliente = "Lorenzzo";
decimal preco = 20M;
char letra = 'A';
var nomeCompleto = "Lorenzzo Antonio Patatt";
var altura = 180;

Console.Write("Digite seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem Vindo " + nomeCompleto);
Console.Write("Digite sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada " + idade);
if(idade < 18)
    Console.WriteLine("Voce é novo");

Console.ReadKey();

//1 bytes = 8 bites (sao 8 digitos que ficam na memoria
//ram com regra booleana por exemplo (bool / 1 byte / true e false / 10010010))