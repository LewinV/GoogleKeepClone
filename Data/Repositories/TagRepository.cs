using GoogleKeepClone_DotNetAPI.Data.Models;

namespace GoogleKeepClone_DotNetAPI.Data.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        protected readonly AppDbContext _appDbContext;
        public TagRepository(AppDbContext context)
         : base(context)
        { }
    }
}
