using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace premiers_nombre_entier
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration variable
            double n;
            string saissie;
            double resultat = 0;
            double cpt = 1;

            Console.WriteLine("entrez la valeur n a calculer:");
            saissie = Console.ReadLine();
            n = Convert.ToDouble(saissie);
          

            for (resultat=0,cpt=1 ;cpt <= n; cpt=cpt+1)
            {
                resultat = resultat + cpt;
            }
            Console.WriteLine("Le resultat aver pour est:" + resultat);
            // permet de conserver affichage consol
            Console.ReadLine();
        } 

    }
}
