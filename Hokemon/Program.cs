using System;

namespace Hokemon_U
{
    class Hokemon
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Hokeworld!");

            Hokemon hokeObject01 = new Hokemon();

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();

            hoke02.get_details();
        }

        // MEMBERS of a CLASS include Attributes, Methods and Properties are MEMBERS of this class

        // Attributes

        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        // Properties

        public string Name
        {
            get { return name; }   // access to the health attribute
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        
        // Methods

        public Hokemon() // CONSTRUCTOR method runs 1st when INSTANTIATED
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }
         public void provide_name() // METHOD
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public void get_details()
        {
            Console.WriteLine("\n******************\nName: {0}\n" +
                "Health: {1}/{2}\n" +
                "Attack value: {3}\n" +
                "Speed value {4}\n" +
                "Defense value: {5}", name, health, max_health, attack, speed, defense);
        }

        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }
    
    }

    class Halor : Hokemon
    {
        private string team = "Halor";

        Halor halorHoke01 = new Halor(); // INHERITED Halor-Hokemon
        halorHoke01.get_details();
    }
    public int attackCalculator()
    {
        int attackValue;
        attackValue = (attack + speed) * random_int_generator(0, 2)
            }
}
