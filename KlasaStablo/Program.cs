using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaStablo
{
    /*Definirajte klasu Stablo sa sljedećim članicama:
    varijabla tipa bool otpadajuListovi
    varijabla tipa string vrstaStabla
    svojstvo OtpadajuListovi (get() i set())
    konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli otpadajuListovi
    override metode ToString()
    Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost false. 
    Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite vrijednost true.
    Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je vrijednost varijable otpadajuListovi true, 
    vrijednost varijable vrstaStabla je bijelogorično, 
    a ukoliko je vrijednost varijable otpadajuListovi false, 
    vrijednost varijable vrstaStabla je crnogorično.*/
    class Stablo
    {
        //svojstva
        bool otpadajuListovi;
        string vrstaStabla;

        public override string ToString()
        {
            return "Stablo je:" + this.vrstaStabla;
        }

        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
            if (otpadajuListovi)
            {
                this.vrstaStabla = "Bjelogoricno";
            }
            else
            {
                this.vrstaStabla = "Crnogoricno";

            }

        }
        public bool OtpadajuListovi { get => otpadajuListovi; set otpadajuListovi = value; }
        public string VrstaStabla { get => vrstaStabla; set vrstaStabla= value; }
        class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true);
            Stablo stablo2 = new Stablo(false);
                Console.WriteLine("Stablo 1: " + stablo1.ToString());
                Console.WriteLine("Stablo 2: " + stablo2.ToString());
            }

    }

    
    }
    
}
