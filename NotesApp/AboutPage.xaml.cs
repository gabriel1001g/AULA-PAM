namespace NotesApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
        InitializeComponent();
	}

    private void PerfilButton_Clicked(object sender, EventArgs e)
    {
        //Instanciar o metodo para depois abrir o metodo
        Uri link = new Uri("https://github.com/GuilhermeRaphael");

        //Metodo para abrir aplicações
        //URI indicador 

        Launcher.OpenAsync(link);
    }
}