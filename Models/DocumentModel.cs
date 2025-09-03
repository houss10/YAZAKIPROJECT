namespace WebsiteCms.Models
{
   public class DocumentModel
{
    public int Number { get; set; }
    public required string Title { get; set; }
    public required string ControlNumber { get; set; }
        public string? RelatedDocument { get; set; }  // <-- NEW

        public required string Issue { get; set; }
    public DateTime IssueDate { get; set; }
}

}
