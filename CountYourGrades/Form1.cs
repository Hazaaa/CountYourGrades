using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountYourGrades
{
    public partial class MainForm : Form
    {
        private List<Ispit> listaIspita;
        internal List<Ispit> ListaIspita { get => listaIspita; set => listaIspita = value; }

        private bool changed;

        public MainForm()
        {
            InitializeComponent();
            ListaIspita = new List<Ispit>();
            listView1.View = View.Details;
            listView1.Refresh();
            lblbrojIspita.Text = "0";
            lblprosek.Text = "/";
            changed = false;
        }

        public void RefreshList()
        {
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txbIspit.Text) || String.IsNullOrEmpty(txbOcena.Text))
            {
                MessageBox.Show("Add information about course!", "Not enough information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Ispit novi = new Ispit(txbIspit.Text, Int32.Parse(txbOcena.Text));
            listaIspita.Add(novi);
            txbIspit.Focus();
            txbIspit.Text = "";
            txbOcena.Text = "";
            float ukupnaOcena = 0;
            this.RefreshList();
            this.changed = true;

            foreach (var ispit in listaIspita)
            {
                var lvi = listView1.Items.Add(ispit.Name);
                lvi.SubItems.Add(ispit.Grade.ToString());
                ukupnaOcena += ispit.Grade;
            }

            lblbrojIspita.Text = listaIspita.Count.ToString();
            lblprosek.Text = ((float)(ukupnaOcena / listaIspita.Count)).ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close app?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if(listaIspita.Count != 0 && changed)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream((AppDomain.CurrentDomain.BaseDirectory + "ocene.txt"), FileMode.Create)))
                        {
                            sw.WriteLine(listaIspita.Count);
                            foreach (var ispit in listaIspita)
                            {
                                sw.WriteLine(ispit.Name + ":" + ispit.Grade);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error while writing data in file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txbOcena_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Hendluje se ako nije pritisnut broj
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ocene.txt"))
            {
                if(listaIspita.Count != 0)
                {
                    if(MessageBox.Show("Are you sure you want to overwrite current list?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }
                }
                try
                {
                    listaIspita.Clear();
                    using (StreamReader sr = new StreamReader(new FileStream((AppDomain.CurrentDomain.BaseDirectory + "ocene.txt"), FileMode.Open)))
                    {
                        var count = int.Parse(sr.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            String[] ispit = sr.ReadLine().Split(':');
                            listaIspita.Add(new Ispit
                            {
                                Grade = int.Parse(ispit[1]),
                                Name = ispit[0]
                            });
                        }
                        float ukupnaOcena = 0;
                        this.RefreshList();

                        foreach (var ispit in listaIspita)
                        {
                            var lvi = listView1.Items.Add(ispit.Name);
                            lvi.SubItems.Add(ispit.Grade.ToString());
                            ukupnaOcena += ispit.Grade;
                        }

                        lblbrojIspita.Text = listaIspita.Count.ToString();
                        lblprosek.Text = ((float)(ukupnaOcena / listaIspita.Count)).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while reading data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("File doesn't exists!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
