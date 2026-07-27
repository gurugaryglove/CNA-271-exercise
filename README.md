# CNA-271-exercise: Belgium Campus Registration

A student registration exercise built as two independently Dockerized applications: 
a web app and a C# console app. Both capture Name, Surname, Gender, and Year of Birth, 
display a welcome message, calculate the user's age, and show a results/goodbye screen.

## Repository Structure

CNA-271-exercise/
├── README.md
├── .gitignore
├── web-app/
│ ├── Dockerfile
│ ├── index.html
│ └── styles.css
└── csharp-app/
├── Dockerfile
├── Program.cs
└── MyCharpBC.csproj


## Web App

A registration form built with HTML/CSS/JS. Displays "WELCOME TO Belgium Campus", 
collects user details, calculates age from year of birth, and shows a results screen 
with "Good Bye thank you for registering". Served via Nginx inside the container.

**Build and run locally:**

cd web-app
docker build -t mybc:v1 .
docker run --name myBc -p 8080:80 -d mybc:v1

Then visit `http://localhost:8080` in your browser.

**Or pull the pre-built image from Docker Hub:**

docker pull gurugaryglove/mybc:v1
docker run --name myBc -p 8080:80 -d gurugaryglove/mybc:v1


## C# Console App

A console application implementing the same registration and age-calculation logic.

**Build and run locally:**

cd csharp-app
docker build -t bc-java:v1 .
docker run --name MyCharpBC -it bc-java:v1


**Or pull the pre-built image from Docker Hub:**

docker pull gurugaryglove/bc-java:v1
docker run --name MyCharpBC -it gurugaryglove/bc-java:v1


## Notes

- Both apps are built from source and pushed as separate Docker images (`mybc` and `bc-java`)
  to allow independent building or pulling.
- Build artifacts (`bin/`, `obj/`, `*.dll`, `*.pdb`) are excluded via `.gitignore` and 
  regenerated automatically on build.
