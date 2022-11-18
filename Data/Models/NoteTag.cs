namespace GoogleKeepClone_DotNetAPI.Data.Models
{
    public class NoteTag
    {
        public string NoteId { get; set; }
        public Note Note { get; set; }
        public string TagId {get; set;}
        public Tag Tag { get; set; }
    }
}
