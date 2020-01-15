# NPR-Calculator
NPR Calculator - C# application

Description
-----------

Application console en C# pour calculer des expressions selon la notation inversée. L'utilisateur saisie une expression au clavier puis celle-ci est évaluée.

Principe de fonctionnement
--------------------------

Le calcul se fait en utilisant une pile (Classe Stack<T> en C#). La notation étant inversée, les opérateurs se retrouvent après les deux chiffres à utiliser:
 - On sépare les éléments de l'expression entrée au clavier
 - Si l'élément est un chiffre, on le push en haut de la pile
 - Si l'élément est un opérateur, on effectue l'opération adéquate avec les deux derniers éléments de la pile qui sont ensuite      supprimé. le résultat de l'opération prend la place haute.
 - On répète l'opération jusqu'à atteindre la fin du tableau
