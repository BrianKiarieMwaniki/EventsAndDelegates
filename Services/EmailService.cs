namespace EventsAndDelegates.Services
{
    public class EmailService
    {
        public EmailService(VideoEncoder videoEncoder)
        {
            videoEncoder.OnVideoEncoded += HandleVideoEncoded;
        }

        void HandleVideoEncoded(object sender, VideoEventArgs e)
        {
            //access the video after it's encoded in this code and do whatever
            VideoHelper.SendVideo(e.Video);
            Console.WriteLine($"Send {e.Video.Title} by EmailService");
        }
    }
}