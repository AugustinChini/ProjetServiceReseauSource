﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        private List<Livre> booksListe;
        private List<Emprunt> empruntListe;
        private List<Emprunteur> emprunteurListe;
        private List<Auteur> auteursListe;

        public DalManager ()
        {
            booksListe = new List<Livre>();
            empruntListe = new List<Emprunt>();
            emprunteurListe = new List<Emprunteur>();
            auteursListe = new List<Auteur>();

            string[] title = new string[10] {
            
            "Labyrinthe de Pharaon",

            "Labyrinthe des sentiments",

           " Lac ",
	
            "lac aux sortilèges",

            "lac de glace",
	
            "Lâcher prise",
	
            "Lâchons les chiens",
	
            "Lady Cartier",

            "Lady Day" ,
	
            "Lady Doll",
            };

            for(int i = 0; i < 10; ++i)
            {
                Livre newLivre = new Livre();
                newLivre.Titre = title[i];
                booksListe.Add(newLivre);
            }

            Emprunteur emprunteur1 = new Emprunteur(1,"25/12/1986","Lolita","Michel",ESexe.Masculin,"place 19 juin", "jdfhwdjfh@gmail.com", "0471201739");
            Emprunteur emprunteur2 = new Emprunteur(2,"08/03/1987","Plouc","Daniel",ESexe.Masculin,"place 10 juillet","dfjhdf@hotmail.fr","0471201234");
            Emprunteur emprunteur3 = new Emprunteur(3,"15/08/1990","Chocolat","Bernadette",ESexe.Feminin,"Bd 1 mai","fsdjhdf@orange.fr","0471206789");

            Emprunt emprunt1 = new Emprunt(11,"08/01/2015", "08/02/2015", emprunteur1, booksListe[0]);
            Emprunt emprunt2 = new Emprunt(12,"05/01/2015", "05/02/2015", emprunteur1, booksListe[0]);
            Emprunt emprunt3 = new Emprunt(13,"10/01/2015", "10/02/2015", emprunteur1, booksListe[0]);

            Auteur aut1 = new Auteur(21,"15/05/1900","Po","Bernard",ESexe.Masculin,"15/05/1935", true);
            Auteur aut2 = new Auteur(22,"23/04/1990","Candy","Sacha",ESexe.Indetermine,null, false);
            Auteur aut3 = new Auteur(23,"06/09/1911","Pomfresh","Amanda",ESexe.Feminin,"13/05/1937", true);

            emprunteurListe.Add(emprunteur1);
            emprunteurListe.Add(emprunteur2);
            emprunteurListe.Add(emprunteur3);

            empruntListe.Add(emprunt1);
            empruntListe.Add(emprunt2);
            empruntListe.Add(emprunt3);

            auteursListe.Add(aut1);
            auteursListe.Add(aut2);
            auteursListe.Add(aut3);

        }
           
        public List<Livre> getAllBooks()
        {
            return booksListe;
        }

        public List<Emprunteur> getAllEmprunteurs()
        {
            return emprunteurListe;
        }

        public List<Emprunt> getAllEmprunts()
        {
            return empruntListe;
        }

        public List<Auteur> getAllAuteurs()
        {
            return auteursListe;
        }
    }
}
