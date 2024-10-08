// Crée un tableau 8x8 (échiquier) initialisé à "false" (aucune case n'a de soie au départ)
bool[,] silkyWay = new bool[8, 8];

// Place de la soie sur A1 et H8 pour marquer les points de départ et d'arrivée
silkyWay[0, 0] = true; // A1 (point de départ)
silkyWay[7, 7] = true; // H8 (point d'arrivée)

// Fonction qui dessine l'échiquier (grille 8x8) sur la console
void DrawBoard(bool[,] board)
{
    // Affiche les numéros des colonnes pour la référence
    Console.WriteLine("  12345678");
    Console.WriteLine(" ┌────────┐");

    // Parcourt chaque ligne ('A' à 'H')
    for (char row = 'A'; row <= 'H'; row++)
    {
        // Affiche la lettre de la ligne et la bordure gauche de la grille
        Console.Write(row + "│");

        // Parcourt chaque colonne (de 1 à 8)
        for (int col = 1; col <= 8; col++)
        {
            // Si la case contient de la soie (true), affiche un carré plein
            if (board[row - 'A', col - 1])
            {
                Console.Write("█");
            }
            // Sinon, affiche un espace vide
            else
            {
                Console.Write(" ");
            }
        }
        // Termine la ligne avec la bordure droite
        Console.WriteLine("│");
    }
    // Dessine la bordure inférieure de la grille
    Console.WriteLine(" └────────┘");
}

// Fonction pour ajouter de la soie sur 30 autres cases de manière aléatoire
bool[,] AddSilk(bool[,] board)
{
    Random random = new Random();  // Générateur de nombres aléatoires
    int x;
    int y;
    int counter = 2;  // Compte les cases déjà occupées (A1 et H8)

    // Boucle jusqu'à ce qu'il y ait 28 cases supplémentaires (30 en tout)
    while (counter < 28)
    {
        // Génère des coordonnées aléatoires
        x = random.Next(0, 8);
        y = random.Next(0, 8);

        // Si la case est vide (pas encore de soie), on y ajoute de la soie
        if (!board[x, y])
        {
            board[x, y] = true;
            counter++;
        }
    }
    return board;
}

// Ajoute de la soie aléatoire sur 30 cases au total
silkyWay = AddSilk(silkyWay);
// Affiche l'échiquier avec la soie
DrawBoard(silkyWay);


// Crée une structure de données (tableau 8x8) pour se souvenir des cases déjà testées
bool[,] caseTest = new bool[8, 8];
caseTest[0, 0] = true;  // On commence à tester la case A1 (point de départ)

// Crée une structure de données pour se souvenir du chemin de sortie réussi
bool[,] exitPath = new bool[8, 8];
exitPath[7, 7] = true;  // H8 est la case de sortie réussie

// Fonction récursive pour vérifier si on peut atteindre H8 depuis une position donnée
// L'algorithme en français :
// 
// Je peux sortir depuis cette case si :
// 1. Je suis sur H8
// OU
// 2. Je peux sortir depuis une des cases accessibles (et où je ne suis pas encore allé)

bool Algoritm(int x, int y)
{
    // Si on est arrivé à H8, la sortie est trouvée
    if (x == 7 && y == 7) return true;

    // Vérifie si les coordonnées sont hors des limites, si la case n'a pas de soie, ou si elle a déjà été testée
    if (x < 0 || y < 0 || x > 7 || y > 7 || !silkyWay[x, y] || (caseTest[x, y] && (y != 0 || x != 0))) return false;

    // Marque la case actuelle comme testée
    caseTest[x, y] = true;

    // Explore les cases voisines dans les 8 directions possibles (haut, bas, gauche, droite, diagonales)
    if (Algoritm(x + 1, y) || Algoritm(x - 1, y) || Algoritm(x, y + 1) || Algoritm(x, y - 1) ||
        Algoritm(x + 1, y + 1) || Algoritm(x - 1, y - 1) || Algoritm(x - 1, y + 1) || Algoritm(x + 1, y - 1))
    {
        // Si une des directions mène à la sortie, marque cette case comme faisant partie du chemin réussi
        exitPath[x, y] = true;
        return true;
    }
    else
    {
        // Si aucune direction ne mène à la sortie, retourne false
        return false;
    }
}

// Appelle la fonction pour voir s'il existe un chemin depuis A1 jusqu'à H8
if (Algoritm(0, 0))
{
    // Si un chemin est trouvé, affiche l'échiquier avec le chemin réussi
    Console.SetCursorPosition(0, 15);
    DrawBoard(exitPath);
}

// Attend une entrée pour garder la console ouverte
Console.ReadLine();
