# Chimerical Conversions: Server Component

[![Build Status](https://dev.azure.com/chimerical/Conversions/_apis/build/status/ConversionsServer)](https://dev.azure.com/chimerical/Conversions/_build/latest?definitionId=2)

An API for converting things: [conversions-api.chimerical.ca](https://conversions-api.chimerical.ca/api).

View the app component: [Chimerical Conversions: App Component](https://github.com/blake-mealey/conversions-app).

# Setup

## Windows

### Requirements

- [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
- [.NET Core 2.0 development tools](https://www.microsoft.com/net/download/visual-studio-sdks) - easier to install within the VS 2017 installer
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
- Recommended: [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download?view=sql-server-2017) or [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017)

### Steps

1. [Setup conversions-app](https://github.com/blake-mealey/conversions-app#setup)
2. Clone the repo
3. Open the ConversionsServer.sln file in VS
4. Build the solution
5. Open the appsettings.json file in the ConversionsApi project and update the [connection string](https://www.connectionstrings.com/sql-server/) for your database
6. Set the ConversionsApi as the default startup project
7. Run the program
8. Open [https://localhost:44300/api](https://localhost:44300/api) in your browser. You should see 'ConversionsApi'

## Ubuntu

### Requirements

- [dotnet core runtime](https://www.microsoft.com/net/download/linux-package-manager/ubuntu16-04/sdk-current)
- [Microsoft SQL Server](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-ubuntu?view=sql-server-2017)

### Steps

1. [Setup conversions-app](https://github.com/blake-mealey/conversions-app#setup)
2. Clone the repo
3. Run `dotnet build Conversions.sln -c Debug`
4. Open the appsettings.json file in the ConversionsApi project and update the [connection string](https://www.connectionstrings.com/sql-server/) for your database
5. Cd into ConversionsApi/bin/Debug
6. Run `dotnet ConversionsApi.dll`
7. Open [https://localhost:5001/api](https://localhost:5001/api) in your browser. You should see 'ConversionsApi'

# Development plan

View the [Trello board](https://trello.com/b/GXpwj1fU/conversions-tasks) containing the development plan.
