using System;
public abstract class ObjetBase
    {
        protected ObjetBase suivant;
        protected string descriptionParDefaut;

        public ObjetBase(string descriptionParDefaut)
        {
            this.descriptionParDefaut = descriptionParDefaut;
        }

        public void DefinirSuivant(ObjetBase suivant)
        {
            this.suivant = suivant;
        }

        protected abstract string GetDescription();

        public string DonnerDescription()
        {
            string resultat = this.GetDescription();
            if (!string.IsNullOrEmpty(resultat))
            {
                return resultat;
            }

            if (suivant != null)
            {
                return suivant.DonnerDescription();
            }

            return this.descriptionParDefaut;
        }
    }
