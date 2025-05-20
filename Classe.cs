using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    internal class Classe
    {
        public String nomClasse;
        public List<Eleve> eleves = new List<Eleve>();
        public List<String> matieres = new List<String>();

        public Classe(String nc)
        {
            nomClasse = nc;
        }

        public void ajouterEleve(String prenom, String nom)
        {
            Eleve eleve = new Eleve(prenom, nom);
            eleves.Add(eleve);
        }
        public void ajouterMatiere(String nom)
        { 
            matieres.Add(nom);
        }
        public float moyenneMatiere(int matiere)
        {
            float moyenne = 0f;
            for (int i = 0; i < eleves.Count; i++)
            {
                moyenne += eleves[i].moyenneMatiere(matiere);
            }
            return (float)Math.Truncate((moyenne /eleves.Count)*100)/100;
        }
        public float moyenneGeneral()
        {
            float moyenne = 0f;
            for (int i = 0;i < matieres.Count; i++)
            {
                moyenne += moyenneMatiere(i);
            }
            return (float)Math.Truncate((moyenne / matieres.Count) * 100) / 100;
        }
    }
}
