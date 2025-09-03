using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteCms.Models
{
    // EF entity (separate from your public DocumentModel)
    public class ADocumentModel
    {
        public int Id { get; set; }

        [Range(0, int.MaxValue)]
        public int Number { get; set; }

        [Required, MaxLength(500)]
        public string Title { get; set; } = default!;

        [Required, MaxLength(200)]
        public string ControlNumber { get; set; } = default!;

        // New, can be null
        [MaxLength(200)]
        public string? RelatedDocument { get; set; }

        [Required, MaxLength(50)]
        public string Issue { get; set; } = default!;

        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }

        // Used to route docs to the correct page (e.g., "TD-TPMEP2", "Finance-Procedures")
        [Required, MaxLength(100)]
        public string Category { get; set; } = default!;

        // Optional URLs (if you later want the table to render links)
        [MaxLength(1000)]
        public string? ControlNumberUrl { get; set; }

        [MaxLength(1000)]
        public string? RelatedDocumentUrl { get; set; }
    }
}
