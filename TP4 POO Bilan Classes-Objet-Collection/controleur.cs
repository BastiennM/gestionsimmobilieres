using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public static class controleur
    {
        #region propriétés
        private static Modele vmodele;
        #endregion
        #region methodes
        public static void init()
        {
            vmodele = new Modele();
        }
        #endregion
        #region accesseurs
        public static Modele Vmodele { get => vmodele; set => vmodele = value; }
        #endregion
    }
}
