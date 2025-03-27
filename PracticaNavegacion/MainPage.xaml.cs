namespace PracticaNavegacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // Llama al método que inicializa los componentes visuales de la página.
        }
        /// <summary>
        /// Reusamos la clase para la mainPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DetallesBTN(object sender, EventArgs e)
        {
            var main = new Animales
            {
                Nombre = "Home", //Nombre
                Imagen = "logoubu.jpg", //Imagen 
                Texto = "Bienvenido a la práctica de navegación", //Descripción 
            };
            Navigation.PushAsync(new Detalles(main));
        }
    }

}
