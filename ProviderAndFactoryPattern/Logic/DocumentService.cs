using ProviderAndFactoryPattern.Logic.DocumentFactory;
using ProviderAndFactoryPattern.Models;
using ProviderAndFactoryPattern.Services.Edo;
using ProviderAndFactoryPattern.Services.EIjro;
using ProviderAndFactoryPattern.Services.EQaror;

namespace ProviderAndFactoryPattern.Logic
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentGeneratorFactory _factory = new DocumentGeneratorFactory();

        public DocumentService()
        {
        }

        public async Task<FinalDocument> GenerateDocument(object documentData)
        {
            var edoDocGenerator = _factory.CreateGenerator<EdoInputDucument, EdoOutputDucument>();
            var eQarorDocGenerator = _factory.CreateGenerator<EQarorInputDucument, EQarorOutputDucument>();
            var eIjroDocGenerator = _factory.CreateGenerator<EIjroInputDucument, EIjroOutputDucument>();
            var myEdoDto = new EdoInputDucument();
            var myEQarorDto = new EQarorInputDucument();
            var myEIjroDto = new EIjroInputDucument();

            var resultEdo = await edoDocGenerator.GenerateDocument(myEdoDto);
            var resultEQaror = await eQarorDocGenerator.GenerateDocument(myEQarorDto);
            var resultEIjro = await eIjroDocGenerator.GenerateDocument(myEIjroDto);


            var convertResultToFinalDocument = new FinalDocument();
            return convertResultToFinalDocument;
        }
    }
}
