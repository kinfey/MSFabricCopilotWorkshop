---
title: Microsoft Fabric terminology
description: Learn the definitions of terms used in Microsoft Fabric, including terms specific to Synapse Data Warehouse, Synapse Data Engineering, and Synapse Data Science.
ms.reviewer: sngun
ms.author: sngun
author: SnehaGunda
ms.topic: conceptual
ms.custom: build-2023
ms.search.form: product-trident
ms.date: 05/23/2023
---

# Microsoft Fabric terminology

Learn the definitions of terms used in Microsoft Fabric, including terms specific to Synapse Data Warehouse, Synapse Data Engineering, Synapse Data Science, Synapse Real-Time Analytics, Data Factory, and Power BI.

[!INCLUDE [preview-note](../includes/preview-note.md)]

## General terms

- **Capacity:** Capacity is a dedicated set of resources that is available at a given time to be used. Capacity defines the ability of a resource to perform an activity or to produce output. Different items consume different capacity at a certain time. Fabric offers capacity through the Fabric SKU and Trials. For more information, see [What is capacity?](../enterprise/licenses.md#capacity)

- **Experience:** A collection of capabilities targeted to a specific functionality. The Fabric experiences include Synapse Data Warehouse, Synapse Data Engineering, Synapse Data Science, Synapse Real-Time Analytics, Data Factory and Power BI.

- **Item:** An item a set of capabilities within an experience. Users can create, edit, and delete them. Each item type provides different capabilities. For example, the Data Engineering experience includes the lakehouse, notebook, and Spark job definition items.

- **Tenant:** A tenant is a single instance of Fabric for an organization and is aligned with an Azure Active Directory.

- **Workspace:** A workspace is a collection of items that brings together different functionality in a single environment designed for collaboration. It acts as a container that leverages capacity for the work that is executed, and provides controls for who can access the items in it. For example, in a workspace, users create reports, notebooks, datasets, etc. For more information, see [Workspaces](workspaces.md) article.

## Synapse Data Engineering

- **Lakehouse:** A lakehouse is a collection of files, folders, and tables that represent a database over a data lake used by the Apache Spark engine and SQL engine for big data processing. A lakehouse includes enhanced capabilities for ACID transactions when using the open-source Delta formatted tables. The lakehouse item is hosted within a unique workspace folder in [Microsoft OneLake](../onelake/onelake-overview.md). It contains files in various formats (structured and unstructured) organized in folders and subfolders. For more information, see [What is a lakehouse?](../data-engineering/lakehouse-overview.md)

- **Notebook:** A Fabric notebook is a multi-language interactive programming tool with rich functions. Which include authoring code and markdown, running and monitoring a Spark job, viewing and visualizing result, and collaborating with the team. It helps data engineers and data scientist to explore and process data, and build machine learning experiments with both code and low-code experience. It can be easily transformed to a pipeline activity for orchestration.

- **Spark application:** An Apache Spark application is a program written by a user using one of Spark's API languages (Scala, Python, Spark SQL, or Java) or Microsoft-added languages (.NET with C# or F#). When an application runs, it's divided into one or more Spark jobs that run in parallel to process the data faster. For more information, see [Spark application monitoring](../data-engineering/spark-detail-monitoring.md).

- **Apache Spark job:** A Spark job is part of a Spark application that is run in parallel with other jobs in the application. A job consists of multiple tasks. For more information, see [Spark job monitoring](../data-engineering/spark-monitor-debug.md).

- **Apache Spark job definition:** A Spark job definition is a set of parameters, set by the user, indicating how a Spark application should be run. It allows you to submit batch or streaming jobs to the Spark cluster. For more information, see [What is an Apache Spark job definition?](../data-engineering/spark-job-definition.md)

- **V-order:** A write optimization to the parquet file format that enables fast reads and provides cost efficiency and better performance. All the Fabric engines write v-ordered parquet files by default.

## Data Factory

- **Connector:** Data Factory offers a rich set of connectors that allow you to connect to different types of data stores. Once connected, you can transform the data. For more information, see [connectors](../data-factory/connector-overview.md).

- **Data pipeline:** In Data Factory, a data pipeline is used for orchestrating data movement and transformation. These pipelines are different from the deployment pipelines in Fabric. For more information, see [Pipelines](../data-factory/data-factory-overview.md#data-pipelines) in the Data Factory overview.

- **Dataflow Gen2:** Dataflows provide a low-code interface for ingesting data from hundreds of data sources and transforming your data. Dataflows in Fabric are referred to as Dataflow Gen2. Dataflow Gen1 exists in Power BI. Dataflow Gen2 offers extra capabilities compared to Dataflows in Azure Data Factory or Power BI. You can't upgrade from Gen1 to Gen2. For more information, see [Dataflows](../data-factory/data-factory-overview.md#dataflows) in the Data Factory overview.

## Synapse Data Science

- **Data Wrangler:** Data Wrangler is a notebook-based tool that provides users with an immersive experience to conduct exploratory data analysis. The feature combines a grid-like data display with dynamic summary statistics and a set of common data-cleansing operations, all available with a few selected icons. Each operation generates code that can be saved back to the notebook as a reusable script.

- **Experiment:** A machine learning experiment is the primary unit of organization and control for all related machine learning runs. For more information, see [Machine learning experiments in Microsoft Fabric](../data-science/machine-learning-experiment.md).

- **Model:** A machine learning model is a file trained to recognize certain types of patterns. You train a model over a set of data, and you provide it with an algorithm that it uses to reason over and learn from that data set. For more information, see [Machine learning model](../data-science/machine-learning-model.md).

- **Run:** A run corresponds to a single execution of model code. In [MLflow](https://mlflow.org/), tracking is based on experiments and runs.

## Synapse data warehousing

- **SQL Endpoint:** Each Lakehouse has a SQL Endpoint that allows a user to query delta table data with TSQL over TDS. For more information, see [SQL Endpoint](../data-warehouse/data-warehousing.md#sql-endpoint-of-the-lakehouse).

- **Synapse Data Warehouse:** The Synapse Data Warehouse functionality is a traditional data warehouse and supports the full transactional T-SQL capabilities you would expect from an enterprise data warehouse. For more information, see [Synapse Data Warehouse](../data-warehouse/data-warehousing.md#synapse-data-warehouse).

## Synapse Real-Time Analytics

- **KQL database:** The KQL database is the representation of a database holding data in a format to execute a KQL query against it. For more information, see [Query a KQL database](../real-time-analytics/jupyter-notebook.md).

- **KQL Queryset:** The KQL Queryset is the item used to run queries, view results, and manipulate query results on data from your Data Explorer database. The queryset includes the databases and tables, the queries, and the results. The KQL Queryset allows you to save queries for future use, or export and share queries with others. For more information, see [Query data in the KQL Queryset](../real-time-analytics/kusto-query-set.md)

- **Event stream:** The Microsoft Fabric event streams feature provides a centralized place in the Fabric platform to capture, transform, and route real-time events to destinations with a no-code experience. An event stream consists of various streaming data sources, ingestion destinations, and an event processor when the transformation is needed. For more information, see [Microsoft Fabric event streams](../real-time-analytics/event-streams/overview.md).

## OneLake

- **Shortcut:** Shortcuts are embedded references within OneLake that point to other file store locations. They provide a way to connect to existing data without having to directly copy it. For more information, see [OneLake shortcuts](../onelake/onelake-shortcuts.md).

## Next steps

- [Navigate to your items from Microsoft Fabric Home page](fabric-home.md)
- [Discover data items in the OneLake data hub](onelake-data-hub.md)
- [End-to-end tutorials in Microsoft Fabric](end-to-end-tutorials.md)
