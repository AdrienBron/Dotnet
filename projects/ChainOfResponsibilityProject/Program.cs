using System;

public class Utilisateur
{
    static void Main(string[] args)
    {
        // Création des objets de la chaîne
        Marque marque = new Marque("Toyota", "Description par défaut pour la marque");
        Modele modele = new Modele(null, "Description par défaut pour le modèle");
        Vehicule vehicule = new Vehicule(null, "Description par défaut pour le véhicule");

        // Construction de la chaîne
        vehicule.DefinirSuivant(modele);
        modele.DefinirSuivant(marque);

        // Utilisateur demande une description
        Console.WriteLine("Description obtenue : " + vehicule.DonnerDescription());
    }

}