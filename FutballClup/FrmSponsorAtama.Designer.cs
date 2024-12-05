namespace FutballClup
{
    partial class FrmSponsorAtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSponsor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMakeSponsor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım:";
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(79, 24);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(240, 21);
            this.cmbTeam.TabIndex = 1;
            this.cmbTeam.TextChanged += new System.EventHandler(this.cmbTeam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sponsor:";
            // 
            // cmbSponsor
            // 
            this.cmbSponsor.FormattingEnabled = true;
            this.cmbSponsor.Location = new System.Drawing.Point(79, 51);
            this.cmbSponsor.Name = "cmbSponsor";
            this.cmbSponsor.Size = new System.Drawing.Size(240, 21);
            this.cmbSponsor.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnMakeSponsor
            // 
            this.btnMakeSponsor.Location = new System.Drawing.Point(79, 91);
            this.btnMakeSponsor.Name = "btnMakeSponsor";
            this.btnMakeSponsor.Size = new System.Drawing.Size(240, 29);
            this.btnMakeSponsor.TabIndex = 3;
            this.btnMakeSponsor.Text = "Sponsor Ata";
            this.btnMakeSponsor.UseVisualStyleBackColor = true;
            this.btnMakeSponsor.Click += new System.EventHandler(this.btnMakeSponsor_Click);
            // 
            // FrmSponsorAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 409);
            this.Controls.Add(this.btnMakeSponsor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbSponsor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.label1);
            this.Name = "FrmSponsorAtama";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSponsorAtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSponsor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMakeSponsor;
    }
}

