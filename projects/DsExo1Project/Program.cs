using System;

// Interface IRapport
public interface IRapport
{
    string GetContenu();
    string GetAuteur();
}

public class RapportIncident : IRapport
{
    private string contenu;
    private string auteur;

    public RapportIncident(string contenu, string auteur)
    {
        this.contenu = contenu;
        this.auteur = auteur;
    }

    public string GetContenu()
    {
        return contenu;
    }

    public string GetAuteur()
    {
        return auteur;
    }
}

public abstract class RapportDecorator : IRapport
{
    protected IRapport rapport;

    public RapportDecorator(IRapport rapport)
    {
        this.rapport = rapport;
    }

    public virtual string GetContenu()
    {
        return rapport.GetContenu();
    }

    public virtual string GetAuteur()
    {
        return rapport.GetAuteur();
    }
}

public class RapportAnonyme : RapportDecorator
{
    public RapportAnonyme(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        return rapport.GetContenu().Replace("identifiant", "***").Replace("password", "***");
    }

    public override string GetAuteur()
    {
        return "ANONYME";
    }
}

public class RapportChiffre : RapportDecorator
{
    public RapportChiffre(IRapport rapport) : base(rapport) { }

    public override string GetContenu()
    {
        var contenu = rapport.GetContenu();
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(contenu));
    }
}

class Program
{
    static void Main(string[] args)
    {
        IRapport rapport = new RapportIncident(
            "Intrusion détectée. identifiant: admin, password: 123456",
            "John Doe"
        );



        Console.WriteLine($"Auteur : {rapport.GetAuteur()}");
        Console.WriteLine($"Contenu : {rapport.GetContenu()}");
    }
}
