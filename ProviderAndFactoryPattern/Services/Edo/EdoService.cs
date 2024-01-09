using System.Reflection.Metadata;

namespace ProviderAndFactoryPattern.Services.Edo
{
    public class EdoService
    {
        public void CreateDocument(Document document)
        {

        }
        public Document GetDocument(string Guid)
        {
            return new Document();
        }
    }
}
