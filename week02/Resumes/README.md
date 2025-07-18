# Resumes Project

## Overview
The Resumes project is a simple C# application that demonstrates the use of classes and abstraction to manage job information and resumes. It allows users to create job entries and compile them into a resume format.

## Project Structure
The project consists of the following files:
- **Job.cs**: Contains the `Job` class, which tracks job details such as title, company, and employment duration.
- **Resume.cs**: Contains the `Resume` class, which holds a person's name and a list of their jobs.
- **Program.cs**: The entry point of the application that creates instances of `Job` and `Resume`, sets their properties, and displays the information.
- **Resumes.csproj**: The project configuration file that specifies project settings and dependencies.

## Instructions for Running the Application
1. Ensure you have the .NET SDK installed on your machine.
2. Open a terminal and navigate to the project directory.
3. Run the following command to build the project:
   ```
   dotnet build
   ```
4. After a successful build, run the application using:
   ```
   dotnet run
   ```
5. The application will display the resume information in the console.

## Example Output
```
Name: Allison Rose
Jobs:
Software Engineer (Microsoft) 2019-2022
Manager (Apple) 2022-2023
```