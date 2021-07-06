1-) run docker command with cmd 

  docker-compose --project-name danskebank up
  
  sql server login :
  localhost,1453
  sa
  danskebank2021!
  
2-) run project danske.scheduler.api

3-) make a request with swagger or you can use postman collection json (DanskeBank.postman_collection.json) inside repository for all the requests

![image](https://user-images.githubusercontent.com/16955249/124642321-6244bf80-de98-11eb-8e8f-ed34a19210e7.png)


SMALL COMPANY AND DENMARK

{
  "company": {
    "name": "TESTCOMPANY",
    "number": "0123456789",
    "type": 0,
    "market": "DK"
  }
}

MEDIUM COMPANY AND DENMARK

{
  "company": {
    "name": "TESTCOMPANY",
    "number": "0123456789",
    "type": 1,
    "market": "DK"
  }
}


LARGE COMPANY AND DENMARK

{
  "company": {
    "name": "TESTCOMPANY",
    "number": "0123456789",
    "type": 2,
    "market": "DK"
  }
}

TYPE:

  SMALL:0
  MEDIUM:1
  LARGE:2

MARKET:

  DENMARK:"DK"
  FINLAND:"FI"
  NORWAY:"NO"
  SWEDEN:"SE"
  
USED PATTERNS and PRINCIPLES:

- Unit of Work pattern
- Generic Repository pattern
- Abstracy Factory pattern
- Strategy pattern
- Specifiation pattern
- Service layer
- DDD(Domain Driven Design)
- MVC pattern
- SOLID principle
- Common Reuse principle
- Common Closure principle
- DRY
- YAGNI
- KISS

USED PACKAGES:

- AutoMapper
- Swashbuckle for open api specification
- FluenValidation for validations
- Entity Framework Core
- Moq for unit tests

TODOs: 
  - use mediatR and Refit for CQRS pattern
  - use Cassandra for audit logging
  - use enterpise messaging architecture
  - write unit test for controllers and services
  - add elk stack for logging
  - use correlationid for tracking
  - use key vault and key valet pattern for appsettings credentials
