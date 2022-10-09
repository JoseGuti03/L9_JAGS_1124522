namespace L9_JAGS_1124522
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string modelo, marca;
            int precio, disponible, descuento, cambio;
            if (int.TryParse(txt_Precio.Text, out int num))
            {
                MessageBox.Show("Debe ingresar un numero");
            }
            else
            {
                if (int.TryParse(txt_TipodeCambioDolar.Text, out int num1))
                {
                    MessageBox.Show("Debe ingresar numero no letra");
                }
                else
                {
                    if (int.TryParse(txt_DescuentoAplicado.Text, out int num2))
                    {
                        MessageBox.Show("Debe ingresar un numero");
                    }
                    else
                    {
                        if (int.TryParse(txt_Disponible.Text, out int num3))
                        {
                            MessageBox.Show("Debe ingresar un numero");
                        }
                        else
                        {

                        }
                    }

                }
                precio = Convert.ToInt32(txt_Precio.Text);
                cambio = Convert.ToInt32(txt_TipodeCambioDolar.Text);
                descuento = Convert.ToInt32(txt_DescuentoAplicado);
                disponible = Convert.ToInt32(txt_Disponible.Text);
                marca = Convert.ToString(txt_Marca.Text);
                modelo = Convert.ToString(txt_Modelo.Text);



                lbl_Precio.Text = precio.ToString();
                lbl_Disponible.Text = disponible.ToString();
                lbl_TipodeCambioDolar.Text = cambio.ToString();
                lbl_Descuento.Text = descuento.ToString();
                lbl_Marca.Text = marca.ToString();
                lbl_Modelo.Text = modelo.ToString();
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Precio.Clear();
            txt_DescuentoAplicado.Clear();
            txt_Disponible.Clear();
            txt_Marca.Clear();
            txt_Modelo.Clear();
            txt_TipodeCambioDolar.Clear();
            txt_DescuentoAplicado.Clear();
            lbl_resultado.Text = "";
        }
    }
}