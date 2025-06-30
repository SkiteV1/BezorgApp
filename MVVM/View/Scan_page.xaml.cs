using Microsoft.Maui.Controls;
using System;
using System.IO;

namespace BezorgApp.MVVM.View;


public partial class Scan_page : ContentPage
{
	public Scan_page()
	{
		InitializeComponent();
	}

    private async void TakePhotoClicked(object sender, EventArgs e)
    {
        try
        {
            FileResult photo = await MediaPicker.CapturePhotoAsync();

            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                PhotoPreview.Source = ImageSource.FromStream(() => stream);
                PhotoPreview.IsVisible = true;
            }
        }
        
        catch (FeatureNotSupportedException)
        {
            await DisplayAlert("Fout", "Camera wordt niet ondersteund op dit apparaat.", "OK");
        }
        catch (PermissionException)
        {
            await DisplayAlert("Fout", "Geen toestemming om camera te gebruiken.", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Fout", $"Er is iets misgegaan bij het maken van de foto. Probeer dit opnieuw. {ex.Message}", "OK");
        }
    }

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
