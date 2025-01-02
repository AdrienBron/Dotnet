using System;

public class Modele : ObjetBase
{
    private string description;

    public Modele(string description, string descriptionParDefaut)
        : base(descriptionParDefaut)
    {
        this.description = description;
    }

    protected override string GetDescription()
    {
        return description;
    }
}
