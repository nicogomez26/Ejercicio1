namespace Clase4
{
    partial class Nacionalidad
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
            this.elimNacBtn = new System.Windows.Forms.Button();
            this.editNacBtn = new System.Windows.Forms.Button();
            this.agrNacBtn = new System.Windows.Forms.Button();
            this.nomNacTxt = new System.Windows.Forms.TextBox();
            this.nroNacTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grillaNac = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNac)).BeginInit();
            this.SuspendLayout();
            // 
            // elimNacBtn
            // 
            this.elimNacBtn.Location = new System.Drawing.Point(53, 308);
            this.elimNacBtn.Name = "elimNacBtn";
            this.elimNacBtn.Size = new System.Drawing.Size(180, 29);
            this.elimNacBtn.TabIndex = 44;
            this.elimNacBtn.Text = "Eliminar";
            this.elimNacBtn.UseVisualStyleBackColor = true;
            // 
            // editNacBtn
            // 
            this.editNacBtn.Location = new System.Drawing.Point(53, 264);
            this.editNacBtn.Name = "editNacBtn";
            this.editNacBtn.Size = new System.Drawing.Size(180, 36);
            this.editNacBtn.TabIndex = 43;
            this.editNacBtn.Text = "Editar";
            this.editNacBtn.UseVisualStyleBackColor = true;
            this.editNacBtn.Click += new System.EventHandler(this.editNacBtn_Click_1);
            // 
            // agrNacBtn
            // 
            this.agrNacBtn.Location = new System.Drawing.Point(53, 221);
            this.agrNacBtn.Name = "agrNacBtn";
            this.agrNacBtn.Size = new System.Drawing.Size(180, 37);
            this.agrNacBtn.TabIndex = 42;
            this.agrNacBtn.Text = "Agregar";
            this.agrNacBtn.UseVisualStyleBackColor = true;
            this.agrNacBtn.Click += new System.EventHandler(this.agrNacBtn_Click);
            // 
            // nomNacTxt
            // 
            this.nomNacTxt.Location = new System.Drawing.Point(53, 183);
            this.nomNacTxt.Name = "nomNacTxt";
            this.nomNacTxt.Size = new System.Drawing.Size(133, 20);
            this.nomNacTxt.TabIndex = 41;
            // 
            // nroNacTxt
            // 
            this.nroNacTxt.Location = new System.Drawing.Point(53, 133);
            this.nroNacTxt.Name = "nroNacTxt";
            this.nroNacTxt.Size = new System.Drawing.Size(88, 20);
            this.nroNacTxt.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nombre Nacionalidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "NroNacionalidad";
            // 
            // grillaNac
            // 
            this.grillaNac.AllowUserToAddRows = false;
            this.grillaNac.AllowUserToDeleteRows = false;
            this.grillaNac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNac.Location = new System.Drawing.Point(335, 97);
            this.grillaNac.Name = "grillaNac";
            this.grillaNac.ReadOnly = true;
            this.grillaNac.RowHeadersWidth = 51;
            this.grillaNac.RowTemplate.Height = 24;
            this.grillaNac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaNac.Size = new System.Drawing.Size(516, 320);
            this.grillaNac.TabIndex = 45;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 53;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // Nacionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 441);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.grillaNac);
            this.Controls.Add(this.elimNacBtn);
            this.Controls.Add(this.editNacBtn);
            this.Controls.Add(this.agrNacBtn);
            this.Controls.Add(this.nomNacTxt);
            this.Controls.Add(this.nroNacTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "Nacionalidad";
            this.Text = "Nacionalidad";
            this.Load += new System.EventHandler(this.Nacionalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaNac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button elimNacBtn;
        private System.Windows.Forms.Button editNacBtn;
        private System.Windows.Forms.Button agrNacBtn;
        private System.Windows.Forms.TextBox nomNacTxt;
        private System.Windows.Forms.TextBox nroNacTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grillaNac;
        private System.Windows.Forms.Button volverBtn;
    }
}