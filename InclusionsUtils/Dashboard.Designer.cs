namespace InclusionsUtils
{
    partial class Dashboard
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.partsConverter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filings = new System.Windows.Forms.Button();
            this.fixParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTILIDADES INCLUSIONES";
            // 
            // partsConverter
            // 
            this.partsConverter.AutoSize = true;
            this.partsConverter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.partsConverter.FlatAppearance.BorderSize = 2;
            this.partsConverter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsConverter.Location = new System.Drawing.Point(102, 172);
            this.partsConverter.Name = "partsConverter";
            this.partsConverter.Size = new System.Drawing.Size(199, 32);
            this.partsConverter.TabIndex = 1;
            this.partsConverter.Text = "&CONVERTIR PARTES";
            this.partsConverter.UseVisualStyleBackColor = true;
            this.partsConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "JONATHAN NARVAEZ | 2023 - 2024";
            // 
            // filings
            // 
            this.filings.AutoSize = true;
            this.filings.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.filings.FlatAppearance.BorderSize = 2;
            this.filings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filings.Location = new System.Drawing.Point(102, 248);
            this.filings.Name = "filings";
            this.filings.Size = new System.Drawing.Size(199, 32);
            this.filings.TabIndex = 5;
            this.filings.Text = "RADICADOS";
            this.filings.UseVisualStyleBackColor = true;
            this.filings.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // fixParts
            // 
            this.fixParts.AutoSize = true;
            this.fixParts.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.fixParts.FlatAppearance.BorderSize = 2;
            this.fixParts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixParts.Location = new System.Drawing.Point(102, 210);
            this.fixParts.Name = "fixParts";
            this.fixParts.Size = new System.Drawing.Size(199, 32);
            this.fixParts.TabIndex = 6;
            this.fixParts.Text = "&ARREGLAR PARTES";
            this.fixParts.UseVisualStyleBackColor = true;
            this.fixParts.Click += new System.EventHandler(this.fixParts_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 385);
            this.Controls.Add(this.fixParts);
            this.Controls.Add(this.filings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partsConverter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INCLUSIONES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button partsConverter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filings;
        private System.Windows.Forms.Button fixParts;
    }
}

