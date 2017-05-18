namespace Jogo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.amarelo = new System.Windows.Forms.PictureBox();
            this.verde = new System.Windows.Forms.PictureBox();
            this.vermelho = new System.Windows.Forms.PictureBox();
            this.azul = new System.Windows.Forms.PictureBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecomecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).BeginInit();
            this.SuspendLayout();
            // 
            // amarelo
            // 
            this.amarelo.Enabled = false;
            this.amarelo.Image = global::Jogo.Properties.Resources.amareloApagado;
            this.amarelo.Location = new System.Drawing.Point(465, 101);
            this.amarelo.Name = "amarelo";
            this.amarelo.Size = new System.Drawing.Size(159, 153);
            this.amarelo.TabIndex = 0;
            this.amarelo.TabStop = false;
            this.amarelo.Click += new System.EventHandler(this.amarelo_Click);
            // 
            // verde
            // 
            this.verde.Enabled = false;
            this.verde.Image = global::Jogo.Properties.Resources.VdApagado;
            this.verde.Location = new System.Drawing.Point(64, 101);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(159, 153);
            this.verde.TabIndex = 1;
            this.verde.TabStop = false;
            this.verde.Click += new System.EventHandler(this.verde_Click);
            // 
            // vermelho
            // 
            this.vermelho.Enabled = false;
            this.vermelho.Image = global::Jogo.Properties.Resources.VrmApagado;
            this.vermelho.Location = new System.Drawing.Point(264, 101);
            this.vermelho.Name = "vermelho";
            this.vermelho.Size = new System.Drawing.Size(159, 153);
            this.vermelho.TabIndex = 2;
            this.vermelho.TabStop = false;
            this.vermelho.Click += new System.EventHandler(this.vermelho_Click);
            // 
            // azul
            // 
            this.azul.Enabled = false;
            this.azul.Image = global::Jogo.Properties.Resources.AzulApagado;
            this.azul.Location = new System.Drawing.Point(660, 101);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(159, 153);
            this.azul.TabIndex = 3;
            this.azul.TabStop = false;
            this.azul.Click += new System.EventHandler(this.azul_Click);
            // 
            // btnComecar
            // 
            this.btnComecar.BackColor = System.Drawing.Color.White;
            this.btnComecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecar.ForeColor = System.Drawing.Color.Red;
            this.btnComecar.Location = new System.Drawing.Point(312, 339);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(273, 40);
            this.btnComecar.TabIndex = 5;
            this.btnComecar.Text = "Começar!";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nível: 1";
            // 
            // btnRecomecar
            // 
            this.btnRecomecar.BackColor = System.Drawing.Color.White;
            this.btnRecomecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomecar.ForeColor = System.Drawing.Color.Red;
            this.btnRecomecar.Location = new System.Drawing.Point(312, 339);
            this.btnRecomecar.Name = "btnRecomecar";
            this.btnRecomecar.Size = new System.Drawing.Size(273, 40);
            this.btnRecomecar.TabIndex = 7;
            this.btnRecomecar.Text = "Recomeçar.";
            this.btnRecomecar.UseVisualStyleBackColor = false;
            this.btnRecomecar.Visible = false;
            this.btnRecomecar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 437);
            this.Controls.Add(this.btnRecomecar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.azul);
            this.Controls.Add(this.vermelho);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.amarelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox amarelo;
        private System.Windows.Forms.PictureBox verde;
        private System.Windows.Forms.PictureBox vermelho;
        private System.Windows.Forms.PictureBox azul;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecomecar;
    }
}

