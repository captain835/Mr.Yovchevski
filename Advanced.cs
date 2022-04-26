using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask
{
    class Allergies
    {
        [Flags]
        private enum Allergen
        {
            Eggs = 1,
            Peanuts = 2,
            Shellfish = 4,
            Strawberries = 8,
            Tomatoes = 16,
            Chocolate = 32,
            Pollen = 64,
            Cats = 128
        }

        readonly string name;
        private string[] allergies;
        readonly int allergyScore;
        
        public Allergies(string name)
        {
            this.name = name;
        }
        public Allergies(string name, int allergyScore)
        {
            this.name = name;
            this.allergyScore = allergyScore;
        }
        public Allergies(string name, string allergies)
        {
            this.name = name;
            this.allergies = allergies.Split(' ');
            for(int i = 0; i < allergies.Length; i++)
                allergyScore += (int)(Allergen)allergies[i];
        }
        public override string ToString()
        {
            string res = $"{name} ";
            if (allergyScore == 0)
                res += "has no allergies";
            else
                res += $"is allergic to {(Allergen)allergyScore}";
            Console.WriteLine(res);
            return res;
        }
        public bool IsAllergicTo(string question)
        {
            if ($"{(Allergen)allergyScore}".Contains(question))
                return true;
            else
                return false;
        }
        public void AddAllergy(string allergyToAdd)
        {
            allergyScore += (int)(Allergen)allergyToAdd;
        }
    }
}
