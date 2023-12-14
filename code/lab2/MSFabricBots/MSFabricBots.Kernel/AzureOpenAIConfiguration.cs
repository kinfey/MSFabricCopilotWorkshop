namespace MSFabricBots.Kernel;

public class AzureOpenAIConfiguration
{
        public string deployName {get;set;}
        public string endpoint {get;set;}
        // public string modelID {get;set;}        
        public string apiKey {get;set;}
        public string embeddingDeployName {get;set;}
        // public string embeddingID {get;set;}    
        public string vectorDBEndpoint {get;set;}
        public string memoryCollectionName {get;set;}

        public AzureOpenAIConfiguration(string deployName, string endpoint, string apiKey, string embeddingDeployName, string vectorDBEndpoint,string memoryCollectionName)
        {
            this.deployName = deployName;
            this.endpoint = endpoint;
            this.apiKey = apiKey;
            this.embeddingDeployName = embeddingDeployName;
            this.vectorDBEndpoint = vectorDBEndpoint;
            this.memoryCollectionName = memoryCollectionName;
        }
}