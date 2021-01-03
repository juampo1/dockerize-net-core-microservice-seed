This is an example of a microservice using .net core 3.1 and mysql

The microservice is divided into 3 projects:
  - The Host: where the controllers are defined, this is the entry point of the microservice.
  - The Model: where all validation logic is defined.
  - The Repository: using the repository pattern, this part is in charge of connecting to the database.
  
Things to do when cloning the repo:
  - Build the solution.
  - Change the working directory to where you clone the repo in Propertires/launchSettings.json
  - Change the connection string to match your mysql database.
