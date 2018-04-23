namespace Actividad.GraficosTortuga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubirPluma = new System.Windows.Forms.Button();
            this.btnBajarPluma = new System.Windows.Forms.Button();
            this.btnGirarADerecha = new System.Windows.Forms.Button();
            this.btnGirarAIzquierda = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPosiciones = new System.Windows.Forms.TextBox();
            this.txtBxTablero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtBxPosiciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSubirPluma);
            this.groupBox1.Controls.Add(this.btnBajarPluma);
            this.groupBox1.Controls.Add(this.btnGirarADerecha);
            this.groupBox1.Controls.Add(this.btnGirarAIzquierda);
            this.groupBox1.Controls.Add(this.btnAvanzar);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnFin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tareas";
            // 
            // btnSubirPluma
            // 
            this.btnSubirPluma.AutoSize = true;
            this.btnSubirPluma.Location = new System.Drawing.Point(6, 28);
            this.btnSubirPluma.Name = "btnSubirPluma";
            this.btnSubirPluma.Size = new System.Drawing.Size(122, 34);
            this.btnSubirPluma.TabIndex = 1;
            this.btnSubirPluma.Text = "Subir Pluma";
            this.btnSubirPluma.UseVisualStyleBackColor = true;
            // 
            // btnBajarPluma
            // 
            this.btnBajarPluma.AutoSize = true;
            this.btnBajarPluma.Location = new System.Drawing.Point(6, 68);
            this.btnBajarPluma.Name = "btnBajarPluma";
            this.btnBajarPluma.Size = new System.Drawing.Size(120, 34);
            this.btnBajarPluma.TabIndex = 2;
            this.btnBajarPluma.Text = "Bajar Pluma";
            this.btnBajarPluma.UseVisualStyleBackColor = true;
            // 
            // btnGirarADerecha
            // 
            this.btnGirarADerecha.AutoSize = true;
            this.btnGirarADerecha.Location = new System.Drawing.Point(173, 28);
            this.btnGirarADerecha.Name = "btnGirarADerecha";
            this.btnGirarADerecha.Size = new System.Drawing.Size(171, 34);
            this.btnGirarADerecha.TabIndex = 3;
            this.btnGirarADerecha.Text = "Girar a la Derecha";
            this.btnGirarADerecha.UseVisualStyleBackColor = true;
            // 
            // btnGirarAIzquierda
            // 
            this.btnGirarAIzquierda.AutoSize = true;
            this.btnGirarAIzquierda.Location = new System.Drawing.Point(168, 68);
            this.btnGirarAIzquierda.Name = "btnGirarAIzquierda";
            this.btnGirarAIzquierda.Size = new System.Drawing.Size(176, 34);
            this.btnGirarAIzquierda.TabIndex = 4;
            this.btnGirarAIzquierda.Text = "Girar a la Izquierda";
            this.btnGirarAIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.AutoSize = true;
            this.btnAvanzar.Location = new System.Drawing.Point(256, 108);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(88, 34);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Location = new System.Drawing.Point(6, 148);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(157, 34);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir Tablero";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnFin
            // 
            this.btnFin.AutoSize = true;
            this.btnFin.Location = new System.Drawing.Point(262, 148);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(82, 34);
            this.btnFin.TabIndex = 7;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Posiciones:";
            // 
            // txtBxPosiciones
            // 
            this.txtBxPosiciones.Location = new System.Drawing.Point(119, 110);
            this.txtBxPosiciones.Name = "txtBxPosiciones";
            this.txtBxPosiciones.Size = new System.Drawing.Size(126, 29);
            this.txtBxPosiciones.TabIndex = 9;
            // 
            // txtBxTablero
            // 
            this.txtBxTablero.Location = new System.Drawing.Point(40, 242);
            this.txtBxTablero.Multiline = true;
            this.txtBxTablero.Name = "txtBxTablero";
            this.txtBxTablero.Size = new System.Drawing.Size(296, 230);
            this.txtBxTablero.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 484);
            this.Controls.Add(this.txtBxTablero);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Graficos Por Tortuga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxPosiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubirPluma;
        private System.Windows.Forms.Button btnBajarPluma;
        private System.Windows.Forms.Button btnGirarADerecha;
        private System.Windows.Forms.Button btnGirarAIzquierda;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtBxTablero;
    }
}

