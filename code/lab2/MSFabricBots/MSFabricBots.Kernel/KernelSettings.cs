using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Embeddings;
using Microsoft.SemanticKernel.Memory;
using Microsoft.SemanticKernel.Connectors.Qdrant;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace MSFabricBots.Kernel;

public class KernelSettings
{
    Microsoft.SemanticKernel.Kernel kernel;

    #pragma warning disable SKEXP0003
    ISemanticTextMemory skmemory;
    IConfigurationRoot configuration;

    KernelPlugin qa_plugin;

    KernelPlugin content_plugin;

    string pluginDirectory;

    AzureOpenAIConfiguration azureOpenAIConfiguration;

    public KernelSettings(IConfigurationRoot configuration,string pluginDirectory)
    {

        #pragma warning disable SKEXP0003
        #pragma warning disable SKEXP0011
        #pragma warning disable SKEXP0026


        this.configuration = configuration;
        this.pluginDirectory = pluginDirectory;
        this.azureOpenAIConfiguration = this.configuration.GetSection("AzureOpenAI").Get<AzureOpenAIConfiguration>();

        this.kernel = Microsoft.SemanticKernel.Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(azureOpenAIConfiguration.deployName, azureOpenAIConfiguration.endpoint, azureOpenAIConfiguration.apiKey)
            .Build();

        var qdrantMemoryBuilder = new MemoryBuilder();

        var textEmbedding = new AzureOpenAITextEmbeddingGenerationService(azureOpenAIConfiguration.embeddingDeployName, azureOpenAIConfiguration.endpoint, azureOpenAIConfiguration.apiKey);

        qdrantMemoryBuilder.WithTextEmbeddingGeneration(textEmbedding);
        qdrantMemoryBuilder.WithQdrantMemoryStore(azureOpenAIConfiguration.vectorDBEndpoint, 1536);

        this.skmemory = qdrantMemoryBuilder.Build();

        this.content_plugin = this.kernel.CreatePluginFromPromptDirectory(Path.Combine(this.pluginDirectory, "ReadPlugin"));
        this.qa_plugin = this.kernel.CreatePluginFromPromptDirectory(Path.Combine(this.pluginDirectory, "QAPlugin"));
    }

    public IAsyncEnumerable<Microsoft.SemanticKernel.Memory.MemoryQueryResult> AskPlugin(string questionText)
    {

        #pragma warning disable SKEXP0003
        #pragma warning disable SKEXP0011
        #pragma warning disable SKEXP0026


        var searchResults =   this.skmemory.SearchAsync(this.azureOpenAIConfiguration.memoryCollectionName, questionText, limit: 1, minRelevanceScore: 0.7);
        return searchResults;
    } 

    
    public async Task<String> SummaryPlugin(string answer)
    {
        if(this.qa_plugin.Count()==0)
        {
            return "path error";
        }
        else
        {
            var result = await this.kernel.InvokeAsync(this.qa_plugin["KB"],new(){["input"] = answer});

            return result.ToString();
        }
    } 


}