using ProviderAndFactoryPattern.Logic.Providers;
using ProviderAndFactoryPattern.Services.Edo;
using ProviderAndFactoryPattern.Services.EIjro;
using ProviderAndFactoryPattern.Services.EQaror;

namespace ProviderAndFactoryPattern.Logic.DocumentFactory
{
    public class DocumentGeneratorFactory : IDocumentGeneratorFactory
    {
        public IDocumentGenerator<TInput, TOutput>? CreateGenerator<TInput, TOutput>()
        {
            if (typeof(TInput) == typeof(EdoInputDucument) && typeof(TOutput) == typeof(EdoOutputDucument))
            {
                return new EdoDocumentProvider() as IDocumentGenerator<TInput,TOutput>;
            }
            else if (typeof(TInput) == typeof(EQarorInputDucument) && typeof(TOutput) == typeof(EQarorOutputDucument))
            {
                return new EQarorDocumentProvider() as IDocumentGenerator<TInput, TOutput>;
            }
            else if (typeof(TInput) == typeof(EIjroInputDucument) && typeof(TOutput) == typeof(EIjroOutputDucument))
            {
                return new EIjroDocumentProvider() as IDocumentGenerator<TInput, TOutput>;
            }
            return null;
        }
    }
}
