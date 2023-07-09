using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.SemanticFunctions;
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.SkillDefinition;
using Microsoft.SemanticKernel.Text;
using Microsoft.SemanticKernel.Connectors.Memory.Qdrant;

namespace MSFabricBots.Kernel;

public class KernelSettings
{
    IKernel kernel;
    IConfigurationRoot configuration;

    IDictionary<string, ISKFunction> qa_skill;

    IDictionary<string, ISKFunction> content_skill;

    string skillsDirectory;

    AzureOpenAIConfiguration azureOpenAIConfiguration;

    public KernelSettings(IConfigurationRoot configuration,string skillsDirectory)
    {
        this.configuration = configuration;
        this.skillsDirectory = skillsDirectory;
        this.azureOpenAIConfiguration = this.configuration.GetSection("AzureOpenAI").Get<AzureOpenAIConfiguration>();
        this.kernel = Microsoft.SemanticKernel.Kernel.Builder
                .WithAzureChatCompletionService(azureOpenAIConfiguration.deployName, azureOpenAIConfiguration.endpoint, azureOpenAIConfiguration.apiKey)
                .WithAzureTextEmbeddingGenerationService(azureOpenAIConfiguration.embeddingDeployName, azureOpenAIConfiguration.endpoint, azureOpenAIConfiguration.apiKey)
                .WithQdrantMemoryStore(azureOpenAIConfiguration.vectorDBEndpoint, 1536)
                .Build();

        this.content_skill = kernel.ImportSemanticSkillFromDirectory(this.skillsDirectory,"ReadSkill");
        this.qa_skill = kernel.ImportSemanticSkillFromDirectory(this.skillsDirectory,"QASkill");
    }

    public IAsyncEnumerable<Microsoft.SemanticKernel.Memory.MemoryQueryResult> AskSkill(string questionText)
    {
        var searchResults =  kernel.Memory.SearchAsync(this.azureOpenAIConfiguration.memoryCollectionName, questionText, limit: 1, minRelevanceScore: 0.8);
        return searchResults;
    } 

    
    public async Task<SKContext> SummarySkill(string answer)
    {
        var result = await this.kernel.RunAsync(answer, this.qa_skill["KB"]);

        return result;
    } 


}