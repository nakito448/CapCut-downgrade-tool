namespace CapCutVersionEditor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            this.comboBoxVersoesCapCut = new System.Windows.Forms.ComboBox();
            this.comboBoxProjetos = new System.Windows.Forms.ComboBox();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxVersoesCapCut
            // 
            this.comboBoxVersoesCapCut.FormattingEnabled = true;
            this.comboBoxVersoesCapCut.Location = new System.Drawing.Point(50, 60);
            this.comboBoxVersoesCapCut.Name = "comboBoxVersoesCapCut";
            this.comboBoxVersoesCapCut.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVersoesCapCut.TabIndex = 0;
            // 
            // comboBoxProjetos
            // 
            this.comboBoxProjetos.FormattingEnabled = true;
            this.comboBoxProjetos.Location = new System.Drawing.Point(50, 100);
            this.comboBoxProjetos.Name = "comboBoxProjetos";
            this.comboBoxProjetos.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProjetos.TabIndex = 1;
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(100, 150);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(100, 30);
            this.buttonAplicar.TabIndex = 2;
            this.buttonAplicar.Text = "Aplicar Versão";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha a versão desejada:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.comboBoxProjetos);
            this.Controls.Add(this.comboBoxVersoesCapCut);
            this.Name = "Form1";
            this.Text = "CapCut Downgrade Tool";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxVersoesCapCut;
        private System.Windows.Forms.ComboBox comboBoxProjetos;
        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Label label1;
    }
}