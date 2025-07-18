# Resumes Project

This project is a simple console application that manages and displays a person's job history in the form of a resume. It utilizes object-oriented programming principles to create a structured representation of jobs and resumes.

## Project Structure

- **src/**: Contains the source code files for the application.
  - **Program.cs**: The entry point of the application where instances of the Job and Resume classes are created and their methods are called.
  - **Job.cs**: Defines the Job class, which includes member variables for job title, company, start year, and end year, along with a method to display job information.
  - **Resume.cs**: Defines the Resume class, which includes member variables for the person's name and a list of jobs, along with a method to display the resume.

- **resumes-project.csproj**: The project configuration file that specifies dependencies and settings required for building the application.

## How to Run the Application

1. Ensure you have the .NET SDK installed on your machine.
2. Navigate to the project directory in your terminal.
3. Run the following command to build the project:
   ```
   dotnet build
   ```
4. After building, run the application using:
   ```
   dotnet run --project src/Program.cs
   ```

## Functionality

- The application creates instances of the Job class to represent individual job entries.
- It creates an instance of the Resume class to hold the person's name and a list of jobs.
- The Display methods in both classes are used to output the job details and the resume information to the console.

## Future Improvements

- Add functionality to allow users to input job details dynamically.
- Implement error handling for invalid inputs.
- Enhance the user interface for better interaction.