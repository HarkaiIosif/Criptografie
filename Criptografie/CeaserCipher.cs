using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie
{
    internal class CeaserCifer:Cipher
    {
        public CeaserCifer():base(3) 
        {

        }
        public override void Analasys(string imputmessage)
        {
            Console.WriteLine(Decrypt(imputmessage, 3));
        }
    }
}
