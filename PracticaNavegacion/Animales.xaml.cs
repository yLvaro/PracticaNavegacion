namespace PracticaNavegacion;

public partial class AnimalesDetalles : ContentPage
{
    public AnimalesDetalles(string nombreAnimal, string texto)
    {
        InitializeComponent();
        // Aqu� puedes usar el nombreAnimal para cargar o mostrar los detalles.
        // Por ejemplo, podr�as tener un Label llamado DetallesLabel:
        Animales.Text = $"Detalles sobre: {nombreAnimal}";
    }

    /*public DetallesAnimalPage()
    {
        InitializeComponent();
        // Este constructor vac�o es necesario si navegas sin pasar par�metros.
    }*/
}