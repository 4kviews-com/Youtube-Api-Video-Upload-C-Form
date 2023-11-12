using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Upload;
using System;
using System.IO;

namespace YTUpload_Video_4kviews.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void youtubeuploadedit ()
        {

            // Define your API key here
            string apiKey = "YOUR_API_KEY";
            // Create a YouTube Data API client
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
            });
            // Prepare video upload information
            Video video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = "Video Title";
            video.Snippet.Description = "Video Description";
            video.Snippet.Tags = new string[] { "tag1", "tag2" };
            video.Snippet.CategoryId = "22"; // Specify the category ID (Gaming category)

            // Upload the video file
            using (var fileStream = new FileStream("video.mp4", FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet", fileStream, "video/*");
                videosInsertRequest.Upload();
            }
            MessageBox.Show("Video uploaded.");
            // 4kviews.com
            //ipv6builder.com

        }
        private void uploadyt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The system works stably. You need to organize certain areas according to yourself. Edit the 'youtubeuploadedit' field. :)");
            //youtubeuploadedit();
        }
    }
}