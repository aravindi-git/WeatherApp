# WeatherApp 

This project serves as an example of implementing a **structured layered architecture** for web API projects in .NET Core.

This is a refactored version of the default .NET Core Web API project template, where I have introduced several layers based on their specific responsibilities. 
The updated template now follows the principles of separation of concerns, making it more decoupled, easier to manage, and more testable compared to the original.

**Domain Layer**

The domain layer serves as the core layer of the application. 
It contains all the business logic definitions(interfaces), models, domain-specific entities, DTOs, rules, and validations that define the core problem domain.
This layer remains independent of any other application layers.

**Data Access Layer (DAL)**

The Data Access Layer is responsible for managing all database-related operations, including data processing, data retrieval, and persistence. 
Components like Entity Framework, `DbContext`, repository implementations, and database configurations are placed within this layer. It depends on the Domain layer only. 

**Service Layer**

The Data Access Layer (DAL) is solely responsible for database operations. 
The Service Layer utilizes the data access methods, processes the data, and returns the processed result to the Presentation Layer, which in this case is the Web API project.
The Service Layer should not depend on the DAL but only on the Domain Layer. Acting as an intermediary between the Domain and DAL, the Service Layer integrates them by 
retrieving data from the DAL and processing it according to the rules defined in the Domain Layer.

**Presentation Layer**

ASP.NET Core Web API project. This uses the Service layer to  fetch the results. The Dependency Injection container is in this layer. 
