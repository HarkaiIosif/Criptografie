// See https://aka.ms/new-console-template for more information
using Criptografie;
MonalfabeticCifer mono = new MonalfabeticCifer();
string test = "The Black Templars are a Loyalist Second Founding Space Marine Chapter derived from the Imperial Fists' gene-seed and their primarch, Rogal Dorn. Their origin can be traced back to the Imperial Fists' defence of Terra during the Horus Heresy.Since that time, the Black Templars have been on the longest Imperial Crusade the Imperium of Man has ever known to prove their loyalty to the Emperor of Mankind. They are not a Codex Astartes-compliant Chapter and maintain a very different Chapter structure and culture than is the norm amongst most of the Adeptus Astartes.\r\n\r\nThey are also deeply unusual amongst the forces of the Adeptus Astartes for venerating the Master of Mankind as a literal god, just like the mortal adherents of the Imperial Cult.\r\n\r\nAfter the Horus Heresy, Rogal Dorn, primarch of the Imperial Fists, resisted the break-up of the Space Marine Legions into smaller Chapters. It was only when the Imperial Fists were almost branded Heretics that Dorn relented, allowing his beloved Legion to be subdivided into Chapters. One of the new Chapters born of this time was the Black Templars.";
Console.WriteLine(test);
test =mono.Encrypt(test);
Console.WriteLine(test);
test=mono.Analasys(test);
Console.WriteLine(test);
Console.ReadKey();
    