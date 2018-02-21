namespace Series_y_ciclos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnLn = new System.Windows.Forms.Button();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(67, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 1;
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(67, 129);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(63, 34);
            this.btnLn.TabIndex = 2;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(264, 55);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(100, 26);
            this.txtRep.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repeticiones:";
            // 
            // btnSen
            // 
            this.btnSen.Location = new System.Drawing.Point(185, 129);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(63, 34);
            this.btnSen.TabIndex = 5;
            this.btnSen.Text = "Sen";
            this.btnSen.UseVisualStyleBackColor = true;
            this.btnSen.Click += new System.EventHandler(this.btnSen_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(303, 129);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(63, 34);
            this.btnCos.TabIndex = 6;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(118, 220);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(183, 26);
            this.txtResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSen);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Series y ciclos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

