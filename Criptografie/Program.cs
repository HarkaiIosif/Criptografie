// See https://aka.ms/new-console-template for more information
using Criptografie;

Cifer Cifer = new Cifer(3);
string test = "Ana are mere";
test= Cifer.Encrypt(test);
Console.WriteLine(test);
//Cifer.Analasys(test);
//test = Cifer.Decrypt(test);
//Console.WriteLine(test);
MonalfabeticCifer mono = new MonalfabeticCifer();
test = "Ana are mere";
test =mono.Encrypt(test);
Console.WriteLine(test);
test=mono.Decrypt(test);
Console.WriteLine(test);
Console.ReadKey();
    