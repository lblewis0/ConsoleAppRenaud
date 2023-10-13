using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRenaud
{
    
    //Acces - type classe = constante - Nom de la classe
    public class Personnage
    {
        //Variables--------------------------------------------------------------------------------------------------------------
        //Données de base
        //(Optionnel dans certains cas) (En quelque sorte écrasé et rendu obsolète par une propriété)
        public string _nom; //Variable: Acces + type + Nom (Identifiant)

        public int _age;

        //Propriétés-------------------------------------------------------------------------------------------------------------
        //Données de base
        //Accès aux variables + actions lorsque la variable est assignée ou récupérée
        //Peut écraser une variable
        //Get et Set = Accesseurs
        public string Nom 
        {
            get
            {
                Console.WriteLine("Get du nom est appelé");
                return _nom;
            }

            set
            {
                Console.WriteLine("Set du nom est appelé");
                _nom = value;
            }
        }

        //Déclaration de base d'une propriété sans allouer d'actions lorsque la variable est assignée ou récupérée
        //Si comme déclarer comme cela, ca revient au même que de déclarer une variable
        //Et donc la variable devient obsolète et on a besoin d'écrire que la propriété
        public string Sexe { get; set; }

        public int PV { get; set; }

        public int PA { get; set; }

        //Constructeur-----------------------------------------------------------------------------------------------------------
        public Personnage(string nom, int age, string sexe)
        {
            Console.WriteLine("Classe Personnage est instanciée");
            Nom = nom;
            _age = age;
            Sexe = sexe;
            PV = 100;
            PA = 5;
        }

        //Méthode----------------------------------------------------------------------------------------------------------------
        //Methode qui ne renvoit rien -> void
        public  void Attaque(Personnage adversaire)
        {
            adversaire.PV -= PA;
        }

        //Methode qui renvoit un int
        public int GetPV()
        {
            return PV;
        }


    }
}
