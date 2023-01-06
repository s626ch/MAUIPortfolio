namespace LePortfolio;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnSizeAllocated(double pageWidth, double pageHeight)
    {
        base.OnSizeAllocated(pageWidth, pageHeight);
        //const double aspectRatio = 2268 / 4032.0; // Aspect ratio of the original image
        //const double aspectRatio2 = 4032 / 2268.0;
        const double aspectRatio = 3840 / 2160.0; // Aspect ratio of the original image
        const double aspectRatio2 = 2160 / 3840.0;
        backgroundImage.WidthRequest = Math.Max(pageHeight * aspectRatio, pageWidth);
		backgroundImage.HeightRequest = Math.Max(pageWidth * aspectRatio2, pageHeight);
        // BAR FIX NOT NEEDED ON ANDROID
        BarFix.HeightRequest = Math.Max(pageHeight * aspectRatio2, pageWidth);
        BarFix.TranslationY = -60 - pageHeight / 2;
    }
}

