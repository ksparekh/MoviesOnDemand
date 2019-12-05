
# ASP.Net Core 3.1 WebAPI with EF Core In-Memory Database implementation

Design and implement a WebAPI service project which is production ready for Internet Movies
On Demand service.

● Register new user (For Admin &amp; Viewer)
● Login (For Admin &amp; Viewer)
● Create new Category of Videos (Only for Admin)
● Add new videos to a category ( Only for Admin)
● Get list of categories &amp; videos (For Admin &amp; Viewer)
● Delete a category (Only for Admin)
● Update video description (Only for Admin)

# Folder Structure

Controllers -> REST endpoint controller
Data -> DB Context Class, Repository Interface and Concrete Implementation of Repository for the DB Context
Models -> Movie and User specific Model classes
RepositoryServiceLocator -> Service Locator to locate the Repository of DB Context
Utils -> Password Encryption Utility

# Design Patterns Implemented

1. DB Context for EF Core SQLite In-Memory Database.
2. Repository Pattern encompassing the DB Context implementation.
3. Adapter Pattern using Service Locator to locate the Repository of the DB Context.
4. Singleton object of the DB Context in Startup class.
5. Dependency Injection used across application to inject the classes that builds the operations of DB Context.
6. Linq-Lambda Used wherever applicable.

# Status of Implementation

# 05-Dec-2019

- The application is still work in progress.
- Postman collection is also added with the code.
- The application is not running as of today, due to version mismatch of various packages.
- The code is developed with better error responses.

# Pending Implementation

1. Movies &amp; Category DB operations.
2. Movies &amp; Category Controllers.
3. Password encryption logic to be plugged to the Registration and Login implementation.

# Articles/Help referred during implementation

1. https://www.simongilbert.net/entity-framework-in-memory-crud-aspdotnetcore-webapi

2. https://stackoverflow.com/a/2138588/64938

3. https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation

4. https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-3.1

5. https://docs.microsoft.com/en-us/ef/core/

