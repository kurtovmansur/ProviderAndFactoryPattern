using ProviderAndFactoryPattern.Services.EIjro;

namespace ProviderAndFactoryPattern.Logic.Providers
{
    public class EIjroDocumentProvider : IDocumentGenerator<EIjroInputDucument, EIjroOutputDucument>
    {
        public async Task<EIjroOutputDucument> GenerateDocument(EIjroInputDucument model)
        {
            await Console.Out.WriteLineAsync("EIjro document generated");
            return new EIjroOutputDucument();
        }
    }
}
