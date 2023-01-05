namespace EventsAndDelegates.Utils
{
    public static class VideoHelper
    {
        public static void SendVideo(Video video)
        {
            System.Console.WriteLine($"video {video.Title} was sent!");
        }
    }
}