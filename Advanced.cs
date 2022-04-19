class Allergy
    {
        private enum Allergen
        { 
            "Eggs" = 1
            "Peanuts" = 2
            "Shellfish" = 4
            "Strawberries" = 8
            "Tomatoes" = 16
            "Chocolate" = 32
            "Pollen" = 64
            "Cats" = 128
        };

        public string name;
        public string allergies;
        public int allergyScore;

        public Allergy(string name)
        {
            this.name = name;
        }
        public Allergy(string name, int allergyScore)
        {
            this.name = name;
            this.allergyScore = allergyScore;
        }
        public Allergy(string name, string allergies)
        {
            this.name = name;
            this.allergies = allergies;
        }
    }
