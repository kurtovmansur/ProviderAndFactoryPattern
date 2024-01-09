namespace ProviderAndFactoryPattern.Logic
{
    public interface IDocumentGenerator<TInput, TOutput>
    {
        Task<TOutput> GenerateDocument(TInput model);
    }
}
