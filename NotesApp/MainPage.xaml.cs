

namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        //essa biblioteca cuida de todo metodo de arquivos
        // File.WriteAllText vai salvar o texto que for escrito pelo utilizador
        string caminho = FileSystem.AppDataDirectory;
        string arquivo = "arquivo.txt";

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(Path.Combine(caminho, arquivo)))
            {
                ConteudoEditor.Text = File.ReadAllText(Path.Combine(caminho, arquivo));
            }
        }

        private void SalvarButton_Clicked(object sender, EventArgs e)
        {
            //O conteudo vai armazenar oq for escrito em conteudo e o .text e para pegar o texto
            string conteudo = ConteudoEditor.Text;

            //Path.combine ele vai combinar os elementos 
            File.WriteAllText(Path.Combine(caminho, arquivo), conteudo);
            DisplayAlert("OK", "Arquivo Salvo", "Valeu");
           //So funciona no mobile == Toast.MakeText("Arquivo Salvo");
        }

        private void DeletarButton_Clicked(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(caminho, arquivo));
            DisplayAlert("Oi",$"O arquivo {arquivo} foi apagado com sucesso","OK");
            ConteudoEditor.Text = "";
        }

      
    }

}
