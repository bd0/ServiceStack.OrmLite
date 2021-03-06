using ServiceStack.OrmLite.Firebird;

namespace ServiceStack.OrmLite
{
    public static class FirebirdDialect
    {
        public static IOrmLiteDialectProvider Provider => FirebirdOrmLiteDialectProvider.Instance;
        public static FirebirdOrmLiteDialectProvider Instance => FirebirdOrmLiteDialectProvider.Instance;
    }
}