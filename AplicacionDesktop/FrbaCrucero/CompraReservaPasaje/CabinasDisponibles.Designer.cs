﻿namespace FrbaCrucero.CompraReservaPasaje
{
    partial class CabinasDisponibles
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
            this.CabinasParaSeleccionar = new System.Windows.Forms.DataGridView();
            this.Cabinas = new System.Windows.Forms.GroupBox();
            this.SeleccionCabina = new System.Windows.Forms.Button();
            this.dataGridSeleccionadas = new System.Windows.Forms.DataGridView();
            this.Quitar = new System.Windows.Forms.Button();
            this.Selec = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CabinasParaSeleccionar)).BeginInit();
            this.Cabinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeleccionadas)).BeginInit();
            this.Selec.SuspendLayout();
            this.SuspendLayout();
            // 
            // CabinasParaSeleccionar
            // 
            this.CabinasParaSeleccionar.AllowDrop = true;
            this.CabinasParaSeleccionar.AllowUserToAddRows = false;
            this.CabinasParaSeleccionar.AllowUserToDeleteRows = false;
            this.CabinasParaSeleccionar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CabinasParaSeleccionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CabinasParaSeleccionar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CabinasParaSeleccionar.Location = new System.Drawing.Point(6, 19);
            this.CabinasParaSeleccionar.Name = "CabinasParaSeleccionar";
            this.CabinasParaSeleccionar.Size = new System.Drawing.Size(733, 201);
            this.CabinasParaSeleccionar.TabIndex = 0;
            this.CabinasParaSeleccionar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Cabinas
            // 
            this.Cabinas.Controls.Add(this.CabinasParaSeleccionar);
            this.Cabinas.Controls.Add(this.SeleccionCabina);
            this.Cabinas.Location = new System.Drawing.Point(22, 38);
            this.Cabinas.Name = "Cabinas";
            this.Cabinas.Size = new System.Drawing.Size(745, 254);
            this.Cabinas.TabIndex = 1;
            this.Cabinas.TabStop = false;
            this.Cabinas.Text = "Elija la/s Cabinas";
            this.Cabinas.Enter += new System.EventHandler(this.Cabinas_Enter);
            // 
            // SeleccionCabina
            // 
            this.SeleccionCabina.Location = new System.Drawing.Point(613, 226);
            this.SeleccionCabina.Name = "SeleccionCabina";
            this.SeleccionCabina.Size = new System.Drawing.Size(126, 23);
            this.SeleccionCabina.TabIndex = 2;
            this.SeleccionCabina.Text = "Agregar Cabina";
            this.SeleccionCabina.UseVisualStyleBackColor = true;
            this.SeleccionCabina.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridSeleccionadas
            // 
            this.dataGridSeleccionadas.AllowDrop = true;
            this.dataGridSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSeleccionadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridSeleccionadas.Location = new System.Drawing.Point(6, 19);
            this.dataGridSeleccionadas.Name = "dataGridSeleccionadas";
            this.dataGridSeleccionadas.Size = new System.Drawing.Size(733, 201);
            this.dataGridSeleccionadas.TabIndex = 3;
            this.dataGridSeleccionadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSeleccionadas_CellContentClick);
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(613, 229);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(126, 23);
            this.Quitar.TabIndex = 4;
            this.Quitar.Text = "Quitar Ultima Cabina";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Selec
            // 
            this.Selec.Controls.Add(this.dataGridSeleccionadas);
            this.Selec.Controls.Add(this.Quitar);
            this.Selec.Location = new System.Drawing.Point(22, 298);
            this.Selec.Name = "Selec";
            this.Selec.Size = new System.Drawing.Size(745, 258);
            this.Selec.TabIndex = 5;
            this.Selec.TabStop = false;
            this.Selec.Text = "Cabinas Seleccionadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione las cabinas deseadas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // CabinasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(809, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selec);
            this.Controls.Add(this.Cabinas);
            this.Name = "CabinasDisponibles";
            this.Text = "CabinasDisponibles";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CabinasDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CabinasParaSeleccionar)).EndInit();
            this.Cabinas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeleccionadas)).EndInit();
            this.Selec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CabinasParaSeleccionar;
        private System.Windows.Forms.GroupBox Cabinas;
        private System.Windows.Forms.Button SeleccionCabina;
        private System.Windows.Forms.DataGridView dataGridSeleccionadas;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.GroupBox Selec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}