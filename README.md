# Tunify-Platform

# Tunify Platform ReadMe

## Introduction

Welcome to the Tunify Platform! Tunify is a comprehensive music streaming service that allows users to create and manage playlists, subscribe to different service plans, and explore a vast library of songs, albums, and artists. The platform is designed with a robust database structure to ensure efficient data management and a seamless user experience.

## Tunify ERD Diagram

![Tunify ERD Diagram](./Image/Tunify.png)

## Overview of Entities and Relationships

### Entities and Relationships

1. **Users**:
    - **Attributes**: UserID, Username, Email, Join_Date, Subscription_ID
    - **Relationships**: 
        - Each user can have one subscription (many-to-one relationship with Subscriptions).
        - Each user can create multiple playlists (one-to-many relationship with Playlists).

2. **Subscriptions**:
    - **Attributes**: Subscription_ID, Subscription_Type, Price
    - **Relationships**: 
        - Each subscription can be associated with multiple users (one-to-many relationship with Users).

3. **Playlists**:
    - **Attributes**: Playlist_ID, User_ID, Playlist_Name, Created_Date
    - **Relationships**: 
        - Each playlist belongs to one user (many-to-one relationship with Users).
        - Each playlist can contain multiple songs (many-to-many relationship with Songs through PlaylistSongs).

4. **Songs**:
    - **Attributes**: Song_ID, Title, Artist_ID, Album_ID, Duration, Genre
    - **Relationships**: 
        - Each song belongs to one artist (many-to-one relationship with Artists).
        - Each song is part of one album (many-to-one relationship with Albums).
        - Each song can appear in multiple playlists (many-to-many relationship with Playlists through PlaylistSongs).

5. **Albums**:
    - **Attributes**: Album_ID, Album_Name, Release_Date, Artist_ID
    - **Relationships**: 
        - Each album is created by one artist (many-to-one relationship with Artists).
        - Each album can contain multiple songs (one-to-many relationship with Songs).

6. **Artists**:
    - **Attributes**: Artist_ID, Name, Bio
    - **Relationships**: 
        - Each artist can have multiple albums (one-to-many relationship with Albums).
        - Each artist can have multiple songs (one-to-many relationship with Songs).

7. **PlaylistSongs**:
    - **Attributes**: PlaylistSong_ID, Playlist_ID, Song_ID
    - **Relationships**: 
        - This is a junction table that creates a many-to-many relationship between Playlists and Songs.
        - Each entry in the PlaylistSongs table links a song to a playlist.

## Code Overview

The provided code defines the models and the database context for the Tunify platform using Entity Framework Core. Here is a brief description of each class and the DbContext configuration:

### Models

- **User**: Represents a user in the system. Includes navigation properties for the related Subscription and Playlists.
- **PlaylistSong**: Junction table that represents the many-to-many relationship between Playlists and Songs.
- **Album**: Represents an album in the system. Includes navigation properties for the related Artist and Songs.
- **Artist**: Represents an artist in the system. Includes navigation properties for the related Albums and Songs.
- **Song**: Represents a song in the system. Includes navigation properties for the related Artist, Album, and PlaylistSongs.
- **Playlist**: Represents a playlist in the system. Includes navigation properties for the related User and PlaylistSongs.
- **Subscription**: Represents a subscription type in the system. Includes a navigation property for the related Users.

### DbContext

The `TunifyDBContext` class is responsible for configuring the database and the relationships between entities. It includes the following configurations:

- Configuring primary keys and relationships for each entity.
- Specifying the precision for the `Price` property in the Subscription entity.
- Seeding initial data for the Users, Subscriptions, Songs, Artists, Albums, Playlists, and PlaylistSongs entities.

### Configuration Details

