# Stuart Hamlin's Udacity Capstone Project

## Repository Layout

### Project root
* `README.md` - this file
* `Dockerfile` - docker image definition

### `src` folder
* `Program.cs` - Main applicationsource file (C# minimal API)
* `Capstone.csproj` - Project file
* `*.json` - supporting settings files

### `scripts` folder
* `create-infra.sh` - For testing the Cloud Formation scripts
* `drop-infra.sh` - For testing the Cloud Formation scripts

### `.circleci` folder
* `config.yml` - Circle CI pipeline definition
* `files/capstone-infra.yml` - Cloud Formation definition for constructing EKS cluster and its VPC
* `files/capstone-deploy.yml` - Kubernetes manifest for the application deployment
* `files/capstone-service.yml` - Kubernetes manifest for the application service
