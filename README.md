# Extract-EVA-To-DB

The objective of this project was to extract and store the Earned Value Analysis (EVA) from existing projects utilized or created through the desktop Symphony App. This app conducts Earned Value Analysis for projects by utilizing their Plans and Actuals data. The aim was to establish a dedicated Database within the organization's designated Azure Cosmos DB. This would enable access for company personnel as well as a Web app developed specifically to manage Earned Value Analyses.

## How it works

To initiate the script, when loaded within an IDE (like Visual Studio), the user is prompted to provide their User Name and Folder Name via TextBoxes. Furthermore, an option is provided to select the '.eva' file, which contains the Earned Value Analysis of the Project Data as utilized in the Symphony App. Lastly, the user is required to confirm the accuracy of the selected information.

Once confirmation is received through a button click, the script is set into motion. It meticulously parses through the XML/'.eva' file, systematically extracting the project information pertaining to tasks and task packages. Simultaneously, the C# script constructs a coherent tree structure, neatly organizing task summaries along with their respective child tasks. This strategic approach fully capitalizes on the inherent benefits of a tree structure, offering enhanced management and presentation capabilities.

The entire process was thoughtfully executed using a modular methodology. Each module was assigned a specific role, whether generating 'Tasks', crafting 'Task Summaries', or shaping the final 'Project' structure. This meticulous division ensures a well-structured framework that minimizes unnecessary coupling.

## Tools Implemented or Playing a Key Role:

1. Windows Form: This interface will allow users to input information, such as the owner's name and folder name, and provide them with the option to select the source file.
2. "System.XML" library: The "System.XML" library will be employed to load the source ".eva" file as an XML document. Subsequently, data will be extracted from the XML file.
3. Azure Cosmos DB: The extracted Project EVA will be stored in Azure Cosmos DB, making it accessible for loading within the organization's Azure Web App.
4. Mongo API: The Mongo API will facilitate NoSQL operations, including the insertion, deletion, and replacement of the project's EVA, along with its task summaries and tasks.

## Steps to set up the Environment

1. Clone the repo fully
2. Open it in an IDE; lets assume I open it in Visual Studio
3. Use the NuGet Package Manager to download all the required packages and libraries
4. Set up the "dbClient" with the connection string of the Database where you want to save it, followed by setting the Database's collection name.
5. Once all the steps are attained, the project is ready to be built and run.

After following all these steps, upon execution, a form should appear prompting for inputs, indicating that the setup is now ready for utilization.
