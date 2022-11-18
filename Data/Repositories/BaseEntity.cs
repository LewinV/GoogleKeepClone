using System;

namespace GoogleKeepClone_DotNetAPI.Data.Repositories
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
