namespace carrera
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
            this.btnc = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(66, 210);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 37);
            this.btnc.TabIndex = 0;
            this.btnc.Text = "Iniciar";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.Btnc_Click);
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(211, 129);
            this.Player1.Multiline = true;
            this.Player1.Name = "Player1";
            this.Player1.ReadOnly = true;
            this.Player1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Player1.Size = new System.Drawing.Size(147, 303);
            this.Player1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carrera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Location = new System.Drawing.Point(66, 264);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(75, 37);
            this.BorrarBtn.TabIndex = 8;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(364, 129);
            this.Player2.Multiline = true;
            this.Player2.Name = "Player2";
            this.Player2.ReadOnly = true;
            this.Player2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Player2.Size = new System.Drawing.Size(147, 303);
            this.Player2.TabIndex = 9;
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(364, 103);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(147, 20);
            this.player2Name.TabIndex = 10;
            this.player2Name.Text = "Liebre";
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(211, 103);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(147, 20);
            this.player1Name.TabIndex = 11;
            this.player1Name.Text = "Tortuga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 444);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.btnc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player1Name;
    }
}

