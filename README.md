# DevelopingYou.API

Back end API and database for 401 midterm project.


## Badges

![.NET Core](https://github.com/Team-FIR3/DevelopingYou.API/workflows/.NET%20Core/badge.svg)  

## Installation

To add EF Core to an application, install the NuGet package.  

Entity Framework (EF) Core is a lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology.   

EF Core can serve as an object-relational mapper (O/RM), enabling .NET developers to work with a database using .NET objects, and eliminating the need for most of the data-access code they usually need to write.  

If you're building an ASP.NET Core application, you don't need to install the in-memory and SQL Server providers. Those providers are included in current versions of ASP.NET Core, alongside the EF Core runtime.  

To install or update NuGet packages, you can use the .NET Core command-line interface (CLI), the Visual Studio Package Manager Dialog, or the Visual Studio Package Manager Console.  

```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

```



## Entity Relationship Diagram
[ERD](/assets/ERD.jpg)

Developing You contains two main tables; a table containing the user's goals, and a table that involves each instance of the user working towards their goal. 
Each goal can contain starting value, a target value, a unit of measurement for their goal, and a list of categories of goals for them to work towards. 
Each goal can contain many instances, which include a date, a start time, an end time, and a spot for the user to write about it as a comment.  

We, the developers at Developing You are also working towards a strategy table that would be connected to the goals table. 
This would, in theory, allow users to have helpful links, ideas or other useful strategies to consume so they can progress towards their goal seemlessly.  



