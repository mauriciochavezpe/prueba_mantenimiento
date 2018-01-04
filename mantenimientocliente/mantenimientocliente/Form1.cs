using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using System.Data.Sql;


namespace mantenimientocliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrardatos();
        }

        private void mostrardatos()
        {
            dataGridView1.DataSource = Class1.mostrar();
        }
        private void eliminardatos()
        {
            dataGridView1.DataSource = Class1.eliminar(Convert.ToInt32(txtid.Text));

        }
     private void agregardatos()
        {
            if (txtid.Text == string.Empty)

            { Class1.insertar(txtnom.Text, txtap.Text, txtdoc.Text.Trim(), txttelf.Text.Trim(), txtcorreo.Text);
                mostrardatos();
            }
            else
            {
                Class1.editar(Convert.ToInt32(txtid.Text), txtnom.Text, txtap.Text, txtdoc.Text, txttelf.Text, txtcorreo.Text);

                mostrardatos();
            }
        }
        private void BTAGREGAR_Click(object sender, EventArgs e)
        {
            agregardatos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtid.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            this.txtnom.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            this.txtap.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            this.txtdoc.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            this.txttelf.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
            this.txtcorreo.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void BTELIMINAR_Click(object sender, EventArgs e)
        {
            Class1.eliminar(int.Parse(txtid.Text));
            mostrardatos();
        }

        private void BTMODIFICAR_Click(object sender, EventArgs e)  
        {
                                   
            agregardatos();
                    
        }
    }
}
