namespace ControlEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Registrar()
        {
            if (txt_Usuario.Text.Length > 8)
            {
                if (txt_Clave.Text == txt_RepetirClave.Text)
                {
                    MessageBox.Show("Usuario registrado");
                }
                else
                {
                    MessageBox.Show("Las claves no coinciden");
                }
            }
            else
            {
                MessageBox.Show("El usuario debe tener mas de 8 caracteres");
            }
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsLetter(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Space
            );
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsLetter(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Space
            );
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void cmb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Region.SelectedIndex)
            {
                case 0: //Costa
                    cmb_Provincia.Text = "";
                    cmb_Provincia.Items.Clear();
                    cmb_Provincia.Items.AddRange(
                        new string[]
                        {
                            "El Oro",
                            "Esmeraldas",
                            "Guayas",
                            "Los Ríos",
                            "Manabí",
                            "Santa Elena",
                            "Santo Domingo de los Tsachilas",
                        }
                    );
                    break;
                case 1: // Sierra
                    cmb_Provincia.Text = "";
                    cmb_Provincia.Items.Clear();
                    cmb_Provincia.Items.AddRange(
                        new string[]
                        {
                            "Azuay",
                            "Bolívar",
                            "Cañar",
                            "Carchi",
                            "Chimborazo",
                            "Cotopaxi",
                            "Imbabura",
                            "Loja",
                            "Pichincha",
                            "Tungurahua",
                        }
                    );
                    break;
                case 2: // Oriente
                    cmb_Provincia.Text = "";
                    cmb_Provincia.Items.Clear();
                    cmb_Provincia.Items.AddRange(
                        new string[]
                        {
                            "Morona Santiago",
                            "Napo",
                            "Orellana",
                            "Pastaza",
                            "Sucumbíos",
                            "Zamora Chinchipe",
                        }
                    );
                    break;
            }
        }
    }
}
