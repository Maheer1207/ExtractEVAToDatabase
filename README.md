# Extract-EVA-To-DB

[Video Demonstration](https://youtu.be/qjQpj4gfp2o)

## Project Overview

The primary objective of this project is to extract and store Earned Value Analysis (EVA) data from existing projects that are either created or utilized through the desktop Symphony App. The Symphony App performs Earned Value Analysis by utilizing the Plans and Actuals data associated with projects. The goal is to establish a dedicated database within the organization's designated Azure Cosmos DB. This database will facilitate access for company personnel and a web application specifically developed to manage Earned Value Analyses.

## How It Works

To initiate the script, users are prompted to input their User Name and Folder Name through text boxes within an Integrated Development Environment (IDE) such as Visual Studio. Additionally, users are given the option to select the `.eva` file, which contains the Earned Value Analysis data used by the Symphony App. The user must then confirm the accuracy of the selected information.

Upon confirmation via a button click, the script begins its execution. It carefully parses the XML/`.eva` file, systematically extracting project information related to tasks and task packages. Concurrently, the C# script constructs a tree structure, organizing task summaries along with their respective child tasks. This approach leverages the advantages of a tree structure, improving both management and presentation capabilities.

The entire process is implemented using a modular approach, where each module is assigned a specific responsibility, such as generating `Tasks`, creating `Task Summaries`, or constructing the final `Project` structure. This modular design ensures a well-organized framework that minimizes unnecessary coupling.

## Tools and Technologies

- **Windows Forms**: This user interface allows users to input required information, such as the owner's name and folder name, and provides an option to select the source `.eva` file.
- **System.XML Library**: The `System.XML` library is utilized to load the source `.eva` file as an XML document, from which data is then extracted.
- **Azure Cosmos DB**: The extracted project EVA data is stored in Azure Cosmos DB, making it accessible for retrieval within the organization's Azure Web App.
- **Mongo API**: The Mongo API is employed to perform NoSQL operations, including the insertion, deletion, and replacement of the project's EVA, task summaries, and tasks.

## Environment Setup

To set up the environment, follow these steps:

1. **Clone the Repository**: Begin by fully cloning the repository to your local machine.
2. **Open in IDE**: Open the project in an IDE, such as Visual Studio.
3. **Install Dependencies**: Use the NuGet Package Manager to download and install all required packages and libraries.
4. **Configure Database Connection**: Set up the `dbClient` with the connection string of the target database, followed by specifying the database's collection name.
5. **Build and Run**: Once all the above steps are completed, the project is ready to be built and executed.

Upon successful execution, a form should appear prompting for user inputs, indicating that the setup is complete and ready for use.
