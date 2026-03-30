# Pet Management API

A simple CRUD API for managing pets built with C# and ASP.NET Core. This project is designed as an introductory study to review fundamental API concepts and structure.

## 📋 Project Overview

This is a basic Pet Management API that demonstrates core REST API operations without business logic or database persistence. It's perfect for beginners to understand the structure and flow of a typical API endpoint.

**Purpose**: Educational project for reviewing C# ASP.NET API fundamentals.

## 🛠️ Technologies Used

- **Framework**: ASP.NET Core
- **Language**: C#
- **Architecture**: REST API
- **HTTP Methods**: GET, POST, PUT, DELETE

## 📁 Project Structure

```
Petfolio/
├── Petfolio.API/
├── Petfolio.Application/
└── Petfolio.Communication/
```

## ✨ Features

The API provides the following endpoints for pet management:

### Endpoints

#### **GET All Pets**
```
GET /Pet/All
```
Retrieves a list of all pets.

**Response:**
```json
{
  "pets": [
    {
      "id": 0,
      "name": "string",
      "type": 0
    }
  ]
}
```

---

#### **GET Pet by ID**
```
GET /Pet/{id}
```
Retrieves a specific pet by its ID.

**Parameters:**
- `id` (int) - The pet ID

**Response:**
```json
{
  "id": 0,
  "name": "string",
  "birthday": "2026-03-30T13:28:38.918Z",
  "type": 0
}
```

---

#### **CREATE Pet**
```
POST /Pet
```
Creates a new pet.

**Request Body:**
```json
{
  "name": "string",
  "birthday": "2026-03-30T13:29:18.639Z",
  "type": 0
}
```

**Response:**
```json
{
  "id": 0,
  "name": "string"
}
```

---

#### **UPDATE Pet**
```
PUT /Pet/{id}
```
Updates an existing pet.

**Parameters:**
- `id` (int) - The pet ID

**Request Body:**
```json
{
  "name": "string",
  "birthday": "2026-03-30T13:29:45.820Z",
  "type": 0
}
```

**Response:** Status 204 (No Content) on success

---

#### **DELETE Pet**
```
DELETE /Pet/{id}
```
Deletes a pet by its ID.

**Parameters:**
- `id` (int) - The pet ID

**Response:** Status 204 (No Content) on success

---

## 📝 Pet Model

```csharp
public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int Type { get; set; }
}
```

---

**Note**: This is a study project. For production use, you should add proper database integration, error handling, validation, and security measures.