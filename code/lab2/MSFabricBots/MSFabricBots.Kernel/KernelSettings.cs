using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


using Microsoft.SemanticKernel.Orchestration;


using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using Microsoft.SemanticKernel.Connectors.Memory.Qdrant;
using Microsoft.SemanticKernel.Plugins.Memory;
using Microsoft.SemanticKernel.Connectors.AI.OpenAI.TextEmbedding;

namespace MSFabricBots.Kernel;

public class KernelSettings
{
    IKernel kernel;

    ISemanticTextMemory skmemory;
    IConfigurationRoot configuration;

    IDictionary<string, ISKFunction> qa_plugin;

    IDictionary<string, ISKFunction> content_plugin;

    string pluginDirectory;

    AzureOpenAIConfiguration azureOpenAIConfiguration;

    public KernelSettings(IConfigurationRoot configuration,string pluginDirectory)
    {
        this.configuration = configuration;
        this.pluginDirectory = pluginDirectory;
        this.azureOpenAIConfiguration = this.configuration.GetSection("AzureOpenAI").Get<AzureOpenAIConfiguration>();
        this.kernel = new Microsoft.SemanticKernel.KernelBuilder()
                .WithAzureOpenAIChatCompletionService(azureOpenAIConfiguration.deployName, azureOpenAIConfiguration.endpoint, azureOpenAIConfiguration.apiKey)
                .Build();

        var qdrantMemoryBuilder = new MemoryBuilder();

        var textEmbedding = new AzureOpenAITextEmbeddingGeneration(azureOpenAIConfiguration.embeddingDeployName, azureOpenAIConfiguration.endpoint, azureOpenAIConfiguration.apiKey);
        qdrantMemoryBuilder.WithTextEmbeddingGeneration(textEmbedding);
        qdrantMemoryBuilder.WithQdrantMemoryStore(azureOpenAIConfiguration.vectorDBEndpoint, 1536);

        this.skmemory = qdrantMemoryBuilder.Build();

        this.content_plugin = kernel.ImportSemanticFunctionsFromDirectory(this.pluginDirectory,"ReadPlugin");
        this.qa_plugin = kernel.ImportSemanticFunctionsFromDirectory(this.pluginDirectory,"QAPlugin");
    }

    public IAsyncEnumerable<Microsoft.SemanticKernel.Memory.MemoryQueryResult> AskPlugin(string questionText)
    {
        var searchResults =   this.skmemory.SearchAsync(this.azureOpenAIConfiguration.memoryCollectionName, questionText, limit: 1, minRelevanceScore: 0.7);
        return searchResults;
    } 

    
    public async Task<KernelResult> SummaryPlugin(string answer)
    {
        var result = await this.kernel.RunAsync(answer, this.qa_plugin["KB"]);

        return result;
    } 


}