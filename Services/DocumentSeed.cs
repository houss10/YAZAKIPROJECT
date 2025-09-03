using WebsiteCms.Models;

namespace WebsiteCms.Services
{
    public static class DocumentSeed
    {
        public static Dictionary<string, List<DocumentModel>> GetDocuments()
        {
            return new Dictionary<string, List<DocumentModel>>
            {
                // Quality (already done)
                { "Instruction", new List<DocumentModel> {
                    new DocumentModel { Number = 1, Title = "Instruction salle d'archive", ControlNumber = "EA-QM-BTU-WH-I-277", RelatedDocument = null, Issue = "1", IssueDate = new DateTime(2024, 7, 5) }
                }},
                { "Procedure", new List<DocumentModel> {
                    new DocumentModel { Number = 1, Title = "Procédure de gestion des risques", ControlNumber = "EA-QM-BTU-WH-P-301", RelatedDocument = "ISO9001", Issue = "2", IssueDate = new DateTime(2023, 5, 20) }
                }},

                // TD
                { "TD-Procedures", new List<DocumentModel> {
                    new DocumentModel { Number = 1, Title = "Procédure TPME", ControlNumber = "TD-P-001", RelatedDocument = null, Issue = "1", IssueDate = new DateTime(2024, 6, 1) }
                }},
                { "TD-Instructions", new List<DocumentModel> {
                    new DocumentModel { Number = 1, Title = "Instruction TPME", ControlNumber = "TD-I-001", RelatedDocument = "TD-P-001", Issue = "1", IssueDate = new DateTime(2024, 6, 2) }
                }},
                { "TD-TPME", new List<DocumentModel>() },
                { "TD-TPMEP1", new List<DocumentModel>() },
                { "TD-TPMEP2", new List<DocumentModel>() },
                { "TD-TPMEP3", new List<DocumentModel>() },

                // Logistic
                { "Logistic-Procedures", new List<DocumentModel>() },
                { "Logistic-Instructions", new List<DocumentModel>() },

                // Finance
                { "Finance-Procedures", new List<DocumentModel>() },
                { "Finance-Instructions", new List<DocumentModel>() },

                // Prod
                { "Prod-P1P2", new List<DocumentModel>() },
                { "Prod-P3", new List<DocumentModel>() },

                // SQA
                { "SQA-Index", new List<DocumentModel>() },

                // Project
                { "Project-Launch", new List<DocumentModel>() },

                // Purchasing
                { "Purchasing-Index", new List<DocumentModel>() }
            };
        }
    }
}
