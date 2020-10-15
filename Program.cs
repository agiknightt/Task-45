using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_45
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fighter> troopOne = new List<Fighter>();
            List<Fighter> troopTwo = new List<Fighter>();

            AddTroopOne(troopOne);
            AddTroopTwo(troopTwo);

            troopTwo = troopTwo.Union(troopOne.Where(fighter => fighter.Name.StartsWith("Б"))).ToList();

            var intersect = troopOne.Intersect(troopTwo).ToList();

            for (int i = 0; i < troopOne.Count; i++)
            {
                if (troopOne[i].Name.StartsWith("Б"))
                {
                    troopOne.RemoveAt(i);
                }
            }        

            foreach (var figther in troopTwo)
            {
                Console.WriteLine($"имя бойца - {figther.Name}");
            }

            Console.ReadKey();
        }

        private static void AddTroopOne(List<Fighter> troop)
        {
            troop.Add(new Fighter("Бургузинов Антон"));
            troop.Add(new Fighter("Антонов Игорь"));
            troop.Add(new Fighter("Белов Андрей"));
            troop.Add(new Fighter("Греков Виталий"));
            troop.Add(new Fighter("Васильев Василий"));
        }
        private static void AddTroopTwo(List<Fighter> troop)
        {
            troop.Add(new Fighter("Битонов Александр"));
            troop.Add(new Fighter("Болегов Николай"));
            
        }
    }    
    class Fighter
    {
        public string Name { get; private set; }
        public Fighter(string name)
        {
            Name = name;
        }
    }
}
