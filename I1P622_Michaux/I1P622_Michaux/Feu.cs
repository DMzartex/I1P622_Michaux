using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I1P622_Michaux
{
    class Feu
    {
        private string nomFeu;
        private int couleurFeu;
        private string etatFeu;

        public Feu(string nomFeu, int couleurFeu,string etatFeu)
        {
          this.nomFeu = nomFeu;
          this.couleurFeu = couleurFeu;
          this.etatFeu = etatFeu;
        }

        public string afficheFeu()
        {
            if(couleurFeu == 1)
            {
                return "Le feu de signalisation " + nomFeu + " est vert";
            }
            else if (couleurFeu == 0)
            {
                return "Le feu de signalisation " + nomFeu + " est rouge";
            }
            else
            {
                return "Le feu de signalisation " + nomFeu + " est orange"; ;
            }
            
        }

        public void changeFeu()
        {

                if (this.couleurFeu == 1)
                {
                    this.couleurFeu = 2;
                    etatFeu = "allumé";
                   
                }
                else if (this.couleurFeu == 2)
                {
                    this.couleurFeu = 0;
                    etatFeu = "éteint";    
                }
                else
                {
                    this.couleurFeu = 1;
                    etatFeu = "éteint";
                }
        }

        public string afficheEtatFeu()
        {
            return nomFeu + " est " + etatFeu;
        }

    }

}

