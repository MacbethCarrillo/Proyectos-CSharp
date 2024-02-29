using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conexion = "Data Source=GOGOLAP;Initial Catalog=RecetasDB;Integrated Security=True";

        private void btninsert_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Padres(id, nombre, telefono_celular,lugar_trabajo ) VALUES (" + txtidentificador.Text + ",'" + txtdato1.Text + "','" + txtdato2.Text + "','" + txtdato3.Text + "')", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("UPDATE Padres SET nombre = '" + txtdato1.Text + "' , telefono_celular = '" + txtdato2.Text + "' , lugar_trabajo= '" + txtdato3.Text + "' WHERE id =" + txtidentificador.Text + "", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Padres WHERE id =" + txtidentificador.Text + "", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();



                cmd.ExecuteNonQuery();
            }

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {




            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(conexion))

            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + comboBox1.Text + "", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

        }

        private void btnlistacompras_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("EXECUTE GenerarListaCompras", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("EXECUTE ActualizarInventario", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {

                SqlCommand cmd = new SqlCommand("UPDATE Niños SET nombre = '" + txtdato4.Text + "' , edad = '" + txtdato5.Text + "' , nivel= '" + txtdato6.Text + "' , grado= '" + txtdato7.Text + "' WHERE id =" + txtid.Text + "", cn);

                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
