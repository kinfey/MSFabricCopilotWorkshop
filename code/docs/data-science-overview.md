---
title: Data science in Microsoft Fabric
description: Learn about the Data science machine learning resources, including models, experiments, and notebooks.
author: nelgson
ms.author: negust
ms.reviewer: franksolomon
ms.topic: overview
ms.custom: build-2023, build-2023-dataai, build-2023-fabric
ms.date: 03/24/2023

ms.search.form: Data Science Overview
---

# What is Data Science in Microsoft Fabric?

[!INCLUDE [preview-note](../includes/preview-note.md)]
[!INCLUDE [product-name](../includes/product-name.md)] offers  Data Science experiences to empower users to complete end-to-end data science workflows for the purpose of data enrichment and business insights. You can complete a wide range of activities across the entire data science process, all the way from data exploration, preparation and cleansing to experimentation, modeling, model scoring and serving of predictive insights to BI reports.

[!INCLUDE [product-name](../includes/product-name.md)] users can access a Data Science Home page. From there, they can discover and access various relevant resources. For example, they can create machine learning Experiments, Models and Notebooks. They can also import existing Notebooks on the Data Science Home page.

:::image type="content" source="media/data-science-overview/data-science-home-page.png" alt-text="Screenshot of the Data science home page." lightbox="media/data-science-overview/data-science-home-page.png":::

You might know how a typical data science process works. As a well-known process, most machine learning projects follow it.

At a high level, the process involves these steps:

- Problem formulation and ideation  
- Data discovery and pre-processing
- Experimentation and modeling
- Enrich and operationalize
- Gain insights

:::image type="content" source="media/data-science-overview/data-science-process.png" alt-text="Diagram of data science process." lightbox="media/data-science-overview/data-science-process.png":::

This article describes the [!INCLUDE [product-name](../includes/product-name.md)] Data Science capabilities from a data science process perspective. For each step in the data science process, this article summarizes the [!INCLUDE [product-name](../includes/product-name.md)] capabilities that can help.

## Problem formulation and ideation

Data Science users in [!INCLUDE [product-name](../includes/product-name.md)] work on the same platform as business users and analysts. Data sharing and collaboration becomes more seamless across different roles as a result. Analysts can easily share Power BI reports and datasets with data science practitioners. The ease of collaboration across roles in [!INCLUDE [product-name](../includes/product-name.md)] makes hand-offs during the problem formulation phase much easier. 

## Data Discovery and pre-processing 

[!INCLUDE [product-name](../includes/product-name.md)] users can interact with data in OneLake using the Lakehouse item. Lakehouse easily attaches to a Notebook to browse and interact with data.

Users can easily read data from a Lakehouse directly into a Pandas dataframe. For exploration, this makes seamless data reads from One Lake possible.

There's a powerful set of tools is available for data ingestion and data orchestration pipelines with data integration pipelines - a natively integrated part of [!INCLUDE [product-name](../includes/product-name.md)]. Easy-to-build data pipelines can access and transform the data into a format that machine learning can consume.

### Data exploration

An important part of the machine learning process is to understand data through exploration and visualization.

Depending on the data storage location, [!INCLUDE [product-name](../includes/product-name.md)] offers a set of different tools to explore and prepare the data for analytics and machine learning. Notebooks become one of the quickest ways to get started with data exploration.

### Apache Spark and Python for data preparation

[!INCLUDE [product-name](../includes/product-name.md)] offers capabilities to transform, prepare, and explore your data at scale. With Spark, users can leverage PySpark/Python, Scala, and SparkR/SparklyR tools for data pre-processing at scale. Powerful open-source visualization libraries can enhance the data exploration experience to help better understand the data. 

### Data Wrangler for seamless data cleansing

The [!INCLUDE [product-name](../includes/product-name.md)] Notebook experience added a feature to use Data Wrangler, a code tool that prepares data and generates Python code. This experience makes it easy to accelerate tedious and mundane tasks - for example, data cleansing, and build repeatability and automation through generated code. Learn more about Data Wrangler in the Data Wrangler section of this document.

## Experimentation and ML modeling

With tools like PySpark/Python, SparklyR/R, notebooks can handle machine learning model training.

ML algorithms and libraries can help train machine learning models. Library management tools can install these libraries and algorithms. Users have therefore the option to leverage a large variety of popular machine learning libraries to complete their ML model training in [!INCLUDE [product-name](../includes/product-name.md)].

Additionally, popular libraries like Scikit Learn can also develop models.  

MLflow experiments and runs can track the ML model training. [!INCLUDE [product-name](../includes/product-name.md)] offers a built-in MlFlow experience with which users can interact, to log experiments and models. Learn more about how to use MLflow to track experiments and manage models in [!INCLUDE [product-name](../includes/product-name.md)].

### SynapseML
 
The SynapseML (previously known as MMLSpark) open-source library, that Microsoft owns and maintains, simplifies massively scalable machine learning pipeline creation. As a tool ecosystem, it expands the Apache Spark framework in several new directions. SynapseML unifies several existing machine learning frameworks and new Microsoft algorithms into a single, scalable API. The open-source SynapseML library includes a rich ecosystem of ML tools for development of predictive models, as well as leveraging pre-trained AI models from Azure Cognitive Services. Learn more about [SynapseML](https://aka.ms/spark).


## Enrich and operationalize
Notebooks can handle machine learning model batch scoring with open-source libraries for prediction, or the [!INCLUDE [product-name](../includes/product-name.md)] scalable universal Spark Predict function, which supports mlflow packaged models in the [!INCLUDE [product-name](../includes/product-name.md)] model registry.

### Gain insights

In [!INCLUDE [product-name](../includes/product-name.md)], Predicted values can easily be written to OneLake, and seamlessly consumed from Power BI reports, with the Power BI Direct Lake mode. This makes it very easy for data science practitioners to share results from their work with stakeholders and it also simplifies operationalization.

Notebooks that contain batch scoring can be scheduled to run using the Notebook scheduling capabilities. Batch scoring can also be scheduled as part of data pipeline activities or Spark jobs. Power BI automatically gets the latest predictions without need for loading or refresh of the data, thanks to the Direct lake mode in [!INCLUDE [product-name](../includes/product-name.md)].

## Next steps

- Get started with end-to-end data science samples, see Data Science Tutorials
- Learn more about data preparation and cleansing with Data Wrangler, see [Data Wrangler](data-wrangler.md)
- Learn more about tracking experiments, see [Machine learning experiment](machine-learning-experiment.md)
- Learn more about managing models, see [Machine learning model](machine-learning-model.md)
- Learn more about batch scoring with Predict, see [Score models with PREDICT](model-scoring-predict.md)
- Serve predictions from Lakehouse to Power BI with [Direct lake Mode ](../data-engineering/lakehouse-pbi-reporting.md)
