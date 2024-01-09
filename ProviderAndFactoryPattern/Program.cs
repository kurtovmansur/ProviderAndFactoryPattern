using ProviderAndFactoryPattern.Logic;

var docService = new DocumentService();
var result = await docService.GenerateDocument(null);
