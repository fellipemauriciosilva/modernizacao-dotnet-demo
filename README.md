# 🚀 Projeto de Modernização .NET | modernizacao-dotnet-demo

Este repositório é uma **prova de conceito (PoC)** completa que acompanha o workshop de modernização de sistemas ASP.NET MVC monolíticos com foco em boas práticas de arquitetura, frontend moderno e DevOps.

---

## 📦 Estrutura do Repositório

modernizacao-dotnet-demo/

- `legacy-mvc/` # Simulação de sistema legado ASP.NET MVC com Razor e JS acoplado
- `backend-api-dotnet6/` # API moderna com .NET 6 + Clean Architecture
- `frontend-react/` # Frontend moderno (SPA) com React + Axios + Yup
- `bff-gateway/` # Backend for Frontend adaptando dados do legado para o frontend
- `devops-pipeline/` # Arquivos de automação com Azure Pipelines e Docker Compose
- `docs/` # Diagramas e imagens do workshop
- `README.md`
---

## 🧱 Tecnologias Usadas

- **.NET 6**, Clean Architecture, Minimal API, FluentValidation
- **ASP.NET MVC 5** com Razor (legado)
- **React**, Axios, Yup, Vite
- **Docker**, Docker Compose
- **Azure DevOps**, CI para backend e frontend
- **xUnit**, Jest, Testing Library

---

## 📌 Executar Localmente com Docker Compose

### Aplicações
- `http://localhost:3000` – Frontend React (SPA)
- `http://localhost:5001/api/clientes` – API moderna (.NET 6)
- `http://localhost:5002/api/bff/clientes` – BFF Gateway
- `http://localhost:5003/clientes` – Blazor Server (SSR frontend)

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download)
- [Node.js 18+](https://nodejs.org)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Instruções

```bash
git clone https://github.com/seu-usuario/modernizacao-dotnet-demo.git
cd modernizacao-dotnet-demo
docker-compose up --build
````

### Ou

### Backend:
```bash
cd backend-api-dotnet6\Web
dotnet run
````
### Frontend:
```bash
cd frontend-react
npm install
npm run dev
````
### BFF:
```bash
cd bff-gateway
dotnet restore
dotnet run
````
### Frontend Blazor:
```bash
cd blazor-frontend-server
dotnet run
````