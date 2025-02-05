# EMGBACAR
EMGBACAR - Système de Gestion d'Inventaire de Voitures

Description

EMGBACAR est une application de gestion d'inventaire de voitures d'occasion. Elle permet d'ajouter, modifier, afficher et marquer les voitures comme vendues ou indisponibles. L'application utilise le framework ASP.NET Core MVC avec SQLserver comme base de données.

Déploiement sur Azure : 
L'application EMGBACAR est déployée sur Azure. Vous pouvez y accéder directement à l'adresse suivante :

URL de l'application déployée :
https://emgbacar.azurewebsites.net/

Connexion : 
- Admin : admin@emgb.com / Admin@123

Prérequis :
Avant d'exécuter l'application, assurez-vous d'avoir installé :

- .NET 9 SDK
- Un éditeur de code comme Visual Studio Code ou Visual Studio

Installation : 
- git clone https://github.com/BacarImane2/EMGBACAR.git
- Restaurez les dépendances :
    dotnet restore
- Configurez la base de données :
    dotnet ef database update

Exécution : 

- Lancez l'application :
    dotnet run

- Ouvrez votre navigateur et accédez à :
    http://localhost:port

Connexion : 
- Admin : admin@emgb.com / Admin@123

- Utilisateur standard : Vous pouvez créer un compte via la page d'inscription.

Fonctionnalités principales :

- Ajout, modification et suppression de voitures (admin seulement)

- Consultation de l'inventaire pour tous les utilisateurs

- Authentification et gestion des rôles (admin et utilisateur standard)

Contribution :
Les contributions sont les bienvenues 

