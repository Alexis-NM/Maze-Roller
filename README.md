# Maze-Roller

Bienvenue dans Maze-Roller! Ce projet est un petit jeu où une balle se déplace sur une plateforme mobile et peut tomber. Le joueur utilise le trackpad pour appliquer des effets gyroscopiques et diriger la balle à travers un labyrinthe. Ce document explique comment configurer le projet, son fonctionnement, et comment l'exécuter.

## Prérequis

Avant de commencer, assurez-vous d'avoir les éléments suivants installés sur votre machine:

- [Unity](https://unity.com/)
- Un éditeur de code (par exemple, [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/))
- [Git](https://git-scm.com/) pour cloner le dépôt (optionnel)

## Installation

1. **Cloner le dépôt**
   ```
   git clone https://github.com/votre-utilisateur/Maze-Roller.git
   cd Maze-Roller
   ```

2. **Ouvrir le projet dans Unity**
   - Lancez Unity Hub.
   - Cliquez sur "Add" et sélectionnez le dossier `Maze-Roller`.
   - Ouvrez le projet.

## Structure du projet

Le projet est structuré comme suit :

- **Assets/**: Contient tous les fichiers et ressources du jeu.
  - **Scripts/**: Contient tous les scripts C# nécessaires au fonctionnement du jeu.
  - **Scenes/**: Contient les scènes Unity.
  - **Prefabs/**: Contient les objets réutilisables.
  - **Materials/**: Contient les matériaux utilisés pour les objets.

## Fonctionnement

### Script Principal: `GyroEffect.cs`

Ce script contrôle les mouvements de la balle en réponse aux entrées du trackpad. Il utilise les axes gyroscopiques pour déplacer la balle sur la plateforme.

### Plateforme Mobile

La plateforme est un objet Unity avec un script attaché pour gérer les mouvements. Ce script permet de basculer la plateforme en fonction des entrées du joueur.

### Physiques

Les objets du jeu utilisent le moteur physique d'Unity pour gérer les collisions et les mouvements réalistes. Assurez-vous que tous les objets pertinents ont des composants **Collider** et **Rigidbody**.

## Exécution du Jeu

1. **Configurer la Scène**
   - Ouvrez la scène principale située dans `Assets/Scenes/MainScene.unity`.
   - Vérifiez que tous les objets nécessaires sont présents (balle, plateforme, murs du labyrinthe).

2. **Lancer le Jeu**
   - Cliquez sur le bouton "Play" dans la barre d'outils d'Unity.
   - Utilisez le trackpad pour déplacer la balle et essayer d'atteindre la sortie du labyrinthe sans tomber.

## Contributions

Les contributions sont les bienvenues! Pour contribuer:

1. Fork le dépôt.
2. Créez une nouvelle branche pour vos modifications.
   ```
   git checkout -b feature-nom-de-votre-branche
   ```
3. Effectuez vos modifications et commitez-les.
   ```
   git commit -m "Description de vos modifications"
   ```
4. Poussez vos modifications vers votre fork.
   ```
   git push origin feature-nom-de-votre-branche
   ```
5. Créez une Pull Request sur le dépôt original.

## Support

Pour toute question ou problème, veuillez ouvrir une issue sur le [dépôt GitHub](https://github.com/votre-utilisateur/Maze-Roller/issues).

Merci d'avoir choisi Maze-Roller! Amusez-vous bien à jouer et à développer ce jeu!