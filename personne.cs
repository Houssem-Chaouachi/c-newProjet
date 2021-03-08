using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    public class personne
    {
       private string nom;
       private string prenom;
       private int age;
        
      public personne(string nom, string prenom, int age)
      {
        this.nom = nom;
        this.prenom = prenom;
        this.age = age + 1;
        
   
      }

      public object infoss()
      {
        return nom + " "  + " " + prenom + "  " +  (age + 1) ;

      }
        
    }
}