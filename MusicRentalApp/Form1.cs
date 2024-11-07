using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRentalApp
{
    public partial class MusicRentalForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiBaseUrl = "https://localhost:7059/api/music"; // Updated API URL
        private const string rentalApiUrl = "https://localhost:7059/api/rentals"; // Updated API URL

        public MusicRentalForm()
        {
            InitializeComponent();
        }

        // Add a new album to the music library
        private async void btnAddAlbum_Click(object sender, EventArgs e)
        {
            var newAlbum = new Music
            {
                Title = txtTitle.Text,
                Artist = txtArtist.Text,
                Genre = txtGenre.Text,
                Year = (int)nudYear.Value,
                Available = true
            };

            if (string.IsNullOrEmpty(newAlbum.Title) || string.IsNullOrEmpty(newAlbum.Artist) || string.IsNullOrEmpty(newAlbum.Genre))
            {
                MessageBox.Show("Please fill in all album details.");
                return;
            }

            try
            {
                var response = await client.PostAsJsonAsync(apiBaseUrl, newAlbum);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album added successfully!");
                    txtTitle.Clear();
                    txtArtist.Clear();
                    txtGenre.Clear();
                    nudYear.Value = 2020;
                    LoadAvailableAlbums(); // Reload available albums list
                }
                else
                {
                    MessageBox.Show("Error adding album.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // List all available albums
        private async void btnListAlbums_Click(object sender, EventArgs e)
        {
            await LoadAvailableAlbums();
        }

        private async Task LoadAvailableAlbums()
        {
            try
            {
                var response = await client.GetFromJsonAsync<List<Music>>(apiBaseUrl);
                lstAlbums.Items.Clear();
                if (response != null)
                {
                    foreach (var album in response)
                    {
                        if (album.Available)  // Only show available albums
                        {
                            lstAlbums.Items.Add($"{album.Title} - {album.Artist} ({album.Year})");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading albums: {ex.Message}");
            }
        }

        // Rent an album
        private async void btnRentAlbum_Click(object sender, EventArgs e)
        {
            if (lstAlbums.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an album to rent.");
                return;
            }

            // Get the selected album ID (starting from 1, based on the selection index)
            int albumId = lstAlbums.SelectedIndex + 1;
            int userId = (int)nudUserId.Value;

            var rental = new Rental
            {
                UserId = userId,
                AlbumId = albumId,
                RentalDate = DateTime.Now
            };

            try
            {
                // Debugging: Log selected album and userId
                Console.WriteLine($"Attempting to rent album: {albumId} by User: {userId}");

                var response = await client.PostAsJsonAsync(rentalApiUrl, rental);

                // Debugging: Log response status
                Console.WriteLine($"Response Status Code: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album rented successfully!");
                    LoadAvailableAlbums(); // Reload available albums list
                    LoadActiveRentals(); // Reload active rentals list
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error renting album: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Return a rented album
        private async void btnReturnAlbum_Click(object sender, EventArgs e)
        {
            if (lstActiveRentals.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rental to return.");
                return;
            }

            int rentalId = lstActiveRentals.SelectedIndex + 1; // Assuming rental IDs are 1-based

            try
            {
                var response = await client.PostAsync($"{rentalApiUrl}/{rentalId}/return", null);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Album returned successfully!");
                    LoadActiveRentals(); // Reload active rentals list
                }
                else
                {
                    MessageBox.Show("Error returning album.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // View active rentals
        private async void btnViewActiveRentals_Click(object sender, EventArgs e)
        {
            await LoadActiveRentals();
        }

        private async Task LoadActiveRentals()
        {
            try
            {
                var response = await client.GetFromJsonAsync<List<Rental>>(rentalApiUrl);
                lstActiveRentals.Items.Clear();
                if (response != null)
                {
                    foreach (var rental in response)
                    {
                        lstActiveRentals.Items.Add($"User {rental.UserId} rented album {rental.AlbumId} on {rental.RentalDate.ToShortDateString()}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rentals: {ex.Message}");
            }
        }
    }

    // Music model for the album data
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool Available { get; set; }
    }

    // Rental model for the rental data
    public class Rental
    {
        public int UserId { get; set; }
        public int AlbumId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
