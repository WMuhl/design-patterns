namespace singleton
{
    // The 'Singleton' class
    internal class Singleton
    {
        // A private static variable that holds the single instance of the Singleton
        private static Singleton? _instance = null;

        // A private constructor to prevent instantiation outside the class
        private Singleton()
        {
        }

        // The public static method that controls access to the Singleton instance
        public static Singleton Instance
        {
            get
            {
                // If the instance is null, create a new one
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                // Return the Singleton instance
                return _instance;
            }
        }

        // An example method that the Singleton class might provide
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Trying to create instances of the Singleton
            Singleton firstInstance = Singleton.Instance;
            Singleton secondInstance = Singleton.Instance;

            // Demonstrating that both variables hold the same instance
            if (firstInstance == secondInstance)
            {
                Console.WriteLine("Both instances are the same.");
            }

            // Using the Singleton instance to perform an action
            firstInstance.DoSomething();
        }
    }
}