# Minimal API Todo App
This is a simple Todo application built using ASP.NET Core Minimal API with SQLite as the database. The project uses Entity Framework Core (EF Core) as the ORM for data management.

## Features
- Add, update, delete, and retrieve todos
- Uses SQLite for database
- Minimal API for a lightweight and efficient web application
- Entity Framework Core as the ORM
## Requirements
- .NET (>=8.0 SDK)
- SQLite
## Getting Started
Clone the Repository
```bash
git clone https://github.com/monkeyK1n9/TodoAppMinimalAPI
cd todo-minimal-api
```
## Setup Database
Open the project folder in your terminal.
Run the following commands to apply migrations and update the database:
```bash
dotnet ef database update
```
## Run the Application
To run the application locally:

```bash
dotnet run
```
The app will start on http://localhost:5179.

## API Endpoints
- GET /todos - Get all todos
- GET /todos/{id} - Get a specific todo by ID
- POST /todos - Create a new todo
- PUT /todos/{id} - Update a todo
- DELETE /todos/{id} - Delete a todo
Example Todo Model
```json
{
  "id": 1,
  "title": "Buy groceries",
  "isComplete": false
}
```
## Contributing
Contributions are welcome! Please fork this repository and submit pull requests with improvements or bug fixes. For major changes, please open an issue first to discuss what you would like to change.

## License
This project is licensed under the MIT License - see the [LICENSE](./LICENSE) file for details.