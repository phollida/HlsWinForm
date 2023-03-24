using Microsoft.Web.WebView2.Core;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebViewWinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeAsync();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {

    }

    async void InitializeAsync()
    {
        await webView21.EnsureCoreWebView2Async(null);
        if (webView21.CoreWebView2 != null)
        {
            var profile = webView21.CoreWebView2.Profile;
            await profile.ClearBrowsingDataAsync();
        }

    }
    private async void button1_Click(object sender, EventArgs e)
    {
        if (webView21.CoreWebView2 != null)
        {
            var profile = webView21.CoreWebView2.Profile;
            await profile.ClearBrowsingDataAsync();
            webView21.CoreWebView2?.Navigate("http://localhost:8080/video/");
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        if (webView21.CoreWebView2 != null)
        {
            var profile = webView21.CoreWebView2.Profile;
            await profile.ClearBrowsingDataAsync();
            webView21.CoreWebView2?.NavigateToString(testPage);
        }
    }

    private static readonly string testPage =
        @"
<html>
  <head>
    <title>Hls.js demo - basic usage</title>
  </head>

  <body>
    <script src=""https://cdn.jsdelivr.net/npm/hls.js@1""></script>

    <center>
      <h1>Raw HTML to open video at http://192.168.0.54:8080/video/out.m3u8</h1>
      <video height=""600"" id=""video"" controls></video>
    </center>

    <script>
      var video = document.getElementById('video');
      if (Hls.isSupported()) {
        var hls = new Hls({
          debug: true,
        });
        hls.loadSource('http://192.168.0.54:8080/video/out.m3u8');
        hls.attachMedia(video);
		hls.on(Hls.Events.ERROR, function (event, data) {
                if (data.fatal) {
                    switch (data.type) {
                        case Hls.ErrorTypes.NETWORK_ERROR:
                            // try to recover network error
                            alert('fatal network error encountered, try to recover '+source );
                            hls.startLoad();
                            break;
                        case Hls.ErrorTypes.MEDIA_ERROR:
                            alert('fatal media error encountered, try to recover');
                            hls.recoverMediaError();
                            break;
                        default:
                            // cannot recover
                            alert('fatal error encountered, cannot recover');
                            hls.destroy();
                            break;
                    }
                }
            });
        hls.on(Hls.Events.MEDIA_ATTACHED, function () {
          video.muted = true;
          video.play();
        });
      }
      // hls.js is not supported on platforms that do not have Media Source Extensions (MSE) enabled.
      // When the browser has built-in HLS support (check using `canPlayType`), we can provide an HLS manifest (i.e. .m3u8 URL) directly to the video element through the `src` property.
      // This is using the built-in support of the plain video element, without using hls.js.
      else if (video.canPlayType('application/vnd.apple.mpegurl')) {
        video.src = 'http://192.168.0.54:8080/video/out.m3u8';
        video.addEventListener('canplay', function () {
          video.play();
        });
      }
    </script>
  </body>
</html>";


}