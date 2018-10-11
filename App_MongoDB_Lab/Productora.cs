using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;



namespace App_MongoDB_Lab
{
    class Productora
    {
        public ObjectId id { get; set; }
        public string nombre { get; set; }
        public int anho { get; set; }
        public string sitioWeb { get; set; }

        public Productora() { }

        public Productora(string nombre, int anho, string sitioWeb)
        {
            this.nombre = nombre;
            this.anho = anho;
            this.sitioWeb = sitioWeb;
        }

        public Productora(ObjectId id, string nombre, int anho, string sitioWeb)
        {
            this.id = id;
            this.nombre = nombre;
            this.anho = anho;
            this.sitioWeb = sitioWeb;
        }
    }
}