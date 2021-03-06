﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Clases;
using System.Data.SqlClient;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class VentanaTramo : Form
    {

        public VentanaTramo()
        {
            InitializeComponent();
        }

        private void VentanaTramo_Load(object sender, EventArgs e)
        {
            this.llenarCombo(listaOrigen, "SELECT distinct id_origen FROM [LEISTE_EL_CODIGO?].Tramo");
            this.llenarCombo(listaDestino, "SELECT distinct id_destino FROM [LEISTE_EL_CODIGO?].Tramo");
        }


        private void botonCrear_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposEstancompletos())
            {
                string origen = listaOrigen.SelectedItem.ToString();
                string destino = listaDestino.SelectedItem.ToString();
                int precio = Convert.ToInt16(textoPrecio.Text);

                try
                {
                    BaseDeDato bd = new BaseDeDato();
                    DataTable dt;
                    SqlCommand procedure = Clases.BaseDeDato.crearConsulta("[LEISTE_EL_CODIGO?].crearTramo");
                    procedure.CommandType = CommandType.StoredProcedure;
                    //procedure.Parameters.Add("@idRecorrido", SqlDbType.Decimal).Value = de donde saco el id de rec?
                    procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = this.listaOrigen.SelectedItem.ToString();
                    procedure.Parameters.Add("@origen", SqlDbType.NVarChar).Value = this.listaDestino.SelectedItem.ToString();
                    //procedure.Parameters.Add("@orden", SqlDbType.SmallInt).Value = de donde saco el orden?
                    procedure.Parameters.Add("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(textoPrecio.Text);
                    dt = bd.obtenerDataTable(procedure);
                    //this.dataGridViewTop5s.DataSource = dt;
                    //this.dataGridViewTop5s.Refresh();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos para seguir", "FrbaCruceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool todosLosCamposEstancompletos()
        {

            return textoPrecio.Text != "";

        }

        private void listaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textoPrecio_TextChanged(object sender, EventArgs e)
        {

        }



        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            listaDestino.SelectedIndex = -1;
            listaOrigen.SelectedIndex = -1;
            textoPrecio.Clear();
        }
        public void llenarCombo(ComboBox cb, string consultaDeObtencion)
        {

            BaseDeDato db = new BaseDeDato();
            db.conectar();
            SqlConnection conexion = db.obtenerConexion();
            SqlCommand consulta = new SqlCommand(consultaDeObtencion, conexion);
            List<String> listaDeTramos = db.obtenerListaDeDatos(consulta);
            cb.DataSource = listaDeTramos;
            cb.SelectedIndex = 0;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            db.desconectar();
        }

    }


}