using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaApp
{
    public partial class Form1 : Form
    {
        Stack<string> pila;
        public Form1()
        {
            InitializeComponent();
            pila = new Stack<string>();
            ActualizarListaPila();
            this.CenterToScreen();
        }
        // Método para actualizar el ListBox y la etiqueta de cuenta
        private void ActualizarListaPila()
        {
            lstPila.Items.Clear();
            foreach (var item in pila)
            {
                lstPila.Items.Add(item);
            }
            lblCount.Text = $"Elementos en la pila: {pila.Count}";
        }
        private void txtElemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Botón Push: Añadir un elemento a la pila
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElemento.Text))
            {
                pila.Push(txtElemento.Text);
                txtElemento.Clear();
                ActualizarListaPila();
            }
            else
            {
                MessageBox.Show("Ingrese un elemento para añadir a la pila.");
            }
        }

        // Botón Pop: Eliminar el elemento en el tope de la pila
        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                string elemento = pila.Pop();
                MessageBox.Show($"Elemento '{elemento}' eliminado de la pila.");
                ActualizarListaPila();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        // Botón Peek: Ver el elemento en el tope sin eliminarlo
        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                string elemento = pila.Peek();
                MessageBox.Show("Elemento en el tope: "+ elemento);
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        // Botón Clear: Limpiar la pila
        private void btnClear_Click(object sender, EventArgs e)
        {
            pila.Clear();
            MessageBox.Show("La pila ha sido vaciada.");
            ActualizarListaPila();
        }
    

    private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }
}
