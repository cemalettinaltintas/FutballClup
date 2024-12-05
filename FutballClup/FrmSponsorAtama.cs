using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutballClup
{
    public partial class FrmSponsorAtama : Form
    {
        public FrmSponsorAtama()
        {
            InitializeComponent();
        }
        FootballClupDbEntities db=new FootballClupDbEntities();
        private void FrmSponsorAtama_Load(object sender, EventArgs e)
        {
            var teams=db.Teams.ToList();
            cmbTeam.DisplayMember = "TeamName";
            cmbTeam.ValueMember = "TeamId";
            cmbTeam.DataSource = teams;

            DataGridViewButtonColumn btn1= new DataGridViewButtonColumn();
            btn1.HeaderText = "Sil";
            btn1.Text = "Sil";
            btn1.Name = "Sil";
            btn1.UseColumnTextForButtonValue = true;
            btn1.DefaultCellStyle.BackColor = Color.DarkRed;
            btn1.Width = 50;
            dataGridView1.Columns.Add(btn1);    

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void cmbTeam_TextChanged(object sender, EventArgs e)
        {
            SponsorList();
            LoadSponsorToCombobox();
        }
        private void SponsorList()
        {
            int takimId = int.Parse(cmbTeam.SelectedValue.ToString());
            var team=db.Teams.Find(takimId);
            var sponsors = db.Teams.Find(takimId).Sponsors.ToList();

            var values=(from s in sponsors
                        select new
                        {
                            TeamId=team.TeamId,
                            SponsorId=s.SponsorId,
                            Takım=team.TeamName,
                            Sponsor=s.SponsorName
                        }).ToList();

            dataGridView1.DataSource = values;
        }

        private void LoadSponsorToCombobox()
        {
            int takimId=int.Parse(cmbTeam.SelectedValue.ToString());
            var takim=db.Teams.Find(takimId);

            var takimSponsors= takim.Sponsors.ToList();

            var allSponsors = db.Sponsors.ToList();

            var farkList=allSponsors.Except(takimSponsors).ToList();

            if (takimSponsors.Count==allSponsors.Count)
            {
                cmbSponsor.Text = "";
            }
            cmbSponsor.DisplayMember = "SponsorName";
            cmbSponsor.ValueMember = "SponsorId";
            cmbSponsor.DataSource = farkList;
        }

        private void btnMakeSponsor_Click(object sender, EventArgs e)
        {
            int takimId = int.Parse(cmbTeam.SelectedValue.ToString());
            var takim = db.Teams.Find(takimId);

            if (cmbSponsor.Items.Count>0)
            {
                int sponsorId = int.Parse(cmbSponsor.SelectedValue.ToString());
                var sponsor = db.Sponsors.Find(sponsorId);

                takim.Sponsors.Add(sponsor);
                db.SaveChanges();
            }
            SponsorList();
            LoadSponsorToCombobox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Sil"].Index)
            {
                int takimId =int.Parse(dataGridView1.Rows[e.RowIndex].Cells["TeamId"].Value.ToString());
                var takim = db.Teams.Find(takimId);

                int sponsorId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["SponsorId"].Value.ToString());
                var sponsor = db.Sponsors.Find(sponsorId);

                takim.Sponsors.Remove(sponsor);
                //sponsor.Teams.Remove(takim);

                db.SaveChanges();
                SponsorList();
                LoadSponsorToCombobox();
            }
        }
    }
}
