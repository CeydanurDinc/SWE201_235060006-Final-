# SWE201_235060006-Final-
This project is intended as a simple sample project developed for the SWE201 term project assignment.

It is a toy console application which imitates the operations of a movie tracking system.
The application allows users to add movies, track their watching status, rate watched movies, and remove movies from the system.

The project consists of three main classes:
Movie
User
MovieTracker

I do not claim that these classes are designed in the most perfect or comprehensive way.
Instead, the main goal of this project is to demonstrate basic object-oriented design principles using real-life concepts.

To begin with, each class is designed to represent a real-world object.
A class packages the attributes that identify the object and the information that describes its current state.

In this project, the Movie class represents a real-life movie entity.
The most identifying attribute of a movie is its Title.
Other properties such as Genre, IsWatched, and Rating represent the operational state of the movie rather than its identity.
For example, whether a movie has been watched or not, and the rating given by the user, are temporary states that may change over time.

The Movie class only stores the minimum amount of information required for the application to function.
In a real-world professional movie database, many additional details could be stored such as release year, cast, director, or production company.
However, such information is not necessary for this toy application and therefore intentionally omitted to keep the design simple.

The User class represents a user of the application.
For simplicity, it only contains basic identifying information such as user ID and name.
The application does not implement authentication or multiple-user interaction, since these features are beyond the scope of this project.

The MovieTracker class acts as a manager class.
It is responsible for handling the real-life operations of the application such as creating, listing, updating, and deleting movie objects.
This class maintains association relationships with Movie and User classes by storing collections of these objects.

MovieTracker generates movie IDs automatically to avoid user input errors and to better simulate real-world systems where identifiers are managed internally.
Operations such as marking a movie as watched or removing a movie are performed using movie titles to provide a more user-friendly interaction through the console interface.

While developing this project, I followed the principle of keeping class definitions minimal.
Only the attributes and properties that are required for storing the object's state and performing the application's operations are included.
This approach helps avoid unnecessary complexity and keeps the code easy to understand and maintain.

In this application, the Program class is responsible for handling the console-based user interaction and menu system.
Ideally, in a more advanced or real-world application, a separate manager or ViewModel class would handle these operations to improve portability and modularity.
However, for this simple console application, this responsibility is handled directly within the Program class.

The classes defined in this project can be considered model classes.
They store the data and state of the objects, while the console interface serves as a basic way to visualize and interact with this data.
This separation of concerns follows the fundamental ideas behind common software architectures such as MVVM, even though a full MVVM structure is not implemented here.
