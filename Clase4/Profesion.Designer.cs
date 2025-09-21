namespace Clase4
{
    partial class Profesion
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
            this.elimProBtn = new System.Windows.Forms.Button();
            this.editProBtn = new System.Windows.Forms.Button();
            this.agrProBtn = new System.Windows.Forms.Button();
            this.nomProTxt = new System.Windows.Forms.TextBox();
            this.nroProTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grillaProf = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProf)).BeginInit();
            this.SuspendLayout();
            // 
            // elimProBtn
            // 
            this.elimProBtn.Location = new System.Drawing.Point(50, 274);
            this.elimProBtn.Name = "elimProBtn";
            this.elimProBtn.Size = new System.Drawing.Size(180, 37);
            this.elimProBtn.TabIndex = 46;
            this.elimProBtn.Text = "Eliminar";
            this.elimProBtn.UseVisualStyleBackColor = true;
            this.elimProBtn.Click += new System.EventHandler(this.elimProBtn_Click);
            // 
            // editProBtn
            // 
            this.editProBtn.Location = new System.Drawing.Point(50, 230);
            this.editProBtn.Name = "editProBtn";
            this.editProBtn.Size = new System.Drawing.Size(180, 37);
            this.editProBtn.TabIndex = 45;
            this.editProBtn.Text = "Editar";
            this.editProBtn.UseVisualStyleBackColor = true;
            this.editProBtn.Click += new System.EventHandler(this.editProBtn_Click);
            // 
            // agrProBtn
            // 
            this.agrProBtn.Location = new System.Drawing.Point(50, 184);
            this.agrProBtn.Name = "agrProBtn";
            this.agrProBtn.Size = new System.Drawing.Size(180, 37);
            this.agrProBtn.TabIndex = 44;
            this.agrProBtn.Text = "Agregar";
            this.agrProBtn.UseVisualStyleBackColor = true;
            this.agrProBtn.Click += new System.EventHandler(this.agrProBtn_Click);
            // 
            // nomProTxt
            // 
            this.nomProTxt.Location = new System.Drawing.Point(50, 146);
            this.nomProTxt.Name = "nomProTxt";
            this.nomProTxt.Size = new System.Drawing.Size(133, 20);
            this.nomProTxt.TabIndex = 43;
            // 
            // nroProTxt
            // 
            this.nroProTxt.Location = new System.Drawing.Point(50, 96);
            this.nroProTxt.Name = "nroProTxt";
            this.nroProTxt.Size = new System.Drawing.Size(88, 20);
            this.nroProTxt.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nombre Profesion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "NroProfesion";
            // 
            // grillaProf
            // 
            this.grillaProf.AllowUserToAddRows = false;
            this.grillaProf.AllowUserToDeleteRows = false;
            this.grillaProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProf.Location = new System.Drawing.Point(270, 77);
            this.grillaProf.Name = "grillaProf";
            this.grillaProf.ReadOnly = true;
            this.grillaProf.RowHeadersWidth = 51;
            this.grillaProf.RowTemplate.Height = 24;
            this.grillaProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProf.Size = new System.Drawing.Size(522, 315);
            this.grillaProf.TabIndex = 39;
            this.grillaProf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProf_CellClick);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 52;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // Profesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 440);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimProBtn);
            this.Controls.Add(this.editProBtn);
            this.Controls.Add(this.agrProBtn);
            this.Controls.Add(this.nomProTxt);
            this.Controls.Add(this.nroProTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grillaProf);
            this.Name = "Profesion";
            this.Text = "Profesion";
            this.Load += new System.EventHandler(this.Profesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button elimProBtn;
        private System.Windows.Forms.Button editProBtn;
        private System.Windows.Forms.Button agrProBtn;
        private System.Windows.Forms.TextBox nomProTxt;
        private System.Windows.Forms.TextBox nroProTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView grillaProf;
        private System.Windows.Forms.Button volverBtn;
    }
}