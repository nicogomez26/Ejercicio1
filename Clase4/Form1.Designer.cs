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
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(182, 173);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(150, 20);
            this.apellidoTxt.TabIndex = 11;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(182, 124);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(150, 20);
            this.nombreTxt.TabIndex = 10;
            // 
            // nroPerTxt
            // 
            this.nroPerTxt.Location = new System.Drawing.Point(182, 71);
            this.nroPerTxt.Name = "nroPerTxt";
            this.nroPerTxt.Size = new System.Drawing.Size(150, 20);
            this.nroPerTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NroPersona";
            // 
            // edadTxt
            // 
            this.edadTxt.Location = new System.Drawing.Point(182, 220);
            this.edadTxt.Name = "edadTxt";
            this.edadTxt.Size = new System.Drawing.Size(62, 20);
            this.edadTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Profesion";
            // 
            // nacionalidadCmb
            // 
            this.nacionalidadCmb.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.nacionalidadCmb.FormattingEnabled = true;
            this.nacionalidadCmb.Location = new System.Drawing.Point(182, 306);
            this.nacionalidadCmb.Name = "nacionalidadCmb";
            this.nacionalidadCmb.Size = new System.Drawing.Size(121, 21);
            this.nacionalidadCmb.TabIndex = 17;
            // 
            // profesionCmb
            // 
            this.profesionCmb.FormattingEnabled = true;
            this.profesionCmb.Location = new System.Drawing.Point(182, 333);
            this.profesionCmb.Name = "profesionCmb";
            this.profesionCmb.Size = new System.Drawing.Size(121, 21);
            this.profesionCmb.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(110, 451);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 29);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(110, 409);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 36);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 372);
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
            this.grilla.Location = new System.Drawing.Point(362, 71);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(848, 442);
            this.grilla.TabIndex = 22;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // sexoCmb
            // 
            this.sexoCmb.FormattingEnabled = true;
            this.sexoCmb.Location = new System.Drawing.Point(182, 272);
            this.sexoCmb.Name = "sexoCmb";
            this.sexoCmb.Size = new System.Drawing.Size(121, 21);
            this.sexoCmb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 680);
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
    }
}

