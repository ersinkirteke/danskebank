1-) run docker command with cmd 

  docker-compose --project-name danskebank up
  
2-) run project danske.scheduler.api

3-) make a request with swagger or you can use postman collection json inside repository for all the requests

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

TODOs: 
  - use mediatR and Refit for CQRS pattern
  - use Cassandra for audit logging
  - use enterpise messaging architecture
  - write unit test for controllers and services
  - add elk stack for logging
  - use correlationid for tracking
