namespace CalculadoraIMC_DISC;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var altura = double.Parse(Altura.Text);
        var peso = double.Parse(Peso.Text);

        var imc = peso / (altura * altura);

        IMC.Text = imc.ToString();

        string resultado = "";


        if (imc < 18.5)
        {
            resultado = "Tienes peso bajo";
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            resultado = "Tienes un peso Normal!";
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            resultado = "Tienes Sobrepeso!";
        }
        else if (imc >= 30)
        {
            resultado = "Tienes obesidad, cuídate!";
        }


        DisplayAlert("Resultado:", resultado, "QUITAR");
    }

}