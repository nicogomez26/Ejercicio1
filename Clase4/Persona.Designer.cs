namespace Clase4
{
    partial class Persona
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.nroPerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nacionalidadCmb = new System.Windows.Forms.ComboBox();
            this.profesionCmb = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.sexoCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cantPersonaTxt = new System.Windows.Forms.Label();
            this.promEdadTxt = new System.Windows.Forms.Label();
            this.edadMinTxt = new System.Windows.Forms.Label();
            this.edadMaxTxt = new System.Windows.Forms.Label();
            this.nacMaxTxt = new System.Windows.Forms.Label();
            this.nacMinTxt = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(97, 180);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(150, 20);
            this.apellidoTxt.TabIndex = 11;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(97, 131);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(150, 20);
            this.nombreTxt.TabIndex = 10;
            // 
            // nroPerTxt
            // 
            this.nroPerTxt.Location = new System.Drawing.Point(97, 78);
            this.nroPerTxt.Name = "nroPerTxt";
            this.nroPerTxt.Size = new System.Drawing.Size(150, 20);
            this.nroPerTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NroPersona";
            // 
            // edadTxt
            // 
            this.edadTxt.Location = new System.Drawing.Point(97, 227);
            this.edadTxt.Name = "edadTxt";
            this.edadTxt.Size = new System.Drawing.Size(62, 20);
            this.edadTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Profesion";
            // 
            // nacionalidadCmb
            // 
            this.nacionalidadCmb.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.nacionalidadCmb.FormattingEnabled = true;
            this.nacionalidadCmb.Location = new System.Drawing.Point(97, 313);
            this.nacionalidadCmb.Name = "nacionalidadCmb";
            this.nacionalidadCmb.Size = new System.Drawing.Size(121, 21);
            this.nacionalidadCmb.TabIndex = 17;
            // 
            // profesionCmb
            // 
            this.profesionCmb.FormattingEnabled = true;
            this.profesionCmb.Location = new System.Drawing.Point(97, 340);
            this.profesionCmb.Name = "profesionCmb";
            this.profesionCmb.Size = new System.Drawing.Size(121, 21);
            this.profesionCmb.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(61, 478);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 35);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(61, 436);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 35);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(61, 395);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 35);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(265, 78);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(781, 463);
            this.grilla.TabIndex = 22;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // sexoCmb
            // 
            this.sexoCmb.FormattingEnabled = true;
            this.sexoCmb.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.sexoCmb.Location = new System.Drawing.Point(97, 279);
            this.sexoCmb.Name = "sexoCmb";
            this.sexoCmb.Size = new System.Drawing.Size(121, 21);
            this.sexoCmb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cantidad Personas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 583);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Promedio Edad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 556);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Edad Min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Edad Max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(609, 556);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Nac Max";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(609, 583);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Nac Min";
            // 
            // cantPersonaTxt
            // 
            this.cantPersonaTxt.AutoSize = true;
            this.cantPersonaTxt.Location = new System.Drawing.Point(377, 556);
            this.cantPersonaTxt.Name = "cantPersonaTxt";
            this.cantPersonaTxt.Size = new System.Drawing.Size(13, 13);
            this.cantPersonaTxt.TabIndex = 45;
            this.cantPersonaTxt.Text = "0";
            // 
            // promEdadTxt
            // 
            this.promEdadTxt.AutoSize = true;
            this.promEdadTxt.Location = new System.Drawing.Point(377, 583);
            this.promEdadTxt.Name = "promEdadTxt";
            this.promEdadTxt.Size = new System.Drawing.Size(22, 13);
            this.promEdadTxt.TabIndex = 46;
            this.promEdadTxt.Text = "0.0";
            // 
            // edadMinTxt
            // 
            this.edadMinTxt.AutoSize = true;
            this.edadMinTxt.Location = new System.Drawing.Point(549, 556);
            this.edadMinTxt.Name = "edadMinTxt";
            this.edadMinTxt.Size = new System.Drawing.Size(13, 13);
            this.edadMinTxt.TabIndex = 47;
            this.edadMinTxt.Text = "0";
            // 
            // edadMaxTxt
            // 
            this.edadMaxTxt.AutoSize = true;
            this.edadMaxTxt.Location = new System.Drawing.Point(549, 583);
            this.edadMaxTxt.Name = "edadMaxTxt";
            this.edadMaxTxt.Size = new System.Drawing.Size(13, 13);
            this.edadMaxTxt.TabIndex = 48;
            this.edadMaxTxt.Text = "0";
            // 
            // nacMaxTxt
            // 
            this.nacMaxTxt.AutoSize = true;
            this.nacMaxTxt.Location = new System.Drawing.Point(694, 556);
            this.nacMaxTxt.Name = "nacMaxTxt";
            this.nacMaxTxt.Size = new System.Drawing.Size(13, 13);
            this.nacMaxTxt.TabIndex = 49;
            this.nacMaxTxt.Text = "0";
            // 
            // nacMinTxt
            // 
            this.nacMinTxt.AutoSize = true;
            this.nacMinTxt.Location = new System.Drawing.Point(694, 583);
            this.nacMinTxt.Name = "nacMinTxt";
            this.nacMinTxt.Size = new System.Drawing.Size(13, 13);
            this.nacMinTxt.TabIndex = 50;
            this.nacMinTxt.Text = "0";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 51;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 676);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.nacMinTxt);
            this.Controls.Add(this.nacMaxTxt);
            this.Controls.Add(this.edadMaxTxt);
            this.Controls.Add(this.edadMinTxt);
            this.Controls.Add(this.promEdadTxt);
            this.Controls.Add(this.cantPersonaTxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sexoCmb);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.profesionCmb);
            this.Controls.Add(this.nacionalidadCmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.nroPerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Persona";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox nroPerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox nacionalidadCmb;
        private System.Windows.Forms.ComboBox profesionCmb;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.ComboBox sexoCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label cantPersonaTxt;
        private System.Windows.Forms.Label promEdadTxt;
        private System.Windows.Forms.Label edadMinTxt;
        private System.Windows.Forms.Label edadMaxTxt;
        private System.Windows.Forms.Label nacMaxTxt;
        private System.Windows.Forms.Label nacMinTxt;
        private System.Windows.Forms.Button volverBtn;
    }
}

