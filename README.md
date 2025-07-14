# InvoiceService
A minimal .NET 8 Web API containerized with Docker and deployed to Kubernetes or OpenShift using GitHub Actions CI/CD.

---

## Project Structure

```
InvoiceService/
├── Controllers/
│   └── InvoiceController.cs
├── Program.cs
├── InvoiceService.csproj
├── Dockerfile
├── invoice-service.yaml
└── .github/workflows/
    └── deploy.yml
```

---

## Tech Stack

- **.NET 8 (Minimal API)**
- **Docker**
- **Kubernetes / OpenShift**
- **GitHub Actions**
- **YAML-based Infrastructure-as-Code**

---

## API Demo

**GET** `/invoice`
```json
[
  { "id": 1, "amount": 100.0 }
]
```

---

## Deployment Flow

1. **Developer pushes code to `main`**
2. GitHub Actions:
   - Builds and publishes the .NET app
   - Builds Docker image and pushes to Azure Container Registry
   - Applies Kubernetes/OpenShift manifest via `kubectl`

---

## How to Run Locally

```bash
# Build and run locally
dotnet restore
dotnet run
```

```bash
# Or with Docker
docker build -t invoice-service .
docker run -p 8080:80 invoice-service
```

---

## Secrets Required (in GitHub repo settings)

- `ACR_USERNAME`
- `ACR_PASSWORD`

These are used to authenticate and push Docker images to Azure Container Registry (can be adapted for AWS/GCP).

---

## Recruiter Note

This repository demonstrates my ability to:
- Write clean and container-ready .NET services
- Automate CI/CD pipelines with GitHub Actions
- Deploy to modern container orchestration platforms (Kubernetes, OpenShift)
- Work DevOps-style with cloud-native toolchains

---

## Contact

**Anis Toauti**  
Senior .NET Developer | Cloud & DevOps Enthusiast  
[LinkedIn](https://www.linkedin.com/in/anis-toauti) | [GitHub](https://github.com/kiranis) | Montréal, QC
