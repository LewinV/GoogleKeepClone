namespace GoogleKeepClone_DotNetAPI.Data.Models
{
    public class Tag
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<NoteTag> NoteTags { get; set; }
    }
}
