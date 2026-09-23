# TP1 – Application VR

Prototype de déplacement en réalité virtuelle développé avec **Unity** pour le cours **LOG8704**. L’application est destinée à être testée sur un **Meta Quest 3** et utilise les fonctionnalités du **Meta SDK**.

## Scène à tester

La scène principale à utiliser pour tester l’application est :

```text
Assets/Scenes/test.unity
```

Ouvrir cette scène dans Unity avant de lancer l’application.

## Configuration requise

* Unity
* Meta XR SDK
* Casque **Meta Quest 3**
* Contrôleurs du Meta Quest 3

## Méthodes de déplacement

L’application propose trois méthodes de déplacement :

* **Déplacement physique** : l’utilisateur peut se déplacer réellement dans son environnement.
* **Déplacement au thumbstick** : le joystick gauche permet de se déplacer et le joystick droit permet de tourner la vue.
* **Téléportation** : maintenir le *trigger* de la manette droite pour viser, puis le relâcher pour se téléporter vers la destination sélectionnée.

Une interface apparaît également lorsque l’utilisateur regarde sa manette afin d’indiquer les différentes fonctionnalités des contrôleurs.

## Tester sur le Meta Quest 3

Pour tester l’application directement sur le casque, connecter le Meta Quest 3 à l’ordinateur et utiliser **Build and Run** dans Unity.

Avant de lancer l’application, l’utilisateur doit configurer la **zone de déplacement (Boundary)** dans les réglages du Meta Quest 3 en fonction de son environnement physique. La zone de déplacement n’est pas définie à une taille fixe par l’application.

Le **Meta XR Simulator** peut également être utilisé pour tester l’application lorsque celui-ci fonctionne correctement sur l’ordinateur utilisé.

## Problèmes connus

* Il est possible de viser à travers certains blocs avec le laser de téléportation et de se téléporter derrière ceux-ci.
* Certaines situations peuvent permettre à l’utilisateur de sortir de la zone prévue (*out of bounds*).

## Matériel testé

L’application a été testée sur :

* **Meta Quest 3**
* Ordinateurs portables Windows
* Ordinateur de bureau Windows avec le **Meta XR Simulator**

Le Meta XR Simulator n’a toutefois pas fonctionné sur tous les ordinateurs de l’équipe.

## Conditions de test

Les tests sur le Meta Quest 3 ont été réalisés dans une salle de laboratoire. L’espace physique disponible étant limité par la présence de plusieurs postes de travail, les déplacements physiques peuvent être restreints dans cet environnement.
