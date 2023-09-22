namespace TarefasAPP
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            List<Tarefas> tarefas = new List<Tarefas>()
            {
                new Tarefas { Name = "Tirar o Lixo", Descrition = " Jogar Lixo fora a noite " },
                new Tarefas { Name = "Alimentar os bichos", Descrition = " Alimente os bichos antes de dormi " },
                new Tarefas { Name = "Escovar os dentes", Descrition = " Escove os dentes 3 vezes ao dia " },
            };
            listTarefas.ItemsSource = tarefas;
        }
        public class Tarefas
        {
            public string Name { get; set; }
            public String Descrition { get; set; }
        } 
}