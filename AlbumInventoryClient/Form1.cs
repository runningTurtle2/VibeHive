using AlbumAPI;
using Grpc.Core;
using Grpc.Net.Client;

namespace AlbumInventoryClient
{
    public partial class Form_Album_Inventory : Form
    {
        public Form_Album_Inventory()
        {
            InitializeComponent();
        }

        private async void btn_AddAlbum_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7024");
            var client = new AlbumService.AlbumServiceClient(channel);
            using var call = client.ListAlbums(new ListAlbumsRequest());

            try
            {
                AddAlbumRequest addAlbum = new AddAlbumRequest();

                // assign all
                addAlbum.Title = textBox_Title.Text;
                addAlbum.Genre = textBox_Genre.Text;
                addAlbum.Year = Int32.Parse(textBox_Year.Text);

                var response = await client.AddAlbumAsync(addAlbum);

                // real-time listView load 
                // TODO: Fix logical error
                // Problem: call.ResponseStream is returning empty. Maybe proto issue
                while (await call.ResponseStream.MoveNext())
                {
                    var albums = call.ResponseStream.Current; // after adding this call is null
                    ListViewItem newItem = new ListViewItem(albums.Id, 0);
                    newItem.SubItems.Add(albums.Title);
                    newItem.SubItems.Add(albums.Genre);
                    newItem.SubItems.Add(albums.Year.ToString());
                    newItem.SubItems.Add(albums.Available.ToString());

                    listView1.Items.Add(newItem);

                }

                MessageBox.Show("Success", response.ToString());
            }
            catch (Grpc.Core.RpcException ex)
            {
                MessageBox.Show("Error while adding", ex.ToString());
            }


            ClearText();
        }

        private async void btn_UpdateAlbum_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7024");
            var client = new AlbumService.AlbumServiceClient(channel);

            try
            {
                UpdateAlbumRequest updateAlbum = new UpdateAlbumRequest();

                // assign all
                updateAlbum.Title = textBox_Title.Text;
                updateAlbum.Genre = textBox_Genre.Text;
                updateAlbum.Year = Int32.Parse(textBox_Year.Text);

                var response = await client.UpdateAlbumAsync(updateAlbum);

                MessageBox.Show("Success", response.ToString());
            }
            catch (Grpc.Core.RpcException ex)
            {
                MessageBox.Show("Error while updating", ex.ToString());
            }


            ClearText();
        }

        private async void btn_DeleteAlbum_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7024");
            var client = new AlbumService.AlbumServiceClient(channel);

            DeleteAlbumRequest deleteId = new DeleteAlbumRequest();
            deleteId.Id = textBox_ID.Text;

            try
            {
                var response = await client.DeleteAlbumAsync(deleteId);

                MessageBox.Show("Success", response.ToString());

            }
            catch (Grpc.Core.RpcException ex)
            {
                MessageBox.Show("Error while deleting", ex.ToString());
            }


            ClearText();
        }



        public void ClearText()
        {
            textBox_Title.Clear();
            textBox_Genre.Clear();
            textBox_Year.Clear();
            textBox_ID.Clear();
        }

    }
}
