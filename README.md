This project is a sample application developed to simulate a simple personal movie tracking system that works with a single user.

The application starts without any predefined user. When the program is launched, the user is required to enter their name. The program does not continue until a valid name is provided. From that point on, all operations performed in the application belong only to that user. This approach reflects the behavior of real-life personal tracking applications where actions are always associated with a specific user.

After the user logs in, a menu is displayed on the screen. Through this menu, the user can add movies, list existing movies, mark a movie as watched, give a rating to a watched movie, or remove a movie from the list. The program allows these actions only after a user has been created, preventing any operation from being performed without an active user.

When adding a movie, the user provides the movie title and genre. A movie object is then created and added to the user’s list. Newly added movies are initially considered not watched. The user can later update this status by marking the movie as watched.

While marking a movie as watched, the user is asked to enter a rating value. The program expects this value to be within a valid range. If an invalid value is entered, the program displays a warning message and asks the user to enter the value again instead of terminating. This ensures that incorrect input does not break the execution flow of the application.

When the movie list is displayed, each movie is shown together with its watched status. If a movie has been watched, the assigned rating is also displayed next to it. There is no separate list for watched movies; instead, the watched information is presented directly within the main list.

Although this project does not include all the features of a full-scale movie tracking system, it demonstrates the core idea of user-based data management and meaningful object state changes within a console application.
