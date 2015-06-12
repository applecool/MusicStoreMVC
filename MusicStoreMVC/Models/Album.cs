﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStoreMVC.Models
{
    class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }
    }
}
