using ProviderAndFactoryPattern.Services.Edo;

namespace ProviderAndFactoryPattern.Logic.Providers
{
    public class EdoDocumentProvider : IDocumentGenerator<EdoInputDucument, EdoOutputDucument>
    {
        public async Task<EdoOutputDucument> GenerateDocument(EdoInputDucument model)
        {
            await Console.Out.WriteLineAsync("Edo document generated");
            return new EdoOutputDucument();
        }
    }
}
