# CV-back - API .NET pour projet de CV structure

## Objectif du projet

Ce projet a ete concu pour :

- Reprendre en main .NET et C# avec une architecture propre et professionnelle.
- Structurer un backend en Controller / Service / Repository, facilement maintenable.
- Le rendre dockerisable et interchangeable avec un backend d'une autre stack (Node.js, Python, etc.).
- Fournir une API REST complete pour une application de gestion de CV, utilisee avec un front Blazor.

---

## Stack technique

- .NET 8 / ASP.NET Core Web API
- Entity Framework Core (ORM)
- Docker / Docker Compose
- Swagger pour la documentation API

---

## Architecture du projet
```
CV-back/  
├── Controllers/               ### Points d'entree HTTP (API)  
│   ├── CompetenceController.cs  
│   ├── ExperiencesController.cs    
│   ├── FormationController.cs   
│   └── WeatherForecastController.cs (exemple par defaut)   
│    
├── Service/                   ### Logique metier    
│   ├── CompetenceService.cs    
│   ├── ExperiencesService.cs   
│   └── FormationService.cs    
│    
├── Repository/                ### Acces base de donnees (EF Core)      
│   ├── CompetenceRepository.cs      
│   ├── ExperiencesRepository.cs   
│   ├── FormationRepository.cs      
│   └──    
│    
├── Entities/                  ### Modeles de donnees (EF Core)    
│   ├── Experience.cs     
│   ├── Formation.cs    
│   ├── Competence.cs   
│   └── ...    
│
├── data/
│   └── ApplicationDbContext.cs    ### Contexte EF Core    
│     
├── ResponseModel/            ### DTOs et formats de reponse personnalises  
│   ├── FullExperiences.cs    
│   └── SortCompetences.cs     
│    
├── Program.cs / appsettings.json    
├── Dockerfile    
└── README.md    
```
---

## Prerequis

- .NET SDK 8 : https://dotnet.microsoft.com/en-us/download
- Docker : https://www.docker.com/
- Base de donnees (structure) : https://github.com/pyrofir/CV-db

---

## Modularite

Ce backend a ete pense pour pouvoir etre remplace par un autre backend (ex : Node.js, Python/FastAPI), tant que les routes et formats d'echange sont conserves. Cela facilite les tests ou les comparaisons entre technologies.

---

## Contact

Si vous avez des suggestions, remarques, ou que vous souhaitez echanger autour du projet, n'hesitez pas a me contacter :

**samuel.israel@sfr.fr**
