---
title: What is Data engineering in Microsoft Fabric?
description: Learn about Data engineering core concepts in Microsoft Fabric and the analytics functionality it offers. 
ms.reviewer: snehagunda
ms.author: avinandac
author: avinandaMS
ms.topic: overview
ms.custom: build-2023, build-2023-dataai, build-2023-fabric
ms.date: 05/23/2023
---

# What is Data engineering in Microsoft Fabric?

Data engineering in Microsoft Fabric enables users to design, build, and maintain infrastructures and systems that enable their organizations to collect, store, process, and analyze large volumes of data.

[!INCLUDE [preview-note](../includes/preview-note.md)]

Microsoft Fabric provides various data engineering capabilities to ensure that your data is easily accessible, well-organized, and of high-quality. From the data engineering homepage, you can:

- Create and manage your data using a lakehouse

- Design pipelines to copy data into your lakehouse

- Use Spark Job definitions to submit batch/streaming job to Spark cluster

- Use notebooks to write code for data ingestion, preparation, and transformation

  :::image type="content" source="media\data-engineering-overview\data-engineering-artifacts.png" alt-text="Screenshot showing Data Engineering objects.":::

## Lakehouse

Lakehouses are data architectures that allow organizations to store and manage structured and unstructured data in a single location, using various tools and frameworks to process and analyze that data. This can include SQL-based queries and analytics, as well as machine learning and other advanced analytics techniques.

## Apache Spark job definition

Spark job definitions are set of instructions that define how to execute a job on a Spark cluster. It includes information such as the input and output data sources, the transformations, and the configuration settings for the Spark application. Spark job Definition allows you to submit batch/streaming job to Spark cluster, apply different transformation logic to the data hosted on your Lakehouse along with many other things.

## Notebook

Notebooks are an interactive computing environment that allows users to create and share documents that contain live code, equations, visualizations, and narrative text. They allow users to write and execute code in various programming languages, including Python, R, and Scala and are used for data ingestion, preparation, analysis, and other data-related tasks.

## Data pipeline

Data pipelines are a series of steps that are used to collect, process, and transform data from its raw form to a format that can be used for analysis and decision-making. They're a critical component of data engineering, as they provide a way to move data from its source to its destination in a reliable, scalable, and efficient way.

## Next steps

Get started with the Data Engineering experience:

- Learn more about Lakehouse, see [What is a Lakehouse?](lakehouse-overview.md).

- To get started with a Lakehouse, see [Creating a Lakehouse](create-lakehouse.md).

- Learn more about Apache Spark job definitions, see [What is an Apache Spark job definition?](spark-job-definition.md).

- To get started with an Apache Spark job definition, see [Creating a Apache Spark job definition](create-spark-job-definition.md).

- Learn more about Notebooks, see [Author and execute the notebook](author-execute-notebook.md).

- To get started with Pipelines copy activity, see [How to copy data using copy activity](..\data-factory\copy-data-activity.md).
