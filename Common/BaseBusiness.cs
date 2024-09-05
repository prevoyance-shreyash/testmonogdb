namespace MongodbTest.Common
{
    public class BaseBusiness
    {


        public string GetDbName { get; set; }
        public string GetConnectionString { get; set; }

        public BaseBusiness(Microsoft.Extensions.Configuration.IConfiguration appConfig)
        {
            GetDbName = appConfig.GetSection("Database:DatabaseName").Value;
            GetConnectionString = appConfig.GetSection("Database:ConnectionString").Value;
        }
    }
}
