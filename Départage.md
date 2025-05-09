# Répartition du travail – SAÉ 2.04 « Les soldats du feu »

## Contexte
La base de données `SDIS67.db`, ainsi que les classes `Connexion.cs` et `mesDatas.cs`, sont déjà fournies et prêtes à l'emploi. Le projet est développé en trinôme et consiste à implémenter les différents volets de l'application de gestion des casernes.

---

## Andy 1 – **Missions (Volet 1 & 2)**

### Volet 1 : Tableau de bord des missions
- Affichage des missions en cours / passées via le `DataSet`.
- Clôture des missions au retour des pompiers.
- Génération de PDF récapitulatif des missions (à partir du DataSet local).

### Volet 2 : Création d'une nouvelle mission
- Formulaire de création en mode déconnecté.
- Sélection automatique des engins et pompiers disponibles selon sinistre.
- Attribution intelligente à la caserne la mieux équipée.
- Répercussion en base au moment de la clôture.

**Technologies :** WinForms/WPF, DataGridView ou UserControl, PDF, DataSet

---

## Arthur – **Matériel et Statistiques (Volet 3 & 5)**

### Volet 3 : Parcours des équipements
- Visualisation 1 à 1 des engins d'une caserne.
- Navigation avant/arrière.
- Affichage de l'état (en réparation / en mission).
- Liaison de données (sans accès direct à la base).

### Volet 5 : Statistiques régulateur
- Requêtes SQL pour :
  - Engins les plus utilisés.
  - Heures d’utilisation cumulées.
  - Interventions par type de sinistre.
  - Habilitations les plus sollicitées.
  - Liste des pompiers par habilitation (y compris habilitations sans pompiers).
- Présentation des résultats (tableaux, graphiques...).

**Technologies :** Liaison DataSet, SQL, Visualisation de données

---

## Adrien – **Gestion du personnel (Volet 4) + UI globale**

### Volet 4 : Gestion des pompiers
- Consultation / modification des pompiers.
- Gestion des affectations, grades, congés, habilitations.
- Ajout de nouveaux pompiers.
- Vérification des droits via la table `Admin`.
- Utilisation de transactions pour sécuriser les modifications.

### Interface et ergonomie
- Design global de l’application.
- Navigation entre les volets.
- Uniformisation de l’interface graphique.

**Technologies :** SQL (mode connecté), Transactions, Design UI

---

## Travail commun
- Définition partagée des classes métiers (`Pompier`, `Mission`, `Engin`…).
- Intégration et tests finaux.
- Préparation de la soutenance et du rapport de présentation.

