# Basic TableAdapter getting started

This repository contains a basic VB.NET project to show how to get started with using a TableAdapter.

#### Create and configure TableAdapters

[Microsoft documentation](https://docs.microsoft.com/en-us/visualstudio/data-tools/create-and-configure-tableadapters?view=vs-2019).

#### Validate data in datasets

[Microsoft documentation](https://docs.microsoft.com/en-us/visualstudio/data-tools/validate-data-in-datasets?view=vs-2019)


##### Default connection string

Data Source=**.\SQLEXPRESS**;Initial Catalog=NorthWindAzureForInserts;Integrated Security=True

If using a different server than used above change it in app.config.

#### Creating the database
Either run script.sql from Visual Studio or from SSMS (SQL-Server Management Studio) by opening the script file and pressing F5.

#### Code style
Within the code there are two code style because developers have their own style which usually falls into one of the styles used. It's easy to work into one style to the desire of each developer.

#### Who should use TableAdapters
At first glance, this way of working with data appears easy yet if time is not taken to learn about them after using the data wizard there can be countless times of frustrations.

Consider after learning how to use TableAdapter they are okay for a first step into working with databases and extremely simple projects. The better choice for working with databases is [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) which requires more coding while the rewards are many.

#### Microsoft TechNet Article

TBA



