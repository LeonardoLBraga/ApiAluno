# 📚 API Aluno

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
