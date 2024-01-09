using ProviderAndFactoryPattern.Services.EQaror;

namespace ProviderAndFactoryPattern.Logic.Providers
{
    public class EQarorDocumentProvider : IDocumentGenerator<EQarorInputDucument, EQarorOutputDucument>
    {
        public async Task<EQarorOutputDucument> GenerateDocument(EQarorInputDucument model)
        {
            await Console.Out.WriteLineAsync("EQaror document generated");
            return new EQarorOutputDucument();
        }
    }
}
