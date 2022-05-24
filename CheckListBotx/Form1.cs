using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBotx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int IndiceSeleccionado { get; set; } = 0;
        public List<int> ListIndiceSeleccionados { get; set; } = new List<int>();
        public string checkOpciones { get; set; } = "";


        private void Form1_Load(object sender, EventArgs e)
        {
        }      

        private void btnAddOption(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textAddCheck.Text);
            textAddCheck.Text = "";
        }

        private void getIndexCheckSelected(object sender, EventArgs e)
        {
            IndiceSeleccionado = checkedListBox1.SelectedIndex;
            int SinSeleccionar = -1;

            if (IndiceSeleccionado != SinSeleccionar)
            {            
                ListIndiceSeleccionados.Add(IndiceSeleccionado);
                checkOpciones += 
                    "\n - " + checkedListBox1.Items[IndiceSeleccionado].ToString();
            }
        }

        private void ShowCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su estado civil es: " + checkOpciones);
            eventCheckClick("quitCheck");
        }                

        private void deleteCheck_Click(object sender, EventArgs e)
        {
            eventCheckClick("delete");
        }

        private void eventCheckClick(string action)
        {

            foreach (int indice in ListIndiceSeleccionados)
            {
                if (action == "quitCheck")
                {
                    checkedListBox1.SetItemChecked(indice, false);
                }
                if (action == "delete")
                {
                    checkedListBox1.Items.RemoveAt(indice);
                }
            }

            checkOpciones = "";
            IndiceSeleccionado = 0;
            ListIndiceSeleccionados = new List<int>();
        }
    }
}
