using ProviderAndFactoryPattern.Models;

namespace ProviderAndFactoryPattern.Logic
{
    public interface IDocumentService
    {
        Task<FinalDocument> GenerateDocument(object documentData);
    }
}