using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    LiasseVierge liasseVierge = LiasseVierge.Instance();
    liasseVierge.ajoute(new AssuranceAutomobile());
    liasseVierge.ajoute(new AssuranceHabitation());
    liasseVierge.ajoute(new AssuranceVie());
    // création d'une nouvelle liasse pour deux clients
    LiasseClient liasseClient1 = new LiasseClient(
      "Adrien","1000");
    LiasseClient liasseClient2 = new LiasseClient(
      "Remy","2000");
    liasseClient1.affiche();
    liasseClient2.affiche();
  }
}
