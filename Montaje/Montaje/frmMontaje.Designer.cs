namespace Montaje
{
    partial class frmMontaje
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
            this.comboBoxSeleccionaArchivos = new System.Windows.Forms.ComboBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonGuardarActualizar = new System.Windows.Forms.Button();
            this.dataGridViewValidar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point(343, 58);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 0;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click_1);
            // 
            // labelExaminar
            // 
            this.labelExaminar.AutoSize = true;
            this.labelExaminar.Location = new System.Drawing.Point(8, 58);
            this.labelExaminar.Name = "labelExaminar";
            this.labelExaminar.Size = new System.Drawing.Size(10, 13);
            this.labelExaminar.TabIndex = 1;
            this.labelExaminar.Text = "-";
            // 
            // comboBoxSeleccionaArchivos
            // 
            this.comboBoxSeleccionaArchivos.DisplayMember = "Nombre";
            this.comboBoxSeleccionaArchivos.FormattingEnabled = true;
            this.comboBoxSeleccionaArchivos.Location = new System.Drawing.Point(11, 22);
            this.comboBoxSeleccionaArchivos.Name = "comboBoxSeleccionaArchivos";
            this.comboBoxSeleccionaArchivos.Size = new System.Drawing.Size(170, 21);
            this.comboBoxSeleccionaArchivos.TabIndex = 2;
            this.comboBoxSeleccionaArchivos.ValueMember = "ID";
            this.comboBoxSeleccionaArchivos.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeleccionaArchivos_SelectedIndexChanged_1);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(343, 88);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "Validar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click_1);
            // 
            // buttonGuardarActualizar
            // 
            this.buttonGuardarActualizar.Location = new System.Drawing.Point(343, 284);
            this.buttonGuardarActualizar.Name = "buttonGuardarActualizar";
            this.buttonGuardarActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarActualizar.TabIndex = 4;
            this.buttonGuardarActualizar.Text = "Guardar";
            this.buttonGuardarActualizar.UseVisualStyleBackColor = true;
            this.buttonGuardarActualizar.Click += new System.EventHandler(this.buttonGuardarActualizar_Click_1);
            // 
            // dataGridViewValidar
            // 
            this.dataGridViewValidar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValidar.Location = new System.Drawing.Point(11, 128);
            this.dataGridViewValidar.Name = "dataGridViewValidar";
            this.dataGridViewValidar.Size = new System.Drawing.Size(407, 150);
            this.dataGridViewValidar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona un archivo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Montaje.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(200, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmMontaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewValidar);
            this.Controls.Add(this.buttonGuardarActualizar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.comboBoxSeleccionaArchivos);
            this.Controls.Add(this.labelExaminar);
            this.Controls.Add(this.buttonExaminar);
            this.MaximizeBox = false;
            this.Name = "frmMontaje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Montaje";
            this.Load += new System.EventHandler(this.frmMontaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.Label labelExaminar;
        private System.Windows.Forms.ComboBox comboBoxSeleccionaArchivos;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonGuardarActualizar;
        private System.Windows.Forms.DataGridView dataGridViewValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}