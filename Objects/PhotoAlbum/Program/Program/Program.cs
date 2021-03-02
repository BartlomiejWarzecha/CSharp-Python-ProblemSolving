using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum firstAlbum = new PhotoAlbum();
            Console.WriteLine($"Default constructor {firstAlbum.numberOfPages}");

            PhotoAlbum secondAlbum = new PhotoAlbum(24);
            Console.WriteLine($"24 pages constructor {secondAlbum.numberOfPages}");

            PhotoAlbum thirdAlbum = new BigPhotoAlbum();
            Console.WriteLine($"BigPhotoalbum Constructor {thirdAlbum.numberOfPages}");
        }
    }
}
