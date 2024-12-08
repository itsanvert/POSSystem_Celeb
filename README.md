# POS System

This is a Point of Sale (POS) system designed to manage various entities related to inventory, sales, and finances, including customers, suppliers, categories, items, invoices, and imports. The application uses **SQL Server** as the database backend.

## Table of Contents

- [Project Description](#project-description)
- [Features](#features)
- [Modules and Responsibilities](#modules-and-responsibilities)
- [Installation Instructions](#installation-instructions)
- [Usage](#usage)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [License](#license)

## Project Description

The POS System allows users to manage customers, suppliers, products, inventory imports, invoices, and more. It supports CRUD (Create, Read, Update, Delete) operations for each module and uses **SQL Server** as the database.

## Features

- **Customers**: Add, update, and delete customer records.
- **Suppliers**: Manage supplier information.
- **Categories**: Define product categories.
- **Items**: Track inventory items and products.
- **Imports**: Manage import transactions and details.
- **Invoices**: Generate and update invoices for transactions.

## Modules and Responsibilities

The project consists of several modules, each responsible for a specific part of the system. Below is the list of modules and the individuals responsible for them:

### 1. Customers
- **Actions**: Create, List, Update, Delete
- **Responsible**: Morng Samrith

### 2. Suppliers
- **Actions**: Create, List, Update, Delete
- **Responsible**: Ka Broseth

### 3. Categories
- **Actions**: Create, List, Update, Delete
- **Responsible**: Hong Bunleap

### 4. Items
- **Actions**: Create, List, Update, Delete
- **Responsible**: Chhoun Sinan

### 5. Imports
- **Actions**: Create, List, Update, Delete
- **Responsible**: Chhoam Sovanarak

### 6. Import Details
- **Actions**: Create, List, Update, Delete
- **Responsible**: San Vert

### 7. Invoices
- **Actions**: Create, List, Update, Delete
- **Responsible**: Yi Sopheak, Chanthen, San Vert

### 8. Invoice Details
- **Actions**: Create, List, Update, Delete
- **Responsible**: [To be assigned if necessary]

## Installation Instructions

Follow the steps below to get your local development environment set up.

### Prerequisites

Ensure the following are installed:
- [Node.js](https://nodejs.org/) (for running the application)
- [Git](https://git-scm.com/) (for version control)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) (SQL Server 2019 or later)
- SQL Server Management Studio (SSMS) or another SQL Server client to manage the database.

### Steps to Install

1. **Clone the repository**:
   
   ```bash
   git clone https://github.com/your-username/POS_System.git
