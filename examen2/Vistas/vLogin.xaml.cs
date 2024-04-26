using System.Security.Principal;

namespace examen2.Vistas;
public partial class vLogin : ContentPage
{
    string[,] usuariosContrase�as = {
            {"estudiante2024", "uisrael2024"},
            {"examen1", "parcial1"},
            {"orl", "2024"}
        };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string cajaUsuario = txtUsuario.Text;
        string cajaContrasena = txtContrasena.Text;

        bool usuarioValido = false;
        bool contrasenaValida = false;

        for (int i = 0; i < usuariosContrase�as.GetLength(0); i++)
        {
            if (usuariosContrase�as[i, 0] == cajaUsuario)
            {
                usuarioValido = true;
                if (usuariosContrase�as[i, 1] == cajaContrasena)
                {
                    contrasenaValida = true;
                    break;
                }
            }
        }

        if (usuarioValido && contrasenaValida)
        {
           
            Navigation.PushAsync(new vRegistro(cajaUsuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contrase�a incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {

    }
}
