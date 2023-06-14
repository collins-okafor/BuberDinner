# BuberDinner

This project is a CRUD (Create, Read, Update, Delete) REST API built using .NET 6. It follows the principles of Clean Architecture and Domain-Driven Design (DDD) to ensure a modular and maintainable codebase.

The purpose of this API is to manage breakfast items, allowing users to perform various operations such as creating new breakfasts, retrieving existing breakfasts, updating breakfast details, and deleting breakfasts from the system.

## Table of Contents
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Create Breakfast**: Allows users to add new breakfast items to the system.
- **Read Breakfast**: Enables users to retrieve information about specific breakfast items or retrieve a list of all available breakfasts.
- **Update Breakfast**: Allows users to modify the details of existing breakfast items.
- **Delete Breakfast**: Enables users to remove breakfast items from the system.

## Technologies

The following technologies and tools were used in the development of this API:

- .NET 6: The latest version of Microsoft's .NET framework.
- C#: The programming language used to write the API logic.
- ASP.NET Core: The web application framework used to build the REST API.
- Entity Framework Core: An Object-Relational Mapping (ORM) framework for database interactions.
- SQL Server: The relational database management system used to store breakfast data.
- Swagger: A tool for generating API documentation and providing an interactive API playground.
- xUnit: The unit testing framework used for testing the API.
- GitHub: Version control and project management platform.

## Getting Started

To get a local copy of the project up and running, follow these steps:

1. Clone the repository: `git clone git@github.com:collins-okafor/BuberDinner.git`
2. Navigate to the project directory: `cd BuberDinner`
3. Install the necessary dependencies: `dotnet restore`
4. Set up the database connection string in the `appsettings.json` file.
5. Apply database migrations: `dotnet ef database update`
6. Run the API: `dotnet run`

The API should now be running locally on `http://localhost:5000`.

<!-- ## API Endpoints

The following endpoints are available in this API:

- `GET /api/breakfasts`: Retrieves a list of all breakfast items.
- `GET /api/breakfasts/{id}`: Retrieves a specific breakfast item by its ID.
- `POST /api/breakfasts`: Creates a new breakfast item.
- `PUT /api/breakfasts/{id}`: Updates an existing breakfast item.
- `DELETE /api/breakfasts/{id}`: Deletes a breakfast item.

For detailed information on request and response formats, please refer to the API documentation available at `/swagger`.

## Testing

Unit tests have been written to ensure the functionality and stability of the API. To run the tests, use the following command:

```bash
dotnet test
``` -->

## Contributing
Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License. Feel free to use and modify the code as per the terms of the license.