using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAndDelegates.Models
{
    public class VideoEventArgs : EventArgs
    {
        public VideoEventArgs(Video video)
        {
            Video = video;
        }

        public Video Video { get; set; }
    }
}