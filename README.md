# Conversions Server

[![Build Status](https://dev.azure.com/chimerical/Conversions/_apis/build/status/ConversionsServer)](https://dev.azure.com/chimerical/Conversions/_build/latest?definitionId=2)

The API and database for [conversions-app](https://github.com/blake-mealey/conversions-app). Hosted on [conversions-api.chimerical.ca](https://conversions-api.chimerical.ca/api).

# Setup

## Windows

### Requirements

- [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
- [.NET Core 2.0 development tools](https://www.microsoft.com/net/download/visual-studio-sdks) - easier to install within the VS 2017 installer
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
- Recommended: [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download?view=sql-server-2017) or [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017)

### Steps

1. Clone the repo
2. Open the ConversionsServer.sln file in VS
3. Build the solution
4. Open the appsettings.json file in the ConversionsApi project and update the [connection string](https://www.connectionstrings.com/sql-server/) for your database
5. Set the ConversionsApi as the default startup project
6. Run the program
7. Open [https://localhost:44300/api](https://localhost:44300/api) in your browser. You should see 'ConversionsApi'
8. [Setup conversions-app](https://github.com/blake-mealey/conversions-app#setup)

## Ubuntu

### Requirements

- [dotnet core runtime](https://www.microsoft.com/net/download/linux-package-manager/ubuntu16-04/sdk-current)
- [Microsoft SQL Server](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-ubuntu?view=sql-server-2017)

### Steps

1. Clone the repo
2. Run `dotnet build Conversions.sln -c Debug`
3. Open the appsettings.json file in the ConversionsApi project and update the [connection string](https://www.connectionstrings.com/sql-server/) for your database
4. Cd into ConversionsApi/bin/Debug
5. Run `dotnet ConversionsApi.dll`
6. Open [https://localhost:5001/api](https://localhost:5001/api) in your browser. You should see 'ConversionsApi'
7. [Setup conversions-app](https://github.com/blake-mealey/conversions-app#setup)
