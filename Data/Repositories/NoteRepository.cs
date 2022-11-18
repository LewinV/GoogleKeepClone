using GoogleKeepClone_DotNetAPI.Data.Repositories;
using GoogleKeepClone_DotNetAPI.Data.Models;
using GoogleKeepClone_DotNetAPI.Data;

namespace DotNetWebApi_Auth.Repositories
{
    public class NoteRepository : Repository<Note>, INoteRepository
    {
        public NoteRepository(AppDbContext context)
         : base(context)
        { }
    }
}
