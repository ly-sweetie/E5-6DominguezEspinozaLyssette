using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen5_6
{
    public partial class Form1 : Form
    {

        Tarea tar = new Tarea();
        //Lista de tarea
        List<Tarea> lista = new List<Tarea>();
        InfoTarea tarea = new InfoTarea();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtMenu.Focus();
        }

        private void Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BSubir_Click(object sender, EventArgs e)
        {
            //Se cambia el status
            DataGridViewRow datarow = Info.Rows[tar.IndexRow];
            datarow.Cells[5].Value = txtStatus.Text;
        }

        private void BEnter_Click(object sender, EventArgs e)
        {
            //hacemos el switch para la opcion del menu

            switch (Convert.ToInt32(txtOpcion.Text))
            {

                case 1:
                    //instanciamos la forma para llamarla 
                    InfoTarea captura = new InfoTarea();

                    for (int r = 0; r < 5; r++)

                    {
                       
                        if (tarea.ShowDialog() == DialogResult.OK)
                        {
                            Tarea t = new Tarea();
                            captura.Focus();

                            //Que se agrege a la tabla cada uno de los aspectos
                            Info.Rows.Add();
                            Info.Rows[r].Cells[0].Value = tarea.TxtUser.Text;
                            t.Usuario = tarea.TxtUser.Text;
                            Info.Rows[r].Cells[1].Value = tarea.TxtDate.Text;
                            t.Fecha = tarea.TxtDate.Text;
                            Info.Rows[r].Cells[2].Value = tarea.TxtName.Text;
                            t.Nombre = tarea.TxtName.Text;
                            Info.Rows[r].Cells[3].Value = tarea.TxtDesc.Text;
                            t.Descripcion = tarea.TxtDesc.Text;
                            Info.Rows[r].Cells[4].Value = tarea.TxtHour.Text;
                            t.Hora = tarea.TxtHour.Text;
                            Info.Rows[r].Cells[5].Value = tarea.TxtStatus.Text;
                            t.Status = tarea.TxtStatus.Text;
                            lista.Add(t);

                            //Borrar datos
                            tarea.TxtUser.Clear();
                            tarea.TxtDate.Clear();
                            tarea.TxtName.Clear();
                            tarea.TxtDesc.Clear();
                            tarea.TxtHour.Clear();
                            tarea.TxtStatus.Clear();
                        }
                    }
                    break;
                case 2:
                    //instanciamps la forma captura
                    Texto data = new Texto();
                    data.Focus();
                    data.Show(this);
                    //por cada elemento guardado en la lista hacemos que se imprima en el txtbox que tenemos en esa forma, el eviromen,newline es para que genere otra linea
                    foreach (Tarea f in lista)
                    {
                        data.TxtDetalle.Text += f.Usuario + " " + Environment.NewLine
                           + f.Nombre + " " + Environment.NewLine
                           + f.Fecha + " " + Environment.NewLine
                           + f.Hora + " " + Environment.NewLine
                            + f.Descripcion + " " + Environment.NewLine
                           + f.Status + " " + Environment.NewLine
                           + "____________________________________" + Environment.NewLine;

                    }
                    break;
                default:
                    MessageBox.Show("Seleccione una opcion valida");
                    break;

            }
        }

        private void BMenu_Click(object sender, EventArgs e)
        {
           //Mostrar el menu de opciones
            TxtMenu.Text = "1. Crear tarea\r\n2. Detalles de tareas";
            TxtMenu.Show();
        }
    }
}
