﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi+" sepete eklendi."); 
            Console.WriteLine(urun.StokAdedi+ " adet stokta var"); 

        }

        
    }
}
