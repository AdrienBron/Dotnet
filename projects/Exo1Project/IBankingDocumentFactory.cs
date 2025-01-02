using System;

public interface IBankingDocumentFactory
{
    IBankingIdentity CreateBankingIdentity();
    IBankingCertificate CreateBankingCertificate();
}
