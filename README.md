# API Consumption and Creation Project

## Project Overview

This project demonstrates how to **create APIs** and **consume them** in an MVC application. It includes:
- **UI implementation** to consume API endpoints.
- **Swagger documentation** for testing APIs.
- Integration of **HttpClient** in the MVC project to call the API endpoints.

### API and UI Endpoints

- **API Swagger Documentation**:  
  Use the following URL to test the APIs via **Swagger**:
  - [Swagger UI](https://localhost:7002/swagger/index.html)
  
  Swagger provides a web-based interface to interact with and test the available API endpoints.

- **UI for API Consumption**:  
  The UI is available at the following URL in the MVC application:
  - [Product UI for API consumption](https://localhost:7001/Product)

  The UI provides two main functionalities:
  1. **GET Hello**: A button that sends a GET request to retrieve a "Hello" message from the API.
  2. **GET Personalized Hello**: A form that accepts user input (name) and returns a personalized "Hello {name}" message.

---

### Features

#### 1. API Endpoints
- **GET Hello**:
  - **URL**: `/api/Home`
  - **Description**: Returns a basic "Hello" message.
  
- **GET Personalized Hello**:
  - **URL**: `/api/Home/hello?name={name}`
  - **Description**: Returns a personalized greeting message ("Hello {name}").

#### 2. UI Implementation
- **GET Hello**:
  - A button in the UI triggers the **GET Hello** API endpoint and displays the response.
  
- **GET Personalized Hello**:
  - A form in the UI accepts user input and sends a request to the **GET Personalized Hello** API endpoint. The personalized message is displayed on the page.

---

### How to Run the Project

#### Prerequisites
- **.NET SDK** (version 6 or later) installed.
- **Visual Studio** or any other IDE supporting .NET development.
- **SQL Server** (if your project involves a database, although not covered in this README).

#### Steps to Run

1. **Run the API Project**:
   - Navigate to the API project folder in the command line and run:
     ```bash
     dotnet run
     ```
   - Alternatively, open the **API project** in Visual Studio and press `F5` to run it.
   - The API will be accessible at `https://localhost:7002`.

2. **Run the MVC Project**:
   - Navigate to the MVC project folder in the command line and run:
     ```bash
     dotnet run
     ```
   - Alternatively, open the **MVC project** in Visual Studio and press `F5` to run it.
   - The UI will be accessible at `https://localhost:7001/Product`.

---

### Technologies Used

- **ASP.NET Core Web API**: For creating the backend API.
- **ASP.NET Core MVC**: For the frontend and UI to consume the API.
- **Swagger**: For API testing and documentation.
- **HttpClient**: For making API calls from the MVC project to the API project.
- **Visual Studio 2022**: For project development and debugging.
  
---

### Current Status
- The API and UI for consuming **GET Hello** and **GET Personalized Hello** endpoints have been implemented.
- Swagger documentation is fully functional for testing the APIs.
  
**Note**: This is an ongoing project, and more features and enhancements will be added in future updates.
