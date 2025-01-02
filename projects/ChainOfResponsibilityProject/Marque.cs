using System;

public class Marque : ObjetBase
{
    private string description;

    public Marque(string description, string descriptionParDefaut)
        : base(descriptionParDefaut)
    {
        this.description = description;
    }

    protected override string GetDescription()
    {
        return description;
    }
}