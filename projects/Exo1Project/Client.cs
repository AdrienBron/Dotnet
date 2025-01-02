using System;

class Client
{
    static void Main(string[] args)
    {
        Console.WriteLine("Voulez êtes particulier (1) ou professionnel (2) :");
        var choix = Console.ReadLine();
        if (choix == "1")
        {
            IBankingDocumentFactory particularFactory = new ParticularBankingDocumentFactory();
            var particularIdentity = particularFactory.CreateBankingIdentity();
            var particularCertificate = particularFactory.CreateBankingCertificate();
            Console.WriteLine(particularIdentity.GenerateIdentity());
            Console.WriteLine(particularCertificate.GenerateCertificate());
        }
        if (choix == "2")
        {
            IBankingDocumentFactory professionalFactory = new ProfessionalBankingDocumentFactory();
            var professionalIdentity = professionalFactory.CreateBankingIdentity();
            var professionalCertificate = professionalFactory.CreateBankingCertificate();
            Console.WriteLine(professionalIdentity.GenerateIdentity());
            Console.WriteLine(professionalCertificate.GenerateCertificate());
        }
    }
}
