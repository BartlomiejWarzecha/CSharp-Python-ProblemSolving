using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class PhotoAlbum
    { 
        public int numberOfPages { get; protected set; }

        public PhotoAlbum(int pages = 16)
        {
            numberOfPages = pages;
        }

    }
}
