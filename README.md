# 📚 API Aluno

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

API REST desenvolvida em ASP.NET Core com Entity Framework Core, destinada à gestão de alunos em ambiente educacional. Contempla operações CRUD e está pronta para uso em ambientes de desenvolvimento e produção com suporte Docker.

## 🚀 Tecnologias

- .NET 9.0 (preview ou nightly build)
- ASP.NET Core
- Entity Framework Core
- SQLite (banco padrão)
- Docker

## 📦 Como rodar localmente

### 🔧 Pré-requisitos

- [.NET SDK 9.0+](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- Git

### 🔁 Clonando o projeto

```bash
git clone https://github.com/LeonardoLBraga/ApiAluno.git
cd ApiAluno
```

### ▶️ Rodando via terminal

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Acesse em: [https://localhost:5001](https://localhost:5001)

---

## 🐳 Rodando com Docker

### 1. Build da imagem

```bash
docker build -t apialuno .
```

### 2. Rodar o container

```bash
docker run -d -p 5000:80 --name apialuno apialuno
```

A API estará acessível em: [http://localhost:5000](http://localhost:5000)

---

## 🔗 Endpoints REST

| Método | Rota             | Descrição              |
|--------|------------------|------------------------|
| GET    | /api/aluno       | Lista todos os alunos  |
| POST   | /api/aluno       | Cria um novo aluno     |
| PUT    | /api/aluno/{id}  | Atualiza um aluno      |
| DELETE | /api/aluno/{id}  | Remove um aluno        |

> A estrutura pode ser ajustada conforme sua `AlunoController.cs`.

---

## 🧪 Testes

> (Adicione aqui se houver projeto de testes ou recomendações de ferramenta como xUnit, NUnit etc.)

---

## 📁 Estrutura

- `Controllers/` — Controladores MVC da API
- `Models/` — Modelos de dados (ex: Aluno)
- `Data/` — `AppDbContext` do EF Core
- `Migrations/` — Arquivos gerados pelo `dotnet ef`
- `Program.cs` — Entry point da aplicação

---


// pasta docker
docker-compose up -d --build

docker-compose up -d
docker-compose down

// migrations
dotnet ef migrations add InitialCreate
dotnet ef database update

//run
dotnet restore
dotnet build
dotnet run --console

http://localhost:5000/api/Alunos

// Se você usar Entity Framework Core para gerenciar o banco de dados, basta rodar as migrations diretamente no container.
docker-compose exec webapi dotnet ef database update


// dependencias instaladas
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.OpenApi
dotnet add package Swashbuckle.AspNetCore

//docker
docker ps
docker exec -it aspnetcore_api bash
127.0.0.1,1433