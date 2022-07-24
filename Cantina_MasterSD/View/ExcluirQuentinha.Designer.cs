namespace Cantina_MasterSD.Model
{
    partial class ExcluirQuentinha
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

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_quentinhas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.combo_quentinhas);
            this.groupBox1.Location = new System.Drawing.Point(14, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(406, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma quentinha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_quentinhas
            // 
            this.combo_quentinhas.FormattingEnabled = true;
            this.combo_quentinhas.Location = new System.Drawing.Point(8, 24);
            this.combo_quentinhas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_quentinhas.Name = "combo_quentinhas";
            this.combo_quentinhas.Size = new System.Drawing.Size(390, 23);
            this.combo_quentinhas.TabIndex = 0;
            this.combo_quentinhas.SelectedIndexChanged += new System.EventHandler(this.combo_quentinhas_SelectedIndexChanged);
            // 
            // ExcluirQuentinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 216);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExcluirQuentinha";
            this.Text = "Excluir Quentinha";
            this.Load += new System.EventHandler(this.ExcluirQuentinha_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_quentinhas;
    }
}