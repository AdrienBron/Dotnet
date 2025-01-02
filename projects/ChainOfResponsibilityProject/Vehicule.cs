using System;

public class Vehicule : ObjetBase
    {
        private string description;

        public Vehicule(string description, string descriptionParDefaut)
            : base(descriptionParDefaut)
        {
            this.description = description;
        }

        protected override string GetDescription()
        {
            return description;
        }
    }
