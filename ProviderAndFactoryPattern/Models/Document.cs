namespace ProviderAndFactoryPattern.Models
{
    public class Document
    {
        public Guid Guid { get; set; }
        public string Titile { get; set; }
        public string Content { get; set; }
        public DocumentType DocumentType{get;set;}

    }
}
