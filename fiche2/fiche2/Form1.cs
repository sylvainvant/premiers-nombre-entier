using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiche2
{
    public partial class Fm_principal  : Form
    {
        public Fm_principal ()
        {
            InitializeComponent();
        }

        private void Fm_principal_Load(object sender, EventArgs e)
        {

        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {

             if (tb_saisie.Text == "")
            {
                MessageBox.Show("zone de saisie vide");
            }
             else
             {
                lb_liste.Items.Add(tb_saisie.Text);
                tb_saisie.Text = "";	// ou tb_saisie.Clear()
                tb_saisie.Focus();                        
             }
          

         


        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {


            lb_liste.Items.RemoveAt(lb_liste.SelectedIndex);
         
        }

       
        

    }
}
