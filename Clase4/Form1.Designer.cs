namespace Clase4
{
    partial class Form1
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
            this.nomNacTxt = new System.Windows.Forms.TextBox();
            this.nroNacTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.agrNacBtn = new System.Windows.Forms.Button();
            this.agrProBtn = new System.Windows.Forms.Button();
            this.nomProTxt = new System.Windows.Forms.TextBox();
            this.nroProTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.editNacBtn = new System.Windows.Forms.Button();
            this.editProBtn = new System.Windows.Forms.Button();
            this.elimNacBtn = new System.Windows.Forms.Button();
            this.elimProBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(115, 175);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(150, 20);
            this.apellidoTxt.TabIndex = 11;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(115, 126);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(150, 20);
            this.nombreTxt.TabIndex = 10;
            // 
            // nroPerTxt
            // 
            this.nroPerTxt.Location = new System.Drawing.Point(115, 73);
            this.nroPerTxt.Name = "nroPerTxt";
            this.nroPerTxt.Size = new System.Drawing.Size(150, 20);
            this.nroPerTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NroPersona";
            // 
            // edadTxt
            // 
            this.edadTxt.Location = new System.Drawing.Point(115, 222);
            this.edadTxt.Name = "edadTxt";
            this.edadTxt.Size = new System.Drawing.Size(62, 20);
            this.edadTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Profesion";
            // 
            // nacionalidadCmb
            // 
            this.nacionalidadCmb.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.nacionalidadCmb.FormattingEnabled = true;
            this.nacionalidadCmb.Location = new System.Drawing.Point(115, 308);
            this.nacionalidadCmb.Name = "nacionalidadCmb";
            this.nacionalidadCmb.Size = new System.Drawing.Size(121, 21);
            this.nacionalidadCmb.TabIndex = 17;
            // 
            // profesionCmb
            // 
            this.profesionCmb.FormattingEnabled = true;
            this.profesionCmb.Location = new System.Drawing.Point(115, 335);
            this.profesionCmb.Name = "profesionCmb";
            this.profesionCmb.Size = new System.Drawing.Size(121, 21);
            this.profesionCmb.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(43, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 29);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(43, 411);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 36);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 31);
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
            this.grilla.Location = new System.Drawing.Point(283, 73);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(781, 463);
            this.grilla.TabIndex = 22;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // sexoCmb
            // 
            this.sexoCmb.FormattingEnabled = true;
            this.sexoCmb.Location = new System.Drawing.Point(115, 274);
            this.sexoCmb.Name = "sexoCmb";
            this.sexoCmb.Size = new System.Drawing.Size(121, 21);
            this.sexoCmb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sexo";
            // 
            // nomNacTxt
            // 
            this.nomNacTxt.Location = new System.Drawing.Point(1129, 152);
            this.nomNacTxt.Name = "nomNacTxt";
            this.nomNacTxt.Size = new System.Drawing.Size(133, 20);
            this.nomNacTxt.TabIndex = 28;
            // 
            // nroNacTxt
            // 
            this.nroNacTxt.Location = new System.Drawing.Point(1129, 102);
            this.nroNacTxt.Name = "nroNacTxt";
            this.nroNacTxt.Size = new System.Drawing.Size(88, 20);
            this.nroNacTxt.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1126, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nombre Nacionalidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1126, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "NroNacionalidad";
            // 
            // agrNacBtn
            // 
            this.agrNacBtn.Location = new System.Drawing.Point(1129, 190);
            this.agrNacBtn.Name = "agrNacBtn";
            this.agrNacBtn.Size = new System.Drawing.Size(180, 37);
            this.agrNacBtn.TabIndex = 29;
            this.agrNacBtn.Text = "Agregar";
            this.agrNacBtn.UseVisualStyleBackColor = true;
            this.agrNacBtn.Click += new System.EventHandler(this.agrNacBtn_Click);
            // 
            // agrProBtn
            // 
            this.agrProBtn.Location = new System.Drawing.Point(1335, 187);
            this.agrProBtn.Name = "agrProBtn";
            this.agrProBtn.Size = new System.Drawing.Size(180, 37);
            this.agrProBtn.TabIndex = 34;
            this.agrProBtn.Text = "Agregar";
            this.agrProBtn.UseVisualStyleBackColor = true;
            // 
            // nomProTxt
            // 
            this.nomProTxt.Location = new System.Drawing.Point(1335, 149);
            this.nomProTxt.Name = "nomProTxt";
            this.nomProTxt.Size = new System.Drawing.Size(133, 20);
            this.nomProTxt.TabIndex = 33;
            // 
            // nroProTxt
            // 
            this.nroProTxt.Location = new System.Drawing.Point(1335, 99);
            this.nroProTxt.Name = "nroProTxt";
            this.nroProTxt.Size = new System.Drawing.Size(88, 20);
            this.nroProTxt.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1332, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nombre Profesion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1332, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "NroProfesion";
            // 
            // editNacBtn
            // 
            this.editNacBtn.Location = new System.Drawing.Point(1129, 233);
            this.editNacBtn.Name = "editNacBtn";
            this.editNacBtn.Size = new System.Drawing.Size(180, 36);
            this.editNacBtn.TabIndex = 35;
            this.editNacBtn.Text = "Editar";
            this.editNacBtn.UseVisualStyleBackColor = true;
            this.editNacBtn.Click += new System.EventHandler(this.editNacBtn_Click);
            // 
            // editProBtn
            // 
            this.editProBtn.Location = new System.Drawing.Point(1335, 233);
            this.editProBtn.Name = "editProBtn";
            this.editProBtn.Size = new System.Drawing.Size(180, 36);
            this.editProBtn.TabIndex = 36;
            this.editProBtn.Text = "Editar";
            this.editProBtn.UseVisualStyleBackColor = true;
            // 
            // elimNacBtn
            // 
            this.elimNacBtn.Location = new System.Drawing.Point(1129, 277);
            this.elimNacBtn.Name = "elimNacBtn";
            this.elimNacBtn.Size = new System.Drawing.Size(180, 29);
            this.elimNacBtn.TabIndex = 37;
            this.elimNacBtn.Text = "Eliminar";
            this.elimNacBtn.UseVisualStyleBackColor = true;
            // 
            // elimProBtn
            // 
            this.elimProBtn.Location = new System.Drawing.Point(1335, 277);
            this.elimProBtn.Name = "elimProBtn";
            this.elimProBtn.Size = new System.Drawing.Size(180, 29);
            this.elimProBtn.TabIndex = 38;
            this.elimProBtn.Text = "Eliminar";
            this.elimProBtn.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cantidad Personas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Promedio Edad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 605);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Edad Min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 632);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Edad Max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(627, 551);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Nac Max";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(627, 578);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Nac Min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 706);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.elimProBtn);
            this.Controls.Add(this.elimNacBtn);
            this.Controls.Add(this.editProBtn);
            this.Controls.Add(this.editNacBtn);
            this.Controls.Add(this.agrProBtn);
            this.Controls.Add(this.nomProTxt);
            this.Controls.Add(this.nroProTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.agrNacBtn);
            this.Controls.Add(this.nomNacTxt);
            this.Controls.Add(this.nroNacTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox nomNacTxt;
        private System.Windows.Forms.TextBox nroNacTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button agrNacBtn;
        private System.Windows.Forms.Button agrProBtn;
        private System.Windows.Forms.TextBox nomProTxt;
        private System.Windows.Forms.TextBox nroProTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button editNacBtn;
        private System.Windows.Forms.Button editProBtn;
        private System.Windows.Forms.Button elimNacBtn;
        private System.Windows.Forms.Button elimProBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

