using MongoDB.Driver;

namespace EVA_Extract_Actuals
{
    public class Database
    {
        public static class Collections
        {
            public static readonly string DISTRIBUTIONS = "DISTRIBUTIONS";

            public static readonly string USERS = "USERS";

            public static readonly string TASKS = "`TASKS";

            public static readonly string PRE_BASELINES = "PRE-BASELINE";

            public static readonly string PRE_BASELINE_TASKS = "PRE-BASELINE-TASKS";

        }

        public static IMongoDatabase GetDatabase()
        {
            MongoClient dbClient = new MongoClient(<ConnectionString>);

            return dbClient.GetDatabase(<DatabaseName>);
        }

    }
}
