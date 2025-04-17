<h1 align="center">Car Auctions</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 8" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
  <a href="https://www.postgresql.org/"><img alt="PostgreSQL" src="https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white" /></a>
  <a href="https://www.docker.com/"><img alt="Docker" src="https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white" /></a>
</p>

## 💻 Project

This repository contains a Web API developed for academic purposes, simulating a car auction system. The main objective is to apply and practice `microservices architecture` concepts. 

The project's source code is based on the course: [Build a Microservices app with .Net and NextJS from scratch](https://www.udemy.com/course/build-a-microservices-app-with-dotnet-and-nextjs-from-scratch/?couponCode=ST14MT150425G3) 

## 🚀 Technologies and Tools

This project was developed using the following technologies:

- **Backend:**  
  - `.NET 8.0`
  - `ASP.NET Core WebAPI`
  - `C#`
  - `Microservices Architecture`
  - `Entity Framework Core`
  - `AutoMapper`
  - `JWT`
  - `IdentityServer`
  - `Microsoft YARP`
  - `GRPC`
  - `RabbitMQ`
  - `SignalR`
  - `Docker`

- **Unit and Integration Tests:** 
  - `XUnit`
  - `Moq`
  - `AutoFixture`

- **Databases:** 
  - `PostgreSQL`
  - `MongoDB`

## 📌 Technical Decisions

- I chose to stick with the same `backend` structure presented throughout the course.
- I decided not to use the frontend with `Next.js` because the version `13.4.9` used in the lessons had several `errors` and `bugs`. In the more recent versions of Next.js, some key aspects have changed, and I feel I still need to gain more experience before diving into frontend development.
- Later on, I plan to build the `frontend` from scratch and integrate `Kubernetes` for container orchestration.
- Since I'm currently focused on following the course structure, I’ll be implementing the remaining `tests` at a later stage.

## 💾 How to Run (Docker)

```bash
# Clone the repository
git clone https://github.com/PauloAlves8039/dotnet-microservices-auctions.git

# Navigate to the project folder:
cd Carsties

# Make sure you have Docker installed on your computer!
# Build the services locally on your computer by running (NOTE: this may take several minutes to complete):
docker compose build

# Once this completes you can use the following to run the services:
docker compose up -d

# After starting the containers, you need to complete the authentication and authorization process before testing the requests.
# This can be done at the following URL:
http://localhost:5000/
```


## 🌎 Developed Services and Their URLs

| Service            | URL                      |
|--------------------|--------------------------|
| Auction Service    | http://localhost:7001    |
| Search Service     | http://localhost:7002    |
| Bidding Service    | http://localhost:7003    |
| Identity Service   | http://localhost:5000    |
| Gateway Service    | http://localhost:6001    |

## 📫 Requests

Use a tool to interact with the API endpoints. `Postman` was used throughout the course.

You can use this [requests](https://github.com/PauloAlves8039/dotnet-microservices-auctions/tree/master/Resources/Requests/Postman) collection as a backup to import directly into `Postman`.

Note: All requests are already pre-configured.

## 📘 Notes
```bash
# Access RabbitMQ in the Docker container:
http://localhost:15672

# Credentials:
User: guest
Password: guest 
```

There are several tools available to access the databases, including `Visual Studio Code` extensions that make the process much easier. I'll mention two examples of tools for accessing the databases:

- PostgreSQL: [DBeaver](https://dbeaver.io/download/)
- MongoDB: [Compass](https://www.mongodb.com/try/download/compass)

## 📗 Documentations

The course provided [documentations](https://github.com/PauloAlves8039/dotnet-microservices-auctions/tree/master/Resources/Documentations) to support the project development. It's important to read through it carefully.

## 👤 Author

<a href="https://github.com/PauloAlves8039">
  <img src="https://avatars.githubusercontent.com/u/57012714?v=4" width=70 />
</a>

**[Paulo Alves](https://github.com/PauloAlves8039)**
