using System;

public class ProfessionalBankingDocumentFactory : IBankingDocumentFactory
{
    public IBankingIdentity CreateBankingIdentity() => new DetailedBankingIdentityWithSIRET();
    public IBankingCertificate CreateBankingCertificate() => new LegalBankingCertificate();
}
