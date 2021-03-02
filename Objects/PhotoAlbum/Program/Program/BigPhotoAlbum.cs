using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum(int pages = 64) 
        {
            numberOfPages = pages;
        }
    }
}
