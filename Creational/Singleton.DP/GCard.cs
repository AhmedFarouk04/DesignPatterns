namespace Singleton_DP
{
    public sealed class GCard
    {
        // Public data just for demo
        public int Data { get; private set; }

        // Private Constructor
        // Prevent creating objects using new
        private GCard(int data)
        {
            Data = data;
        }

        // 1 Singleton – Static Readonly Property
        //  Thread-safe
        //  Created once at application startup
        //  Not lazy
        public static GCard SingletonObj { get; }
            = new GCard(123);

        // 2  Singleton – Static Method (Lazy)
        private static GCard? _instance;

        public static GCard GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GCard(999);
            }

            return _instance;
        }
    }
}
