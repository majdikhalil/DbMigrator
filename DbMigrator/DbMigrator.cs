using System;

namespace DbMigrator
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration Started at: " + DateTime.Now);

            _logger.LogInfo("Migration Ended at: " + DateTime.Now);

        }

    }
}
