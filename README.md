![License](https://img.shields.io/github/license/rasha-2k/PackTrack?color=blue)
---

![alt text](wwwroot/Assets/Images/logo.png)

---

# SdRasha GYM

**SdRasha GYM** is a CRUD-based Gym Management System built with **.NET Core (C#)** and **SQL Server**. It was developed as a final project for the "Database Programming" course at the Faculty of Information Technology, designed to demonstrate practical database and software development skills. This system provides gym owners with a user-friendly dashboard to manage clients and packages efficiently, replacing traditional manual methods.

---

## Table of Contents
- [Overview](#-overview)
- [Features](#-features)
- [Technologies Used](#️-technologies-used)
- [Getting Started](#-getting-started)
- [User Interface](#-user-interface)
- [Contributors](#-contributors)

---

## Overview

Gym owners often face difficulties managing memberships and packages through paper-based or inefficient systems. SdRasha GYM aims to solve this problem by providing a centralized platform for handling users, gym packages, and instructors. Although it’s a course-based prototype, it serves as a foundational example of how modern management systems can be designed using robust database technologies and clean architecture.

---

## Features

### User Management
- Add, update, delete, and search client records.
- Store detailed info: name, email, phone, DOB, gender, description, profile image.
- Signup/login functionality with email/password validation.

### Package Management
- Admins can create, edit, and delete gym packages.
- View all available packages with full details (price, duration, days).

### Instructor Integration
- Instructors can view their assigned classes and sessions.

---

## Technologies Used

| Tech Stack    | Description                              |
|---------------|------------------------------------------|
| .NET Core     | Backend framework for handling APIs      |
| C#            | Main programming language                |
| SQL Server    | Relational database for storing data     |
| HTML/CSS/JS   | Frontend interface and styling           |
| Bootstrap     | Responsive UI components (optional)      |

---

## Getting Started

### Prerequisites
- [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)
- Any IDE like **Visual Studio 2022** or **Rider**

### Steps

1. **Clone the Repo**
```bash
git clone https://github.com/rasha-2k/SdRashaGYM.git
```

2. Set up Database
- Open SQL Server Management Studio.
- Create a new database.
- Run the SQL scripts provided inside the `/Database` folder.

3. Run the Application

Open the solution file `.sln` in Visual Studio.

Press `F5` or run the application from the terminal:
```bash
dotnet run
```

## User Interface
Screenshots of the UI will be added here to demonstrate:

Here are some screenshots showcasing the user interface of SdRasha GYM:

### Home Page
The landing dashboard with quick access to user and package management.
<p align="left">
  <img src="wwwroot/Assets/Images/home-page.png" alt="Home Page" width="700"/>
</p>

---

### Register User
A form for registering a new gym member.
<p align="left">
  <img src="wwwroot/Assets/Images/add-user.png" alt="Register User" width="700"/>
</p>

---

### Client List
Table view of all registered clients with edit/delete options.
<p align="left">
  <img src="wwwroot/Assets/Images/client-list.png" alt="Client List" width="700"/>
</p>

---

### Edit Client
An edit form pre-filled with existing client data.
<p align="left">
  <img src="wwwroot/Assets/Images/edit-client.png" alt="Edit Client" width="700"/>
</p>

---

### Delete Client
Confirmation screen for deleting a user.
<p align="left">
  <img src="wwwroot/Assets/Images/delete-client.png" alt="Delete Client" width="700"/>
</p>

---

### Add Package
A form to create new gym membership packages.
<p align="left">
  <img src="wwwroot/Assets/Images/add-package.png" alt="Add Package" width="700"/>
</p>

---

## Contributors
<div style="display: flex; align-items: center; margin-bottom: 20px;">
    <a href="https://github.com/rasha-2k" style="text-decoration: none; display: flex; align-items: center;">
        <img src="https://github.com/rasha-2k.png" alt="@rasha-2k" title="@rasha-2k" width="100px" height="100px" style="border-radius: 50%; margin-right: 10px;">
    </a>
    <a href="https://github.com/Sdra-Awameh" style="text-decoration: none; display: flex; align-items: center;">
        <img src="https://github.com/Sdra-Awameh.png" alt="@awsdra" title="@awsdra" width="100px" height="100px" style="border-radius: 50%; margin-right: 10px;">
    </a>
</div>
