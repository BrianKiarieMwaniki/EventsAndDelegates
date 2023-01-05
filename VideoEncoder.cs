namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs>? OnVideoEncoded;

        public void EncodeVideo(Video video)
        {
            OnHandleVideoEncoded(new VideoEventArgs(video));
        }

        protected virtual void OnHandleVideoEncoded(VideoEventArgs e)
        {
            EventHandler<VideoEventArgs>? encodeEvent = OnVideoEncoded;

            if(encodeEvent is not null)
            {
                e.Video = new Video {Title = "Events Tutorial Video"};

                encodeEvent(this,e);
            }
        }
    }
}