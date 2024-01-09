using ProviderAndFactoryPattern.Models;

namespace ProviderAndFactoryPattern.Logic.DocumentFactory
{
    public interface IDocumentGeneratorFactory
    {
        IDocumentGenerator<TInput, TOutput> CreateGenerator<TInput, TOutput>();
    }
}
