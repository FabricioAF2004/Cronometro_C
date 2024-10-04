namespace Cronometro
{
    partial class Form1
    {
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
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            btnParar = new Button();
            btnResetar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(12, 249);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(190, 74);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar:";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += button1_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(433, 249);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(190, 74);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar:";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += button2_Click;
            // 
            // btnResetar
            // 
            btnResetar.Location = new Point(850, 249);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(190, 74);
            btnResetar.TabIndex = 3;
            btnResetar.Text = "Resetar:";
            btnResetar.UseVisualStyleBackColor = true;
            btnResetar.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(875, 191);
            label1.TabIndex = 4;
            label1.Text = "00:00:00.000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(label1);
            Controls.Add(btnResetar);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciar;
        private Button btnParar;
        private Button btnResetar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
