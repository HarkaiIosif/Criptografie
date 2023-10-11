// See https://aka.ms/new-console-template for more information
using Criptografie;
//Cifer, CeaserCifer si MonoalfabeticCifer
MonalfabeticCifer monoalpha = new MonalfabeticCifer();
string test = Console.ReadLine();
test =monoalpha.Encrypt(test);
Console.WriteLine(test);
test = monoalpha.Analasys(test);
Console.WriteLine(test);
Console.ReadKey();
    