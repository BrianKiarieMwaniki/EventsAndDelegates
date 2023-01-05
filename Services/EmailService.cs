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
            VideoHelper.SendVideo(e.Video);
            System.Console.WriteLine("Sent by EmailService");
        }
    }
}