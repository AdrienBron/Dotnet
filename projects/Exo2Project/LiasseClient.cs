using System;
using System.Collections.Generic;

public class LiasseClient : Liasse
{
  public LiasseClient(string name, string amounts)
  {
    documents = new List<Document>();
    LiasseVierge laLiasseVierge = LiasseVierge.Instance();
    IList<Document> documentsVierges =
      laLiasseVierge.documents;
    foreach (Document document in documentsVierges)
    {
      Document copieDocument = document.duplique();
      string informations = name + " " + amounts;
      copieDocument.remplit(informations);
      documents.Add(copieDocument);
    }
  }

  public void affiche()
  {
    foreach (Document document in documents)
      document.affiche();
  }
}
