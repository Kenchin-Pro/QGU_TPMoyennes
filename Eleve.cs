using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPmoyennes
{
    internal class Eleve
    {
        public String prenom { get; private set; }
        public String nom { get; private set; }
        public List<Note> notes = new List<Note>();

        public Eleve(String p, String n)
        {
            prenom = p;
            nom = n;
        }
        public void ajouterNote(Note note)
        {
            notes.Add(note);
        }
        public float moyenneMatiere(int numMatiere)
        {
            float c = 0f;
            float moyenne = 0f;
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].matiere == numMatiere)
                {
                    moyenne += notes[i].note;
                    c++;
                }
            }
            moyenne = moyenne / c;
            return (float)Math.Truncate(moyenne*100)/100;
        }
        public float moyenneGeneral()
        {
            float c = 0f;
            float moyenne = 0f;
            List<int> matiere = new List<int>();
            for (int i = 0; i < notes.Count; i++)
            {
                if (!matiere.Contains(notes[i].matiere))
                {
                    moyenne += moyenneMatiere(notes[i].matiere);
                    matiere.Add(notes[i].matiere);
                    c++;
                }
            }
            return (float)Math.Truncate((moyenne/c)*100)/100;
        }
    }
}
