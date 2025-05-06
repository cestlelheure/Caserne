Partie 1: Interface principale et gestion des équipements
Responsabilités:

Structure principale de l'interface utilisateur (formulaire de démarrage)
Volet 3: Parcours des équipements d'une caserne (mode déconnecté)

Implémentation de la visualisation 1 à 1 des engins
Navigation avant/arrière en utilisant les liaisons de données
Affichage de l'état des engins (en réparation/en mission)


Intégration des classes existantes (Connexion, MesDatas)
Gestion du mode déconnecté/connecté pour l'ensemble de l'application

Justification: Cette partie permet de mettre en place l'architecture globale de l'application tout en développant le volet 3 qui est relativement indépendant. Elle servira de base pour les autres parties.



Partie 2: Gestion des missions
Responsabilités:

Volet 1: Tableau de bord des missions en cours

Affichage des missions en cours/passées
Interface pour la clôture rapide des missions


Volet 2: Création d'une nouvelle mission

Interface de création des missions
Algorithme d'affectation des engins selon le type de sinistre
Algorithme d'affectation du personnel selon disponibilité et habilitations
Gestion des casernes alternatives si équipement non disponible


Génération des PDF de bilan de mission

Justification: Cette partie constitue toujours le cœur fonctionnel de l'application avec les algorithmes les plus complexes. L'implémentation de ces volets forme un ensemble cohérent autour du cycle de vie des missions.



Partie 3: Gestion du personnel et statistiques
Responsabilités:

Volet 4: Gestion des pompiers

Interface de consultation/modification des données des pompiers
Gestion des droits d'administration pour les modifications
Implémentation des transactions pour les mises à jour
Gestion des affectations, grades et congés


Volet 5: Statistiques pour le régulateur

Requêtes SQL pour les différentes statistiques demandées
Interface utilisateur pour la visualisation des statistiques
Rapports par caserne et pour l'ensemble des casernes



Justification: Cette partie conserve les fonctionnalités d'administration et d'analyse qui forment un ensemble cohérent.