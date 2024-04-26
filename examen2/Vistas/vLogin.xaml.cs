using System.Security.Principal;

namespace examen2.Vistas;
public partial class vLogin : ContentPage
{
    string[,] usuariosContraseñas = {
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

        for (int i = 0; i < usuariosContraseñas.GetLength(0); i++)
        {
            if (usuariosContraseñas[i, 0] == cajaUsuario)
            {
                usuarioValido = true;
                if (usuariosContraseñas[i, 1] == cajaContrasena)
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
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {

    }
}
