// See https://aka.ms/new-console-template for more information
using Criptografie;

Cifer Cifer = new Cifer(3);
string test = "Ana";
test= Cifer.Encrypt(test);
Console.WriteLine(test);
Console.ReadKey();
    