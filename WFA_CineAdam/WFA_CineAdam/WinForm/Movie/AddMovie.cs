using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_CineAdam.Class;
using WFA_CineAdam.Abstract;
using WFA_CineAdam.Data;


namespace WFA_CineAdam.WinForm.Movie
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        Film film = new Film();
        ListViewItem lvi = new ListViewItem();

        private void btnSave_Click(object sender, EventArgs e)
        {

            film.Name = txtMovieName.Text;
            film.Description = txtDescription.Text;
            film.Saloon = (Saloon)cmbSalon.SelectedItem;
            film.Duration = Convert.ToInt32(txtDuration.Text);
            string result = film.AddMovie(film);
            MessageBox.Show(result);
            FillListView();
            MovieForm mvf = new MovieForm();
            mvf.listView1.Items.Add(lvi);
            mvf.Show();
        }

        public void FillListView()
        {
            for (int i = 0; i <= DataBase.Filmler.Count - 1; i++)
            {
                if (i == 0)
                {
                    lvi.Text = DataBase.Filmler[i].ToString();
                }
                else
                {
                    lvi.SubItems.Add(DataBase.Filmler[i].ToString());
                }
            }
        }
        Saloon saloon = new Saloon();

        private void AddMovie_Load(object sender, EventArgs e)
        {

            foreach (Saloon saloon in saloon.GetSaloon())
            {
                cmbSalon.Items.Add(saloon);
            }


        }
    }
}
