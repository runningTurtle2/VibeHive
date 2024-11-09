using System.Collections.Concurrent;
using Grpc.Core;

namespace AlbumAPI.Services
{
    public class AlbumAPi : AlbumAPI.AlbumService.AlbumServiceBase
    {
        // Store Users
        private static readonly ConcurrentDictionary<string, Album> _album = new();

        public override Task<AddAlbumResponse> AddAlbum(AddAlbumRequest request, ServerCallContext context)
        {
            // Unique ID
            var albumId = Guid.NewGuid().ToString();

            var album = new Album
            {
                Id = albumId,
                Title = request.Title,
                Genre = request.Genre,
                Year = request.Year,
                Available = true // default
            };

            // add album
            if(_album.TryAdd(albumId, album))
            {
                return Task.FromResult(new AddAlbumResponse { Id = albumId});
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to create an album"));
            }

        }

        
        public override Task<Album> GetAlbum(GetAlbumRequest request, ServerCallContext context)
        {
            if(_album.TryGetValue(request.Id, out var album))
            {
                return Task.FromResult(album);
            }
            else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Album not found with Id: {request.Id}"));
            }
        }

        public override Task<UpdateAlbumResponse> UpdateAlbum(UpdateAlbumRequest request, ServerCallContext context)
        {
            // new object with new userdata
            var album = new Album
            {
                Title = request.Title,
                Genre = request.Genre,
                Year = request.Year,
                Available = request.Available
            };

            if(_album.TryGetValue(request.Id, out var existingAlbum))
            {
                if(_album.TryUpdate(request.Id, album, existingAlbum))
                {
                    return Task.FromResult(new UpdateAlbumResponse { Title = request.Title });
                }
                else
                {
                    throw new RpcException(new Status(StatusCode.Internal, "Failed to update album"));

                }
            }
            else
            {
                // could not get the value
                throw new RpcException(new Status(StatusCode.Internal, "Failed to find album"));
            }
        }

        public override Task<DeleteAlbumResponse> DeleteAlbum(DeleteAlbumRequest request, ServerCallContext context)
        {
            if(_album.TryRemove(request.Id, out var album))
            {
                return Task.FromResult(new DeleteAlbumResponse { Id = request.Id });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, $"Failed to Delete Album with ID: {request.Id}"));
            }
        }

        public override async Task ListAlbums(IAsyncStreamReader<ListAlbumsRequest>  requestStream, IServerStreamWriter<Album> responseStream, ServerCallContext context)
        {          
            await foreach(var val in requestStream.ReadAllAsync())
            {

            }

        }
    }
}
