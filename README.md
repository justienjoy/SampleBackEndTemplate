﻿## SampleBackEndTemplate

## Clean Architecture Boilerplate - ASP.NET Core 5.0 WebApi
`Clean Architecture Solution Template for ASP.NET Core 5.0. Built with Onion/Hexagonal Architecture and incorporates the most essential Packages your projects will ever need.`

## Clean Architecture Solution Template
[![.NET Core](https://github.com/SIDC-MISDEV/SIDC-Datawarehouse/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/SIDC-MISDEV/SIDC-Datawarehouse/actions/workflows/dotnet-core.yml)

### Installing the tools
####dotnet ef
`dotnet tool install --global dotnet-ef`

### Migration Commands for identity
`dotnet ef migrations add "Initial" --project SampleBackEndTemplate.Infrastructure --startup-project SampleBackEndTemplate.Api --output-dir Migrations --context IdentityContext`

`dotnet ef database update --project SampleBackEndTemplate.Infrastructure --startup-project SampleBackEndTemplate.Api --context IdentityContext`

### Migration Commands for application
`dotnet ef migrations add "Initial" --project SampleBackEndTemplate.Infrastructure --startup-project SampleBackEndTemplate.Api --output-dir Migrations\ApplicationDb --context ApplicationDbContext`

`dotnet ef database update --project SampleBackEndTemplate.Infrastructure --startup-project SampleBackEndTemplate.Api --context ApplicationDbContext`

### Guide to work on this template
1. Entity - Domain.Entities
2. Configuration - Infrastructure.Configuration
3. Seeds - Infrastructure.Seeds
4. Interface Repository - Application.Interface.Repositories
5. Class Repository - Infrastructure.Repositories
6. Register Repository in Service Collection -  Infrastructure.Extensions
7. CQRS (Commands and Queries) - Application.Features
8. Mappings - Application.Mappings
9. Controller - API.Controllers
10. Api testing using Postman - ./Postman/SIDC-MMS.postman_collection.json

### Technologies Used

- ASP.NET Core 5.0 WebAPI
- ASP.NET Core 5.0 MVC
- Entity Framework Core 5.0

### Features Included

### ASP.NET Core 5.0 MVC Project
- Slim Controllers using MediatR Library
- Permissions Management based on Role Claims
- Toast Notification (includes support for AJAX Calls too)
- Serilog
- ASP.NET Core Identity
- AdminLTE Bootstrap Template (Clean & SuperFast UI/UX)
- AJAX for CRUD (Blazing Fast load times)
- jQuery Datatables
- Select2
- Image Optimization
- Includes Sample CRUD Controllers / Views
- Active Route Tag Helper for UI
- RTL Support
- Complete Localization Support / Multilingual
- Clean Areas Implementation
- Dark Mode!
- Default Users / Roles Seeding at Startup
- Supports Audit Logging / Activity Logging for Entity Framework Core
- Automapper

### ASP.NET Core 5.0 WebAPI
- JWT & Refresh Tokens
- Swagger



## About the Authors

### Mukesh Murugan
- Blogs at [codewithmukesh.com](https://www.codewithmukesh.com)
- Facebook - [codewithmukesh](https://www.facebook.com/codewithmukesh)
- Twitter - [Mukesh Murugan](https://www.twitter.com/iammukeshm)
- Twitter - [codewithmukesh](https://www.twitter.com/codewithmukesh)
- Linkedin - [Mukesh Murugan](https://www.linkedin.com/in/iammukeshm/)

<a href="https://www.buymeacoffee.com/codewithmukesh" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" width="200"  style="height: 60px !important;width: 200px !important;" ></a>

#Mukesh Documentation
# V1.0.0 is Released.

[Get the NuGet Package from here!](https://www.nuget.org/packages/SIDC-Datawarehouse/)

[Getting Started - Quick Start Guide](https://codewithmukesh.com/blog/aspnet-core-hero-boilerplate-quick-start-guide/)

[View the Project Page](https://codewithmukesh.com/project/aspnet-core-hero-boilerplate/)
