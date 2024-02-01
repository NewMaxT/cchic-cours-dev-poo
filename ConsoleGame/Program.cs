namespace ConsoleGame
{
    internal class Program
    {
        private static void AfficherStatsPersonnage(Personnage personnage)
        {
            Console.WriteLine("Vie : " + personnage.Vie);
            Console.WriteLine("Mana : " + personnage.Mana);
            Console.WriteLine("Or : " + personnage.Or);
            Console.WriteLine("Force : " + personnage.Force);

            Console.WriteLine();

            Console.WriteLine("Inventaire :");
            Console.WriteLine("\tNom");
            for (int index = 0; index < personnage.Inventaire.Count; index++)
            {
                Console.WriteLine("\t" + personnage.Inventaire[index].getNom);
            }

            Console.WriteLine();

            Console.WriteLine("Livre de magie :");
            Console.WriteLine("\tNom");
            for (int index = 0; index < personnage.Sortileges.Count; index++)
            {
                Console.WriteLine("\t" + personnage.Sortileges[index].Name);
            }

            Console.WriteLine();

            Console.WriteLine("Capacités :");
            Console.WriteLine("\tNom");
            for (int index = 0; index < personnage.Capacités.Count; index++)
            {
                Console.WriteLine("\t" + personnage.Capacités[index].getNom);
            }

            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Objet arc = new Objet("Arc", "Armes");
            Objet glock = new Objet("Glock-19", "Armes");

            Capacité doubleSaut = new Capacité("Double Jump", "Permet de sauter deux fois", "Mouvement");
            Capacité daTrickshot = new Capacité("360 No-scope Headshot AcrossZmap", "Tout est dans le nom :)", "Mouvement");

            Sortilege glace = new Sortilege("Sort de glace", 500);
            Sortilege feu = new Sortilege("Sort de feu", 500);

            Spécialisation guerrier = new Spécialisation("Guerrier");
            guerrier.AddSortilege = glace;
            guerrier.AddSortilege = feu;

            Spécialisation terroriste = new Spécialisation("Terroriste");
            terroriste.AddSortilege = feu;

            Personnage henry = new Personnage(100, 50, 1500, 500, 35245, new List<Objet> { arc, glock },
                new List<Capacité> { doubleSaut, daTrickshot }, guerrier);

            Personnage george = new Personnage(110, 40, 1500, 500, 35, new List<Objet> { glock },
    new List<Capacité> { doubleSaut }, terroriste);

            AfficherStatsPersonnage(henry);
            AfficherStatsPersonnage(george);
        }
    }
}