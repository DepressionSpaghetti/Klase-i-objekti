using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciranje objekta
            Osoba osoba = new Osoba();

            //povezivanje set metoda
            osoba.SetIme("Pero");
            osoba.SetPrezime("Peric");
            osoba.SetGodinaRodjenja(2005);
            osoba.SetVisina(179);
            osoba.SetTezina(80);
            osoba.SetSpol('M');

            Console.WriteLine("Ime i prezime: " + osoba.GetIme() + " " + osoba.GetPrezime()
                + "\r\nGodina rodjenja: " + osoba.GetGodinaRodjenja()
                + "\r\nVisina: " + osoba.GetVisina()
                + "\r\nTezina: " + osoba.GetTezina()
                + "\r\nSpol: " + osoba.GetSpol());

            //instanciranje objekta 2
            Osoba osoba2 = new Osoba("Ana", "Anic", 2001, 164, 62, 'Z');

            Console.WriteLine("\r\nOsoba 2");
            Console.WriteLine(osoba2.ispis());

            Console.WriteLine(osoba.ispis());

            Console.WriteLine("\r\nOsoba 2 - override");
            Console.WriteLine(osoba2.ToString());

            Console.ReadKey();
        }

        class Osoba
        {
            string ime, prezime;
            int godinaRodjenja, visina, tezina;
            char spol;

            //metode za ispis
            public string ispis()
            {
                string ispis = "Ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rodjenja: " + this.GetGodinaRodjenja()
                + "\r\nVisina: " + this.GetVisina()
                + "\r\nTezina: " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();

                return ispis;
            }

            public override string ToString()
            {
                string ispis = "Ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rodjenja: " + this.GetGodinaRodjenja()
                + "\r\nVisina: " + this.GetVisina()
                + "\r\nTezina: " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();

                return ispis;
            }



            //set metode - sluzbe za postavljanje vrijednosti
            #region set metode
            public void SetIme(string ime)
            {
                this.ime = ime;
            }
            public void SetPrezime(string prezime)
            {
                this.prezime = prezime;
            }
            public void SetGodinaRodjenja(int godinaRodjenja)
            {
                this.godinaRodjenja = godinaRodjenja;
            }
            public void SetVisina(int visina)
            {
                this.visina = visina;
            }
            public void SetTezina(int tezina)
            {
                this.tezina = tezina;
            }
            public void SetSpol(char spol)
            {
                this.spol = spol;
            }
            #endregion

            //set metode - sluzbe za citanje vrijednosti svojstava
            #region get metode
            public string GetIme()
            {
                return this.ime;
            }
            public string GetPrezime()
            {
                return this.prezime;
            }
            public int GetGodinaRodjenja()
            {
                return this.godinaRodjenja;
            }
            public int GetVisina()
            {
                return this.visina;
            }
            public int GetTezina()
            {
                return this.tezina;
            }
            public char GetSpol()
            {
                return this.spol;
            }
            #endregion

            //konstruktori
            public Osoba()
            {

            }

            public Osoba(string ime, string prezime, int godinaRodjenja, int visina, int tezina, char spol)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.godinaRodjenja = godinaRodjenja;
                this.visina = visina;
                this.tezina = tezina;
                this.spol = spol;
            }
        }
    }
}
