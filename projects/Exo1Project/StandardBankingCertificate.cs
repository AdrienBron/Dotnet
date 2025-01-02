using System;


public class StandardBankingCertificate : IBankingCertificate
{
    public string GenerateCertificate() => "Attestation de compte standard pour les particuliers.";
}
