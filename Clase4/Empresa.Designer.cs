namespace Clase4
{
    partial class Empresa
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
            this.personaBtn = new System.Windows.Forms.Button();
            this.nacionalidadBtn = new System.Windows.Forms.Button();
            this.profesionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personaBtn
            // 
            this.personaBtn.Location = new System.Drawing.Point(183, 205);
            this.personaBtn.Name = "personaBtn";
            this.personaBtn.Size = new System.Drawing.Size(210, 52);
            this.personaBtn.TabIndex = 44;
            this.personaBtn.Text = "Persona";
            this.personaBtn.UseVisualStyleBackColor = true;
            this.personaBtn.Click += new System.EventHandler(this.personaBtn_Click);
            // 
            // nacionalidadBtn
            // 
            this.nacionalidadBtn.Location = new System.Drawing.Point(419, 205);
            this.nacionalidadBtn.Name = "nacionalidadBtn";
            this.nacionalidadBtn.Size = new System.Drawing.Size(210, 52);
            this.nacionalidadBtn.TabIndex = 45;
            this.nacionalidadBtn.Text = "Nacionalidad";
            this.nacionalidadBtn.UseVisualStyleBackColor = true;
            this.nacionalidadBtn.Click += new System.EventHandler(this.nacionalidadBtn_Click);
            // 
            // profesionBtn
            // 
            this.profesionBtn.Location = new System.Drawing.Point(655, 205);
            this.profesionBtn.Name = "profesionBtn";
            this.profesionBtn.Size = new System.Drawing.Size(210, 52);
            this.profesionBtn.TabIndex = 46;
            this.profesionBtn.Text = "Profesion";
            this.profesionBtn.UseVisualStyleBackColor = true;
            this.profesionBtn.Click += new System.EventHandler(this.profesionBtn_Click);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 462);
            this.Controls.Add(this.profesionBtn);
            this.Controls.Add(this.nacionalidadBtn);
            this.Controls.Add(this.personaBtn);
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personaBtn;
        private System.Windows.Forms.Button nacionalidadBtn;
        private System.Windows.Forms.Button profesionBtn;
    }
}