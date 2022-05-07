namespace HLgrocery.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HLgroceryContext dbContext;

        public HLgroceryContext Init()
        {
            return dbContext ?? (dbContext = new HLgroceryContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