- **PlaylistSong configuration**: Sets up the primary key and foreign key relationships.
- **Subscription configuration**: Sets up the one-to-many relationship with Users and configures the precision for the Price property.
- **User configuration**: Sets up the one-to-many relationship with Playlists.
- **Artist configuration**: Sets up the one-to-many relationships with Albums and Songs.
- **Album configuration**: Sets up the one-to-many relationship with Songs.
- **Song configuration**: Sets up the many-to-one relationships with Artists and Albums.
- **Seed initial data**: Seeds the database with initial data for Users, Subscriptions, Songs, Artists, Albums, Playlists, and PlaylistSongs.

## Implementing the Repository Pattern
Step 1: Define Repository Interfaces
Create a folder named Repositories with subfolders Interfaces and Services.

Step 2: Implement Repository Services.

Step 3: Refactor Controllers
Refactor your controllers to use repository services instead of direct DbContext calls.

Step 4: Register Repositories in Program.cs

## Navigation and Routing Functionalities

### Navigation

In this lab, advanced navigation features have been added to enhance user experience and facilitate smooth transitions between different parts of the application. Key improvements include:

- **Dynamic Navigation**: Users can now navigate between different pages dynamically based on the content and context. This includes linking to specific playlists, viewing detailed information about songs, and accessing artist profiles directly from playlists and songs.

- **Breadcrumb Navigation**: Breadcrumbs have been implemented to help users keep track of their location within the application and easily navigate back to previous pages or sections.

### Routing

Routing functionality has been extended to support more complex URL patterns and navigation scenarios:

- **Parameterized Routes**: Routes now support parameters, allowing users to navigate to specific resources, such as viewing a playlist by its ID or an artist by their name.

- **Nested Routing**: The application now supports nested routes, which allow for hierarchical navigation and better organization of related content, such as songs within a playlist or albums within an artist's profile.


## Swagger UI Integration

In this lab, we extended the Tunify Platform by adding API documentation using Swagger UI. Swagger UI allows you to automatically generate and visualize the API's documentation, making it easier to understand and test the API endpoints.

### Setting Up Swagger UI

To set up Swagger UI in the Tunify Platform, follow these steps:

1. **Install Swashbuckle.AspNetCore**
   - Open the NuGet Package Manager Console.
   - Run the following command to install the Swashbuckle.AspNetCore package:
     ```
     Install-Package Swashbuckle.AspNetCore
     ```

2. **Configure Swagger in the Startup Class**
   - Add Swagger services in the `Program.cs` file:
     ```csharp
     builder.Services.AddSwaggerGen(options =>
     {
         options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
         {
             Title = "Tunify API",
             Version = "v1",
             Description = "API for managing playlists, songs, and artists in the Tunify Platform"
         });
     });
     ```
   - Enable Swagger and Swagger UI in the `Program.cs` class:
     ```csharp
     app.UseSwagger(options =>
     {
         options.RouteTemplate = "api/{documentName}/swagger.json";
     });

     app.UseSwaggerUI(options =>
     {
         options.SwaggerEndpoint("/swagger/v1/swagger.json", "Tunify API v1");
         options.RoutePrefix = "";
     });
     ```

3. **Test Your Swagger UI**
   - Launch the application.
   - Navigate to the root URL (e.g., `http://localhost:5000/`) to view the Swagger UI.
   - Use the Swagger UI to interact with the API endpoints, test functionality, and ensure that all endpoints are documented correctly.

### Accessing and Using Swagger UI

After setting up Swagger, you can access the Swagger UI by navigating to the root URL of your application. The Swagger UI provides a user-friendly interface where you can:

- **Explore API Endpoints**: View all available API endpoints, including the HTTP methods and parameters.
- **Test API Endpoints**: Use the built-in form to test API calls directly from the browser.
- **View API Documentation**: Read detailed documentation for each API endpoint, including descriptions, request formats, and response formats.

## Conclusion

The Tunify Platform is designed to provide a rich and organized music streaming
experience, with well-defined relationships between users, subscriptions, playlists,
songs, albums, and artists. The Entity Relationship Diagram (ERD) and the code structure
demonstrate the robust architecture of the platform, ensuring efficient data management and scalability.