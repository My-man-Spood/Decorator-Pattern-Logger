# Decorator Pattern Logger

Voici un petit programme simple qui log tout ce qu'on tappe dans la console dans un file *log.txt* sur le disque. Le but de cet exercise est d'ajouter quelques fonctionalité au logger sans modifier la classe du logger existante.



#### Fonctionalités à ajouter

1. Ajout de saut de ligne pour chaque log
2. Ajout de la sévérité entre crochet [] au debut de chaque log
3. Ajout d'un timestamp après la sévérité de chaque log
4. Ajouter une condition qui fait que si le message commence par **!** la sévérité doit être changé pour Severity.Error
5. Il serait bien de pouvoir voir le resultat du log directement dans la console aulieu de toujours ouvrir le file pour voir le résultat

