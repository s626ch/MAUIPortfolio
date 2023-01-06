namespace LePortfolio;

public partial class AboutPage : ContentPage
{
	public AboutPage()
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
        // BAR FIX NOT NEEDED ON ANDROID
        BarFix.HeightRequest = Math.Max(pageHeight * aspectRatio2, pageWidth);
        BarFix.TranslationY = -60 - pageHeight / 2;
    }

    private async void Discord_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://discord.liloandstit.ch");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }

    private async void SoundCloud_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://soundcloud.com/smolyoshino");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Last_fm_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.last.fm/user/smolyoshino");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void YouTube_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.youtube.com/@smolyoshino");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void GitHub_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/smolyoshino");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Instagram_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://www.instagram.com/smolyoshino/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Steam_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://steamcommunity.com/id/smolyoshino");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Twitter_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://twitter.com/smolyoshino");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void PersonalSite_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://smolyoshino.lol");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Cohost_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://cohost.org/626");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Tumblr_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://tumblr.smolyoshino.lol");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }

    private async void Twitter2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://twitter.com/sillystitchy");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex) { }
    }
}