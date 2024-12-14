namespace CONEXIONBASEDEDATOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GUARDARDATOS_Click(object sender, EventArgs e)
        {
            VacasID VACA = new VacasID();
            VACA.Nombre = VACANOMBRE.Text;
            VACA.Raza = TXTRAZA.Text;
            VACA.Estado = VACAESTADO.Text;
            
            int result = VACASDAL.AgregarVaca(VACA);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
                else
                {
                    MessageBox.Show("Fallo al Guardar");
                }
            refressPantalla();
        }
        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            VacasID VACA = new VacasID();
            VACA.Nombre = VACANOMBRE.Text;
            VACA.Raza = TXTRAZA.Text;
            VACA.Estado = VACAESTADO.Text;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDVACA"].Value);
            VACA.IDVACA = id;
            int result = VACASDAL.modificarvaca(VACA);

            if (id != null)
            {
                MessageBox.Show("Exito al Modificar");
            }
            else
            {
                MessageBox.Show("Error al Modificar");
            }
            refressPantalla();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["IDVACA"].Value);
            VACANOMBRE.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            TXTRAZA.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Raza"].Value);
            VACAESTADO.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Estado"].Value);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refressPantalla();
            TXTID.Enabled = false;
        }

        public void refressPantalla()
        {
            dataGridView1.DataSource = VACASDAL.PresentarRegistro();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            TXTID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["IDVACA"].Value);
            VACANOMBRE.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            TXTRAZA.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Raza"].Value);
            VACAESTADO.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Estado"].Value);
        }
        private void IDLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VACASDAL.PresentarRegistro();
        }

        private void BLIMPIAR_Click(object sender, EventArgs e)
        {
            TXTID.Clear();
            VACANOMBRE.Clear();
            TXTRAZA.Clear();
            VACAESTADO.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDVACA"].Value);
                int resultado = VACASDAL.EliminarVaca(id);
                if(resultado > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            refressPantalla();
        }

        private void BSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}