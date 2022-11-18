namespace GoogleKeepClone_DotNetAPI.Data.Models
{
    public class Note
    {
        public string NoteId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public ApplicationUser User { get; set; }
        public List<NoteTag> NoteTags { get; set; }
    }
}
