using System.ComponentModel;


namespace MauiApp1;

public partial class MainPage : ContentPage 
{
	


    private void Sv(object sender, EventArgs e)
    {
		DisplayAlert("Sauvegarder", "xxx","Ok"); ;
    }

	public event PropertyChangedEventHandler PropetyChanged;

    string note;
    public string Note
    {
        get => note;
        set
        {
            note = value;
            var args = new PropertyChangedEventArgs(nameof(Note));
           
        }
        
    }
}

