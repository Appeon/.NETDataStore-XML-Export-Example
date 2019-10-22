using System;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace XmlDataDemo
{
    public class SampleDataContext : SqlServerDataContext
	{
        public SampleDataContext(string connectionString)
            : this(new SqlServerDataContextOptions<SampleDataContext>(connectionString))
        {
        }

        public SampleDataContext(IDataContextOptions<SampleDataContext> options)        
            : base(options)
        {
        }
        
        public SampleDataContext(IDataContextOptions options)        
            : base(options)
        {
        }
    }
}
