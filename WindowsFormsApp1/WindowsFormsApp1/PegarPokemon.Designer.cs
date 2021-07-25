
namespace WindowsFormsApp1
{
    partial class PegarPokemon
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Moverato = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.move4 = new System.Windows.Forms.CheckBox();
            this.move3 = new System.Windows.Forms.CheckBox();
            this.move2 = new System.Windows.Forms.CheckBox();
            this.move1 = new System.Windows.Forms.CheckBox();
            this.fugir = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mudarpoke = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Moverato
            // 
            this.Moverato.Location = new System.Drawing.Point(12, 212);
            this.Moverato.Name = "Moverato";
            this.Moverato.Size = new System.Drawing.Size(146, 35);
            this.Moverato.TabIndex = 0;
            this.Moverato.Text = "Caçar pokemon";
            this.Moverato.UseVisualStyleBackColor = true;
            this.Moverato.Click += new System.EventHandler(this.Moverato_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Só lateral";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // move4
            // 
            this.move4.AutoSize = true;
            this.move4.Location = new System.Drawing.Point(12, 120);
            this.move4.Name = "move4";
            this.move4.Size = new System.Drawing.Size(72, 21);
            this.move4.TabIndex = 2;
            this.move4.Text = "Move4";
            this.move4.UseVisualStyleBackColor = true;
            // 
            // move3
            // 
            this.move3.AutoSize = true;
            this.move3.Location = new System.Drawing.Point(12, 93);
            this.move3.Name = "move3";
            this.move3.Size = new System.Drawing.Size(72, 21);
            this.move3.TabIndex = 3;
            this.move3.Text = "Move3";
            this.move3.UseVisualStyleBackColor = true;
            // 
            // move2
            // 
            this.move2.AutoSize = true;
            this.move2.Location = new System.Drawing.Point(12, 66);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(72, 21);
            this.move2.TabIndex = 4;
            this.move2.Text = "Move2";
            this.move2.UseVisualStyleBackColor = true;
            // 
            // move1
            // 
            this.move1.AutoSize = true;
            this.move1.Location = new System.Drawing.Point(12, 39);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(72, 21);
            this.move1.TabIndex = 5;
            this.move1.Text = "Move1";
            this.move1.UseVisualStyleBackColor = true;
            // 
            // fugir
            // 
            this.fugir.AutoSize = true;
            this.fugir.Location = new System.Drawing.Point(12, 150);
            this.fugir.Name = "fugir";
            this.fugir.Size = new System.Drawing.Size(115, 21);
            this.fugir.TabIndex = 6;
            this.fugir.Text = "Fugir Sempre";
            this.fugir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 235);
            this.button1.TabIndex = 7;
            this.button1.Text = "Battlefrontiend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mudarpoke
            // 
            this.mudarpoke.AutoSize = true;
            this.mudarpoke.Location = new System.Drawing.Point(12, 177);
            this.mudarpoke.Name = "mudarpoke";
            this.mudarpoke.Size = new System.Drawing.Size(141, 21);
            this.mudarpoke.TabIndex = 8;
            this.mudarpoke.Text = "Change pokemon";
            this.mudarpoke.UseVisualStyleBackColor = true;
            // 
            // PegarPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 259);
            this.Controls.Add(this.mudarpoke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fugir);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.move2);
            this.Controls.Add(this.move3);
            this.Controls.Add(this.move4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Moverato);
            this.Name = "PegarPokemon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Moverato;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox move4;
        private System.Windows.Forms.CheckBox move3;
        private System.Windows.Forms.CheckBox move2;
        private System.Windows.Forms.CheckBox move1;
        private System.Windows.Forms.CheckBox fugir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox mudarpoke;
    }
}

