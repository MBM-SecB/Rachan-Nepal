namespace LearningClasses
{
    public class Country
    {
        public string Name {get;set;}

        public int Population {get; set; }

        public static readonly bool IsOnEarth;
        //Instance Construcors

        // Default constructor - parameter less
        public Country()
        {

        }

        public Country(string name,int population)
        {
            Name = name;
            Population = population;
        }

        //static constructor
        static country()
        {
            IsOnEarth = true;
        }
        
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");
            
        }
        
    }
}