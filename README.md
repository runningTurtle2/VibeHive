# VibeHive

### Integrated Music Rental &amp; Event Hub
<br>

### 1. Music Rental Management (RESTful API + C# Windows Forms)
#### RESTful API Implementation

#### Endpoints

- POST /api/music: Add a new music album.
- GET /api/music: List all available music albums.
- DELETE /api/music/{id}: Delete a music album by its ID.
- POST /api/rentals: Rent an album by providing user ID and album ID.
- POST /api/rentals/{id}/return: Return a rented album.
- GET /api/rentals: List all active rentals.
#### Fields

- **Music:** Title, Artist, Genre, Year, Available (boolean).<br>
- **Rental:** UserID, AlbumID, RentalDate, ReturnDate.
#### C# Windows Forms Application

- **Add Albums:** Users can add albums to the music library. The GUI should include fields to input the album's title, artist, genre, and year.
- **List Albums:** Display a list of all available albums.
- **Rent Albums:** Users can rent available albums, and the system will track rental details like rental date and user information.
- **Return Albums:** Users can return rented albums, updating the system to reflect the album’s availability.
- **View Active Rentals:** Show all ongoing rentals, displaying details like customer name, album title, and rental dates.

#### Hints

- Use CRUD operations for managing music and rentals.
- Incorporate simple input validation in the C# GUI to ensure user entries are complete before submission.
- Keep a separate list to manage rented and available albums to maintain clarity.
<br>

### 2. Collaborative Playlist Builder (RESTful API + Advanced OOP + C# Windows Forms)
#### RESTful API Implementation

#### Endpoints
- POST /api/playlists: Create a new playlist.
- GET /api/playlists: List all playlists created by users.
- PUT /api/playlists/{id}/add: Add a song to a specific playlist.
- PUT /api/playlists/{id}/invite: Invite other users to collaborate on a playlist.
- POST /api/playlists/{id}/vote: Vote on a song within a collaborative playlist.
- GET /api/playlists/{id}/rankings: Get ranked list of songs based on votes.
#### Fields

**Playlist:** Name, Songs (list of song IDs), CreatedBy (user ID), IsCollaborative (boolean).<br>
**Song:** Title, Artist, Genre, Duration, Votes (for collaborative voting).

#### C# Windows Forms Application

- **Create Playlists:** Users can create playlists and mark them as collaborative.
- **Add Songs:** Users can search and add songs to playlists, specifying song title, artist, and genre.
- **Invite Collaborators:** Users can invite friends to join playlists and collaborate.
- **Voting System:** In collaborative playlists, users can vote on songs to determine which tracks stay or get removed from the list.
- **View Rankings:** Show rankings based on votes to create a "Top Playlist" experience.

#### Hints

- Use OOP principles like inheritance and encapsulation to manage playlist and song operations.
- Implement the Command Pattern to manage operations like adding, removing, and voting on songs.
- Use timers or background workers to refresh voting data every few seconds, creating a real-time experience.
<br>

### 3. Album Inventory Microservice (gRPC + C# Windows Forms)
#### gRPC Service Implementation

#### Methods
- **AddAlbum:** Adds a new album to the inventory.
- **GetAlbum:** Retrieves a specific album by its ID.
- **UpdateAlbum:** Updates information for an album.
- **DeleteAlbum:** Deletes an album from the inventory.
- **ListAlbums:** Streams all available albums.
#### Fields

**Album:** ID, Title, Artist, Genre, Year, Available (boolean).
#### C# Windows Forms Application

- **Add Albums:** Users can add new albums to the system.
- **View Albums:** Users can retrieve and display all available albums in real-time.
- **Update Albums:** Users can edit album details.
- **Delete Albums:** Users can remove albums from the inventory.

#### Hints:

- Use bidirectional streaming for real-time album updates in the gRPC service.
- Implement error handling in both client and server to manage connection issues and invalid requests.
- Create an efficient UI that updates album details dynamically as changes occur.
#### Integration and Functionality
The VibeHive project will integrate all modules into the C# Windows Forms application, providing a single interface to interact with the entire system. Authentication will be handled by the ASP.NET Core Web API, while the gRPC microservice will ensure fast, real-time updates for the album inventory.
