using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
   
    static class Kontrole
    {
        public static int brzm;
        public static int mrtvi_zmajevi;
        public static Form1 glavna_forma;
        public static Igrac glavni_igrac;
        



        public static void Ubijenizmaj()
        {
            mrtvi_zmajevi++;
            if (mrtvi_zmajevi >= brzm)
            {
                glavna_forma.Omogucisledecinivo();
            }
        }
        

        
        }
    }

