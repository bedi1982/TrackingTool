using Tracking.Tool;


namespace Tracking.Tool
{
    class SingletonObjectContext
    {
        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly banco context;

        private SingletonObjectContext()
        {
            context = new banco();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public banco Context
        {
            get
            {
                return context;
            }
        }
    }
}