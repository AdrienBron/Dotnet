# ESI 4 - DESIGN PATTERNS EN C#

Livre : Design Patterns de 1995

## Chapitre 1​ Introduction aux patterns de conception

### 1.1. Design patterns ou patterns de conception

- Schema d'objets qui forme une solution a un probleme connu et frequent
- Ensemble de classes et de relation
- Dans le cadre de la POO
- Bases sur les bonnes pratiques

Patterns introduit pour la premiere fois dans le livre dit "GoF", Gang of Four en 1995.

Shéma en UML

### 1.2. La description des patterns de conception

- Le language UML et le C# (java, ...)
- Pour chaque pattern :
    - Nom
    - Description
    - Exemple sous forme UML
    - Structure generique du pattern
    - Le cas d'utilisation
    - Un exemple de code C#
    - (lien)


## ​​Chapitre 2 ​Une étude de cas : la vente en ligne de véhicules

### 2.1. Description du système

### ​2.2. Cahier des charges

- Vehicules destines a la vente
- Catalogue
- Options
- Panier / gestion de commandes

## ​​​​Chapitre 3​ Introduction aux patterns de construction

Une interface donne des éléments commun a toute les classes qui l'implemente.

### 3.2. Les problèmes liés à la création d’objets

En C#, une instruction de creation de classe :
```csharp
objet = new MyClass(); // creation d'une instance de la classe MyClass
```

Dans certains cas il est necessaire de parametrer la construction d'objets :

```csharp
public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
}

public class Program {
    public Document CreateDoc(string typeDoc)
    {
        Document doc = null;

        if (typeDoc == "Word")
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
        else if (typeDoc == "Excel")
        {
            doc = new Document();
            doc.Title = "New Excel Document";
            doc.Content = "Excel Content";
        }
        else
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
    }
}

```

## Chapitre 4 Le pattern Abstract Factory

Créer un projet : dotnet new console -o NomDuProjet
Build : dotnet build
Run : dotnet run

### 4.1. Description

- Le but du pattern est la creation d'objets regroupes en familles sans devoir connaitre les classes concretes destinées a la création de ces objets.

- Signature de méthode : public void Document()

## Chapitre 5​ Le pattern Builder

### 5.1. Description

Composition : Mécanisme permettant a une classe de contenir une instance de cette meme classe ou d'une autre

## Chapitre 7 Le pattern Prototype

### 7.1. Description

- Création de nouveaux objets par duplication d'objets existants
- On les appelle Prototype
- Capacité de clonages 


## Chapitre 8 Le pattern Singleton

### 8.1. Description

- Le pattern Singleton permet d'assurer qu'une classe ne possede qu'une seule instance au cours de l'execution du programme
- Une methode de classe unique qui retourne cette instance

