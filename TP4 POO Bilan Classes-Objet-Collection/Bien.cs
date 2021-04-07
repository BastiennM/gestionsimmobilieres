using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_POO_Bilan_Classes_Objet_Collection
{
    public class Bien
    {
        #region propriétés
        private string adresse, ville;
        private bool etatVente;
        private int surface, nbPieces, nbChambres, nbSallesEau, prix, prixVente;
        private int typeBien; // 2 valeurs possibles : 1 pour appart, 2 pour maison
        #endregion

        #region accesseurs
        // A COMPLETER : accesseurs de adresse
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public int Surface { get => surface; set { if (value >= 0) surface = value; } }
        public int NbPieces { get => nbPieces; set { if (value >= 0) nbPieces = value; } }
        public int NbChambres { get => nbChambres; set { if (value >= 0 && value <= nbPieces) nbChambres = value; } }
        // A COMPLETER : accesseurs de nbSallesEau
        public int NbSallesEau { get => nbSallesEau; set { if (value >= 0 && value <= nbPieces) nbSallesEau = value; } }
        // A COMPLETER : accesseurs de prix
        public int Prix { get => prix; set { if (value >= 0) prix = value; } }
        public int TypeBien { get => typeBien; set { if (value == 1 || value == 2) typeBien = value; } }
        public bool EtatVente { get => etatVente; set => etatVente = value; }
        public int PrixVente { get => prixVente; set { if (value >= 0) prixVente = value; } }

        #endregion


        #region constructeur
        /// <summary>
        /// Constructeur de la classe BIEN
        /// </summary>
        /// <param name="unType">entier pour le type du bien</param>
        /// <param name="uneVille">ville du bien</param>
        /// <param name="uneSurface">surface en m2 du bien</param>
        /// <param name="nbP">nb de pièces total du bien</param>
        /// <param name="unPrix">prix à la vente</param>
        public Bien(int unType, string uneVille, int uneSurface, int nbP, int unPrix)
        {
            typeBien = unType;
            ville = uneVille;
            surface = uneSurface;
            nbPieces = nbP;
            prix = unPrix;

        }

        public Bien(int unType, string uneVille, int uneSurface, int nbP, int unPrix, int nbC, int nbS, string uneAdresse, bool unEtatVente)
        {
            typeBien = unType;
            ville = uneVille;
            surface = uneSurface;
            nbPieces = nbP;
            prix = unPrix;
            adresse = uneAdresse;
            NbSallesEau = nbS;
            nbChambres = nbC;
            etatVente = unEtatVente;
        }

        public Bien(int unType, string uneVille, string uneAdresse, int uneSurface, int nbP, int nbC, int nbS, int unPrix, bool unEtatVente, int unPrixVenteF)
        {
            typeBien = unType;
            ville = uneVille;
            surface = uneSurface;
            nbPieces = nbP;
            prix = unPrix;
            adresse = uneAdresse;
            NbSallesEau = nbS;
            nbChambres = nbC;
            prixVente = unPrixVenteF;
            etatVente = unEtatVente;
        }

        public Bien(int unType, string uneVille, string uneAdresse, int uneSurface, int nbP, int nbC, int nbS, int unPrix)
        {
            typeBien = unType;
            ville = uneVille;
            surface = uneSurface;
            nbPieces = nbP;
            prix = unPrix;
            adresse = uneAdresse;
            NbSallesEau = nbS;
            nbChambres = nbC;
        }

        #endregion

        #region méthodes
        /// <summary>
        /// Méthode qui retourne une chaine avec les informations indispensables sur le bien
        /// </summary>
        /// <returns>chaine de caractère</returns>
        public string Afficher()
        {
            return (RetourneTypeBien() + " situé(e) à " + ville + "\nd'une surface de " + surface + "m2\nde " + nbPieces + " pièces\nPrix : " + Prix + " €");
        }

        /// <summary>
        /// Méthode qui retourne une chaine relative au type de bien : 1 : Appartement 2 : Maison
        /// </summary>
        /// <returns>chaine de caractères</returns>
        public string RetourneTypeBien()
        {
            if (typeBien == 1)
            {
                return "Appartement";
            }
            else
            {
                return "Maison";
            }
        }
        public string EtatdeVente()
        {
            if (etatVente == false)
            {
                return "Le bien n'est pas vendu";
            }
            else
            {
                return "le bien est vendu";
            }
        }


        #endregion

    }
}
