namespace ControlEvents {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.dtp_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmb_Provincia = new System.Windows.Forms.ComboBox();
            this.cmb_Region = new System.Windows.Forms.ComboBox();
            this.lbl_Provincia = new System.Windows.Forms.Label();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_Nacimiento = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_RepetirClave = new System.Windows.Forms.TextBox();
            this.lbl_RepetirClave = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.dtp_Nacimiento);
            this.tabPage1.Controls.Add(this.cmb_Provincia);
            this.tabPage1.Controls.Add(this.cmb_Region);
            this.tabPage1.Controls.Add(this.lbl_Provincia);
            this.tabPage1.Controls.Add(this.lbl_Region);
            this.tabPage1.Controls.Add(this.lbl_Nacimiento);
            this.tabPage1.Controls.Add(this.txt_Nombres);
            this.tabPage1.Controls.Add(this.txt_Apellidos);
            this.tabPage1.Controls.Add(this.txt_Cedula);
            this.tabPage1.Controls.Add(this.lbl_Nombres);
            this.tabPage1.Controls.Add(this.lbl_Apellidos);
            this.tabPage1.Controls.Add(this.lbl_Cedula);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 34);
            this.button6.TabIndex = 24;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dtp_Nacimiento
            // 
            this.dtp_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Nacimiento.Location = new System.Drawing.Point(549, 69);
            this.dtp_Nacimiento.MaxDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtp_Nacimiento.MinDate = new System.DateTime(1973, 1, 1, 0, 0, 0, 0);
            this.dtp_Nacimiento.Name = "dtp_Nacimiento";
            this.dtp_Nacimiento.Size = new System.Drawing.Size(182, 31);
            this.dtp_Nacimiento.TabIndex = 23;
            this.dtp_Nacimiento.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // cmb_Provincia
            // 
            this.cmb_Provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_Provincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Provincia.FormattingEnabled = true;
            this.cmb_Provincia.Location = new System.Drawing.Point(549, 216);
            this.cmb_Provincia.Name = "cmb_Provincia";
            this.cmb_Provincia.Size = new System.Drawing.Size(182, 33);
            this.cmb_Provincia.TabIndex = 22;
            // 
            // cmb_Region
            // 
            this.cmb_Region.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_Region.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Region.FormattingEnabled = true;
            this.cmb_Region.Items.AddRange(new object[] {
            "Costa",
            "Sierra",
            "Oriente"});
            this.cmb_Region.Location = new System.Drawing.Point(549, 142);
            this.cmb_Region.Name = "cmb_Region";
            this.cmb_Region.Size = new System.Drawing.Size(182, 33);
            this.cmb_Region.TabIndex = 21;
            this.cmb_Region.SelectedIndexChanged += new System.EventHandler(this.cmb_Region_SelectedIndexChanged);
            // 
            // lbl_Provincia
            // 
            this.lbl_Provincia.AutoSize = true;
            this.lbl_Provincia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Provincia.Location = new System.Drawing.Point(447, 216);
            this.lbl_Provincia.Name = "lbl_Provincia";
            this.lbl_Provincia.Size = new System.Drawing.Size(96, 28);
            this.lbl_Provincia.TabIndex = 20;
            this.lbl_Provincia.Text = "Provincia:";
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Region.Location = new System.Drawing.Point(466, 142);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(77, 28);
            this.lbl_Region.TabIndex = 19;
            this.lbl_Region.Text = "Region:";
            // 
            // lbl_Nacimiento
            // 
            this.lbl_Nacimiento.AutoSize = true;
            this.lbl_Nacimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nacimiento.Location = new System.Drawing.Point(435, 69);
            this.lbl_Nacimiento.Name = "lbl_Nacimiento";
            this.lbl_Nacimiento.Size = new System.Drawing.Size(108, 28);
            this.lbl_Nacimiento.TabIndex = 18;
            this.lbl_Nacimiento.Text = "Fecha/Nac:";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(141, 216);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(150, 31);
            this.txt_Nombres.TabIndex = 17;
            this.txt_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombres_KeyPress);
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(141, 139);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(150, 31);
            this.txt_Apellidos.TabIndex = 16;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(141, 71);
            this.txt_Cedula.MaxLength = 10;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(150, 31);
            this.txt_Cedula.TabIndex = 15;
            this.txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress);
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombres.Location = new System.Drawing.Point(38, 216);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(97, 28);
            this.lbl_Nombres.TabIndex = 14;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellidos.Location = new System.Drawing.Point(37, 142);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(98, 28);
            this.lbl_Apellidos.TabIndex = 13;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cedula.Location = new System.Drawing.Point(59, 71);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(76, 28);
            this.lbl_Cedula.TabIndex = 12;
            this.lbl_Cedula.Text = "Cedula:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_RepetirClave);
            this.tabPage2.Controls.Add(this.lbl_RepetirClave);
            this.tabPage2.Controls.Add(this.txt_Clave);
            this.tabPage2.Controls.Add(this.lbl_Clave);
            this.tabPage2.Controls.Add(this.txt_Usuario);
            this.tabPage2.Controls.Add(this.lbl_Usuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credenciales de Acceso";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_RepetirClave
            // 
            this.txt_RepetirClave.Location = new System.Drawing.Point(328, 199);
            this.txt_RepetirClave.Name = "txt_RepetirClave";
            this.txt_RepetirClave.Size = new System.Drawing.Size(150, 31);
            this.txt_RepetirClave.TabIndex = 21;
            this.txt_RepetirClave.UseSystemPasswordChar = true;
            // 
            // lbl_RepetirClave
            // 
            this.lbl_RepetirClave.AutoSize = true;
            this.lbl_RepetirClave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_RepetirClave.Location = new System.Drawing.Point(192, 199);
            this.lbl_RepetirClave.Name = "lbl_RepetirClave";
            this.lbl_RepetirClave.Size = new System.Drawing.Size(130, 28);
            this.lbl_RepetirClave.TabIndex = 20;
            this.lbl_RepetirClave.Text = "Repetir Clave:";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(328, 135);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(150, 31);
            this.txt_Clave.TabIndex = 19;
            this.txt_Clave.UseSystemPasswordChar = true;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Clave.Location = new System.Drawing.Point(259, 135);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(63, 28);
            this.lbl_Clave.TabIndex = 18;
            this.lbl_Clave.Text = "Clave:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(328, 76);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(150, 31);
            this.txt_Usuario.TabIndex = 17;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.Location = new System.Drawing.Point(239, 76);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(83, 28);
            this.lbl_Usuario.TabIndex = 16;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(12, 393);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(112, 34);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(176, 393);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 34);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(344, 393);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 34);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(511, 393);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 34);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(672, 393);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button6;
        private DateTimePicker dtp_Nacimiento;
        private ComboBox cmb_Provincia;
        private ComboBox cmb_Region;
        private Label lbl_Provincia;
        private Label lbl_Region;
        private Label lbl_Nacimiento;
        private TextBox txt_Nombres;
        private TextBox txt_Apellidos;
        private TextBox txt_Cedula;
        private Label lbl_Nombres;
        private Label lbl_Apellidos;
        private Label lbl_Cedula;
        private TabPage tabPage2;
        private Button btn_Nuevo;
        private Button btn_Guardar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private Button btn_Cancelar;
        private TextBox txt_RepetirClave;
        private Label lbl_RepetirClave;
        private TextBox txt_Clave;
        private Label lbl_Clave;
        private TextBox txt_Usuario;
        private Label lbl_Usuario;
    }
}