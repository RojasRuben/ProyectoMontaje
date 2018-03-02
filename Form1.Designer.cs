namespace PlancharExcel
{
    partial class frmPlanchar
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
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.labelExaminar = new System.Windows.Forms.Label();
            this.dataGridViewValidar = new System.Windows.Forms.DataGridView();
            this.labelComentario = new System.Windows.Forms.Label();
            this.comboBoxSeleccionaArchivos = new System.Windows.Forms.ComboBox();
            this.labelTextoSeleccionaSubirArchivos = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.pictureBoxLogoSteelgo = new System.Windows.Forms.PictureBox();
            this.buttonGuardarActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSteelgo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point(431, 144);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(120, 23);
            this.buttonExaminar.TabIndex = 0;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // labelExaminar
            // 
            this.labelExaminar.AutoSize = true;
            this.labelExaminar.Location = new System.Drawing.Point(13, 144);
            this.labelExaminar.Name = "labelExaminar";
            this.labelExaminar.Size = new System.Drawing.Size(9, 13);
            this.labelExaminar.TabIndex = 1;
            this.labelExaminar.Text = "\'";
            // 
            // dataGridViewValidar
            // 
            this.dataGridViewValidar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValidar.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewValidar.Name = "dataGridViewValidar";
            this.dataGridViewValidar.Size = new System.Drawing.Size(551, 220);
            this.dataGridViewValidar.TabIndex = 2;
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(13, 118);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(156, 13);
            this.labelComentario.TabIndex = 3;
            this.labelComentario.Text = "Selecciona un archivo de excel";
            // 
            // comboBoxSeleccionaArchivos
            // 
            this.comboBoxSeleccionaArchivos.DisplayMember = "Nombre";
            this.comboBoxSeleccionaArchivos.FormattingEnabled = true;
            this.comboBoxSeleccionaArchivos.Location = new System.Drawing.Point(16, 55);
            this.comboBoxSeleccionaArchivos.Name = "comboBoxSeleccionaArchivos";
            this.comboBoxSeleccionaArchivos.Size = new System.Drawing.Size(153, 21);
            this.comboBoxSeleccionaArchivos.TabIndex = 4;
            this.comboBoxSeleccionaArchivos.ValueMember = "ID";
            this.comboBoxSeleccionaArchivos.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeleccionaArchivos_SelectedIndexChanged);
            // 
            // labelTextoSeleccionaSubirArchivos
            // 
            this.labelTextoSeleccionaSubirArchivos.AutoSize = true;
            this.labelTextoSeleccionaSubirArchivos.Location = new System.Drawing.Point(13, 19);
            this.labelTextoSeleccionaSubirArchivos.Name = "labelTextoSeleccionaSubirArchivos";
            this.labelTextoSeleccionaSubirArchivos.Size = new System.Drawing.Size(147, 13);
            this.labelTextoSeleccionaSubirArchivos.TabIndex = 5;
            this.labelTextoSeleccionaSubirArchivos.Text = "Selecciona un archivo a subir";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(431, 174);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(120, 23);
            this.buttonCargar.TabIndex = 6;
            this.buttonCargar.Text = "Validar Informacion";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // pictureBoxLogoSteelgo
            // 
            this.pictureBoxLogoSteelgo.Image = global::PlancharExcel.Properties.Resources.logo;
            this.pictureBoxLogoSteelgo.Location = new System.Drawing.Point(334, 19);
            this.pictureBoxLogoSteelgo.Name = "pictureBoxLogoSteelgo";
            this.pictureBoxLogoSteelgo.Size = new System.Drawing.Size(217, 57);
            this.pictureBoxLogoSteelgo.TabIndex = 7;
            this.pictureBoxLogoSteelgo.TabStop = false;
            // 
            // buttonGuardarActualizar
            // 
            this.buttonGuardarActualizar.Location = new System.Drawing.Point(431, 450);
            this.buttonGuardarActualizar.Name = "buttonGuardarActualizar";
            this.buttonGuardarActualizar.Size = new System.Drawing.Size(132, 23);
            this.buttonGuardarActualizar.TabIndex = 8;
            this.buttonGuardarActualizar.Text = "Planchar Informacion";
            this.buttonGuardarActualizar.UseVisualStyleBackColor = true;
            this.buttonGuardarActualizar.Click += new System.EventHandler(this.buttonGuardarActualizar_Click);
            // 
            // frmPlanchar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 505);
            this.Controls.Add(this.buttonGuardarActualizar);
            this.Controls.Add(this.pictureBoxLogoSteelgo);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.labelTextoSeleccionaSubirArchivos);
            this.Controls.Add(this.comboBoxSeleccionaArchivos);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.dataGridViewValidar);
            this.Controls.Add(this.labelExaminar);
            this.Controls.Add(this.buttonExaminar);
            this.Name = "frmPlanchar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPlanchar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSteelgo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.Label labelExaminar;
        private System.Windows.Forms.DataGridView dataGridViewValidar;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.ComboBox comboBoxSeleccionaArchivos;
        private System.Windows.Forms.Label labelTextoSeleccionaSubirArchivos;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.PictureBox pictureBoxLogoSteelgo;
        private System.Windows.Forms.Button buttonGuardarActualizar;
    }
}

