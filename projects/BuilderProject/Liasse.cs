using System;

public interface Liasse
{
  LiasseHtml creeAutomobile(string modele, string couleur,
    int puissance, double espace);

  LiassePdf creeScooter(string modele, string couleur, int
    puissance);
}
