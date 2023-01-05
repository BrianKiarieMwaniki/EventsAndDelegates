using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAndDelegates.Services
{
    public class MessageService
    {
        public MessageService(VideoEncoder videoEncoder)
        {
            videoEncoder.OnVideoEncoded += HandleVideoEncoded;
        }

        protected virtual void HandleVideoEncoded(object sender, VideoEventArgs e)
        {
            VideoHelper.SendVideo(e.Video);
            System.Console.WriteLine("Sent by SMS Service");
        }
    }
}