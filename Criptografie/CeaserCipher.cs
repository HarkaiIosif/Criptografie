using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie
{
    internal class CeaserCipher:Cipher
    {
        public CeaserCipher():base(3) 
        {

        }
        public override void Analasys(string imputmessage)
        {
            Console.WriteLine(Decrypt(imputmessage, 3));
        }
    }
}
