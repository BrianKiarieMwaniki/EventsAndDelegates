namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs>? OnVideoEncoded;

        public void EncodeVideo(Video video)
        {
            //video encoding takes place here.
            //after encoding is done, the encoded video is passed to the 
            //VideoEventArgs where it can be accessed by event subscribers
            OnHandleVideoEncoded(new VideoEventArgs(video));
        }

        protected virtual void OnHandleVideoEncoded(VideoEventArgs e)
        {
            EventHandler<VideoEventArgs>? encodeEvent = OnVideoEncoded;

            if(encodeEvent is not null)
            {
                e.Video = new Video {Title = "My Video Encoded"};

                encodeEvent(this,e);
            }
        }
    }
}