# **🧪  Lab 2 - Deploy to Cloud**

We created a prototype of Microsoft Fabric in Lab 1 with Semantic Kernel and Qdrant. At this time, we need to implement the development of the Copilot application. At this time, we need to combine cloud applications to realize it. There is no doubt that Microsoft Azure will be the focus of Lab 2.

## **☁️ Introduce Cloud Native**

Cloud native applications are built from the ground up—optimized for cloud scale and performance. They’re based on microservices architectures, use managed services, and take advantage of continuous delivery to achieve reliability and faster time to market.

In Copilot applications, we can fully integrate with cloud-native applications. In Lab 1, Qdrant is used locally in the form of containers, and we can deploy it in combination with Azure Kubernetes Service. For the interaction with the knowledge base, we can also publish it as a Serverless API through Azure Function.


![statck](../../imgs/intro/stack.png)

## **Deploy Qdrant in Azure Kubernetes Service**

### **What is Azure Kubernetes Service**

Azure Kubernetes Service (AKS) simplifies deploying a managed Kubernetes cluster in Azure by offloading the operational overhead to Azure. As a hosted Kubernetes service, Azure handles critical tasks, like health monitoring and maintenance. When you create an AKS cluster, a control plane is automatically created and configured. This control plane is provided at no cost as a managed Azure resource abstracted from the user. You only pay for and manage the nodes attached to the AKS cluster.

### **Deploy**

***Prerequirement***

1. Install Azure CLI [https://learn.microsoft.com/en-us/cli/azure/install-azure-cli](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli)

2. Install Heml [https://helm.sh/docs/intro/install/](https://helm.sh/docs/intro/install/)

3. Apply Azure 







