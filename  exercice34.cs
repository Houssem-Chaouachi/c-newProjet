using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    public class  exercice34
    {
       
        struct notreTableau
        {
            public int index;
            public int cases;
        }
        public exercice34( )
        {
            Console.WriteLine("saisir le nombre de cases");
           int nb = int.Parse(Console.ReadLine());
Console.WriteLine("le nombre de cases est de : " +  nb);

notreTableau [] tab = new notreTableau[nb];
for (int i = 0; i < nb ; i++)
{
    Console.WriteLine("remplir la cases n°" + (i+1));
       tab[i].cases = int.Parse( Console.ReadLine());

       notreTableau [] finalTab = new notreTableau[nb];
       for (int j = 0; j <= i; j++)
       {
           if(tab[i].cases < tab[j].cases)
           {
               tab[j-1].cases = tab[i].cases;
           }
           else  if(tab[i].cases > tab[j].cases)
           {
               tab[j+1].cases = tab[i].cases;
           }
       }

}
for (int i = 0; i < nb ; i++)
{
    tab[i].index = i  + 1 ;
    Console.WriteLine("index : " + tab[i].index + " case : "  + tab[i].cases);
     

}
{
    
}

        }
    }
}