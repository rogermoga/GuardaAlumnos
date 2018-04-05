namespace Vueling.Presentation.WinSite
{
    partial class AlumnoForm
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
            this.btnJson = new System.Windows.Forms.Button();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.upId = new System.Windows.Forms.NumericUpDown();
            this.dpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.upId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(288, 243);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(75, 23);
            this.btnJson.TabIndex = 0;
            this.btnJson.Text = "Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(144, 243);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(75, 23);
            this.btnTxt.TabIndex = 1;
            this.btnTxt.Text = "Txt";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(445, 243);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 2;
            this.btnXml.Text = "Xml";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(339, 75);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 4;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(339, 126);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(100, 20);
            this.textApellidos.TabIndex = 5;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(214, 34);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(214, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(214, 133);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 8;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(214, 171);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "Dni";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(214, 201);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(90, 13);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "FechaNacimiento";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(339, 164);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(100, 20);
            this.textDni.TabIndex = 11;
            // 
            // upId
            // 
            this.upId.Location = new System.Drawing.Point(339, 34);
            this.upId.Name = "upId";
            this.upId.Size = new System.Drawing.Size(40, 20);
            this.upId.TabIndex = 13;
            // 
            // dpFechaNacimiento
            // 
            this.dpFechaNacimiento.Location = new System.Drawing.Point(339, 193);
            this.dpFechaNacimiento.Name = "dpFechaNacimiento";
            this.dpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dpFechaNacimiento.TabIndex = 14;
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dpFechaNacimiento);
            this.Controls.Add(this.upId);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.btnJson);
            this.Name = "AlumnoForm";
            this.Text = "AlumnoForm";
            ((System.ComponentModel.ISupportInitialize)(this.upId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.NumericUpDown upId;
        private System.Windows.Forms.DateTimePicker dpFechaNacimiento;
    }
}