# .Net 6 + Microsoft SQL Server + Vue.js 3 CRUD Application Example

# After completing this tutorial what we will build? 
We will build a full-stack web application that is a basic User Management Application with CRUD features: 

• Create User 

• List User 

• Update User 

• Delete User 

• View User

<img src="https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjkozeHDwIlXlirtSCLqtcrgU7145lqUcbqC2YxuEM9mf8e7cIUz8PKgPTfl3iMCDke3c44rkVBZFeNop6MTVAzgYKNy5GomrjS4BxqRJpmW1Iowgc3_ELit72zcKgKP_LjPWBwT-WNIohxbc9uc2wkToy4RHdsKMEw9NF44ufR0wis9-V41Fi1d2kOIw/s1048/uinetvue.png">


# Local Setup and Run the application

<h2>Create database and table</h2>

```CREATE DATABASE testdb;```

```
CREATE TABLE users (
  id              INT           NOT NULL    IDENTITY    PRIMARY KEY,
  first_name      VARCHAR(100)  NOT NULL,
  last_name       VARCHAR(100),
  email           VARCHAR(100)  NOT NULL,
);

```

<h2> Download or clone the source code from GitHub to the local machine</h2>

<h2> Backend</h2>

You can start the api by running ```dotnet run``` from the command line in the project root folder (where the WebApi.csproj file is located)

OR

You can also start the application in debug mode in Visual Studio by opening the project root folder in Visual Studio and pressing F5 or by selecting Debug -> Start Debugging from the top menu, running in debug mode.

<h2>Frontend</h2>

```npm install```

```npm run serve -- --port 8081```

<h2>From the browser call the endpoint http://localhost:8081</h2>


