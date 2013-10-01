using TrackingTool6.db;


namespace TrackingTool6.db
{
    class SingletonObjectContext
    {
        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly TrackingToolEntities context;

        private SingletonObjectContext()
        {
            context = new TrackingToolEntities();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public TrackingToolEntities Context
        {
            get
            {
                return context;
            }
        }
    }
}