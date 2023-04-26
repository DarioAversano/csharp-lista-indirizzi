using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        // ATTRIBUTI / CARATTESTICHE
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private int zip;

        // STATI

        // COSTRUTTORE
        public Indirizzo(string name, string surname, string street, string city, string province, int zip)
        {

            if ((name == "") || (surname == "") || (street == ""))
            {
                throw new Exception("Inserisci un input");
            }

            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        // GETTERS
        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetProvince()
        {
            return this.province;
        }

        public int GetZip()
        {
            return this.zip;
        }

        // SETTERS

        // METODI




        // Metodo ToString() per la stampa dell'indirizzo
        public override string ToString()
        {
            string stringToWrite;
            stringToWrite = "----------INDIRIZZO----------- \n";
            stringToWrite += $"\t Name: {this.name} \n";
            stringToWrite += $"\t Surname: {this.surname} \n";
            stringToWrite += $"\t Street: {this.street} \n";
            stringToWrite += $"\t City: {this.city} \n";
            stringToWrite += $"\t Province: {this.province} \n";
            stringToWrite += $"\t Zip: {this.zip} \n";
            stringToWrite += "-------------------------------------------";

            return stringToWrite;



        }
    }
}


