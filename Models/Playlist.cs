namespace Tunify_Platform
{
    public class Playlist
    {
        public int PlaylistID { get; set; }
        public int ModelUserID { get; set; }
        public ModelUser User { get; set; }
        public string PlaylistName { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}
