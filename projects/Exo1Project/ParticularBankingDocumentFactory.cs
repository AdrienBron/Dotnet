using System;

public class ParticularBankingDocumentFactory : IBankingDocumentFactory
{
    public IBankingIdentity CreateBankingIdentity() => new SimplifiedBankingIdentity();
    public IBankingCertificate CreateBankingCertificate() => new StandardBankingCertificate();
}
