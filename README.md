# Lifehack-that-makes-it-worse-api

##Documentation -[Planning](./planning.md)

# To Run

## 1. Add database connection string

Update `appsettings.json`

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
  }
}
```

---

## 2. Run database migrations

```bash
dotnet ef database update
```

---

## 3. Build and run the API

```bash
dotnet build
dotnet run
```

---

# API Endpoints

Base route:

```text
/api/advice
```

---

## Get 10 random advices

### Request

```http
GET /api/advice
```

### Response

```json
[
  {
    "id": 1,
    "text": "Use the same password everywhere",
    "categoryId": 2
  }
]
```

---

## Get random advice

### Request

```http
GET /api/advice/random
```

---

## Get advice by category

### Request

```http
GET /api/advice/category?categoryId=1
```

or

```http
GET /api/advice/GetAdviceByCategory?categoryId=1
```

---

## Get all categories

### Request

```http
GET /api/advice/categories
```

### Response

```json
[
  {
    "id": 1,
    "name": "Health"
  }
]
```

---

## Add new advice

### Request

```http
POST /api/advice/AddAdvice
```

### Body

```json
{
  "text": "Never sleep more than 2 hours",
  "categoryId": 1
}
```

---

# Features

- Random life hacks
- Category filtering
- SQL database persistence
- RESTful API
- Async service architecture

---

# Project Structure

```text
Controllers/
Services/
Repositories/
Data/
Core/
```

---