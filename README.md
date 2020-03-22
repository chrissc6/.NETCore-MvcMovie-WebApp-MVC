# MvcMovie

Create a web app with ASP.NET Core MVC
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.1

Package Manager Console (PMC) commands:
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Add-Migration InitialCreate
Update-Database
Add-Migration Rating
Update-Database


The Model-View-Controller (MVC) architectural pattern separates an app into three main components: 
Model, View, and Controller. 
The MVC pattern helps you create apps that are more testable and easier to update than traditional monolithic apps.

Models: Classes that represent the data of the app.
Views: Views are the components that display the app's user interface (UI).
Controllers: Classes that handle browser requests.

The MVC pattern helps you create apps that separate the different aspects of the app (input logic, 
business logic, and UI logic), 
while providing a loose coupling between these elements.

Business logic belongs in the model.
The UI logic belongs in the view.
Input logic belongs in the controller. 

Controller methods (also known as action methods)
Controller actions are invoked in response to an incoming URL request.


Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.
In the Add Scaffold dialog, select MVC Controller with views, using Entity Framework > Add.
The automatic creation of these files is known as scaffolding.

Migrations file:
The Up method creates the Movie table and configures Id as the primary key. 
The Down method reverts the schema changes made by the Up migration.

When the app is deployed to a test or production server, an environment variable can be used 
to set the connection string to a production SQL Server.

