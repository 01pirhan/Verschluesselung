namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnverschluesseln = new System.Windows.Forms.Button();
            this.tfeingabe = new System.Windows.Forms.TextBox();
            this.tfausgabe = new System.Windows.Forms.TextBox();
            this.tfschrittweite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnverschluesseln
            // 
            this.btnverschluesseln.Location = new System.Drawing.Point(116, 192);
            this.btnverschluesseln.Name = "btnverschluesseln";
            this.btnverschluesseln.Size = new System.Drawing.Size(245, 64);
            this.btnverschluesseln.TabIndex = 0;
            this.btnverschluesseln.Text = "Verschlüsseln";
            this.btnverschluesseln.UseVisualStyleBackColor = true;
            this.btnverschluesseln.Click += new System.EventHandler(this.btnverschluesseln_Click);
            // 
            // tfeingabe
            // 
            this.tfeingabe.Location = new System.Drawing.Point(116, 78);
            this.tfeingabe.Name = "tfeingabe";
            this.tfeingabe.Size = new System.Drawing.Size(245, 26);
            this.tfeingabe.TabIndex = 1;
            // 
            // tfausgabe
            // 
            this.tfausgabe.Enabled = false;
            this.tfausgabe.Location = new System.Drawing.Point(116, 339);
            this.tfausgabe.Name = "tfausgabe";
            this.tfausgabe.Size = new System.Drawing.Size(245, 26);
            this.tfausgabe.TabIndex = 2;
            // 
            // tfschrittweite
            // 
            this.tfschrittweite.Location = new System.Drawing.Point(116, 151);
            this.tfschrittweite.Name = "tfschrittweite";
            this.tfschrittweite.Size = new System.Drawing.Size(100, 26);
            this.tfschrittweite.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 488);
            this.Controls.Add(this.tfschrittweite);
            this.Controls.Add(this.tfausgabe);
            this.Controls.Add(this.tfeingabe);
            this.Controls.Add(this.btnverschluesseln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnverschluesseln;
        private System.Windows.Forms.TextBox tfeingabe;
        private System.Windows.Forms.TextBox tfausgabe;
        private System.Windows.Forms.TextBox tfschrittweite;
    }
}

