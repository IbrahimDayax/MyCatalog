# MyCatalog Web Application

MyCatalog is a web application for managing a catalog of books. It allows you to add, view, edit, and delete books in your collection.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- View a list of books in your catalog.
- Add new books to your catalog.
- Edit the details of existing books.
- Delete books from your catalog.

## Getting Started

These instructions will help you set up the project on your local machine for development and testing purposes.

### Prerequisites

Before you begin, ensure you have met the following requirements:

- .NET 5.0 SDK
- MySQL Server
- Visual Studio Code or Visual Studio (optional)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/MyCatalog.git
2. Change to the project directory:

   ```bash
   CREATE DATABASE mycatalog;
3. Configure the database connection string in the appsettings.json file.
4. Apply Entity Framework migrations:
   ```bash
   dotnet ef database update
5. dotnet run

### Usage

- Visit http://localhost:5000 in your web browser to access the MyCatalog web application.
- Use the web interface to add, view, edit, and delete books from your catalog.

### License
This project is licensed under the MIT License. See the LICENSE file for details.



