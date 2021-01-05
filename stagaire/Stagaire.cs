using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace stagaire
{
    [Serializable]
    public class Stagaire
    {
        private int num;
        private string groupe;
        private string prenom;
        private string nom;
        public int Num
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public string Groupe
        {
            get { return this.groupe; }
            set { this.groupe = value; }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public Stagaire()
        { }
        public Stagaire(int num,string groupe,string prenom,string nom)
        {
            this.num = num;
            this.groupe = groupe;
            this.prenom = prenom;
            this.nom = nom;
        }
    }
}
