using System;

public class DocumentPdf : Document
{
  private var contenu;
  protected ComposantPdf outilPdf = new ComposantPdf();

  public setContenu(var contenu)
  {
    this.contenu = contenu;
    return this.outilPdf.pdfFixeContenu(contenu);
  }
  public void dessine()
  {
    this.outilPdf.pdfPrépareAffichage();
    this.outilPdf.pdfEnvoieRafraîchit();
    this.outilPdf.pdfEnvoieTermineAffichage();
  }
  public void imprime()
  {
    this.outilPdf.pdfEnvoieImprimante();
  }
}
