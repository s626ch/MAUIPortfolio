namespace LePortfolio;

public partial class ProjectsPage : ContentPage
{
	public ProjectsPage()
	{
		InitializeComponent();
	}
    protected override void OnSizeAllocated(double pageWidth, double pageHeight)
    {
        base.OnSizeAllocated(pageWidth, pageHeight);
        const double aspectRatio = 3840 / 2160.0; // Aspect ratio of the original image
        const double aspectRatio2 = 2160 / 3840.0;
        backgroundImage.WidthRequest = Math.Max(pageHeight * aspectRatio, pageWidth);
        backgroundImage.HeightRequest = Math.Max(pageWidth * aspectRatio2, pageHeight);
        // BAR FIX NOT NEEDED ON ANDROID BUILD
        BarFix.HeightRequest = Math.Max(pageHeight * aspectRatio2, pageWidth);
        BarFix.TranslationY = -60 - pageHeight / 2;
    }

    private async void VRCMB_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/VRChat-MusicBee-Chatbox");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void KMMVC_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/KMMVC");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void fruitpwnch_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/fruitpwnch");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void spinmusic_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/spin-music");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void funnymediaplayer_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/bad-ux-media-player");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void tweetscraper_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/tweetScraper");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void primitivegui_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino/primitive-gui");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void solomons_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://solomonsscrap.com");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }
}