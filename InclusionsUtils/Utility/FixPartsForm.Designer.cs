using System.ComponentModel;

namespace InclusionsUtils.Utility
{
    partial class FixPartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixPartsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.damageParts = new System.Windows.Forms.TextBox();
            this.copyResultButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fixPartsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultParts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "ARREGLAR PARTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "JONATHAN NARVAEZ | 2023 - 2024";
            // 
            // damageParts
            // 
            this.damageParts.Location = new System.Drawing.Point(110, 96);
            this.damageParts.Multiline = true;
            this.damageParts.Name = "damageParts";
            this.damageParts.Size = new System.Drawing.Size(234, 107);
            this.damageParts.TabIndex = 7;
            // 
            // copyResultButton
            // 
            this.copyResultButton.AutoSize = true;
            this.copyResultButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.copyResultButton.FlatAppearance.BorderSize = 2;
            this.copyResultButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyResultButton.Location = new System.Drawing.Point(375, 235);
            this.copyResultButton.Name = "copyResultButton";
            this.copyResultButton.Size = new System.Drawing.Size(199, 32);
            this.copyResultButton.TabIndex = 18;
            this.copyResultButton.Text = "COPIAR RESULTADO";
            this.copyResultButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(258, 273);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(199, 32);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "&LIMPIAR";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // fixPartsButton
            // 
            this.fixPartsButton.AutoSize = true;
            this.fixPartsButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.fixPartsButton.FlatAppearance.BorderSize = 2;
            this.fixPartsButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixPartsButton.Location = new System.Drawing.Point(145, 235);
            this.fixPartsButton.Name = "fixPartsButton";
            this.fixPartsButton.Size = new System.Drawing.Size(199, 32);
            this.fixPartsButton.TabIndex = 16;
            this.fixPartsButton.Text = "&ARREGLAR PARTES";
            this.fixPartsButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "DIGITE LA PARTE ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "RESULTADO";
            // 
            // resultParts
            // 
            this.resultParts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultParts.Location = new System.Drawing.Point(375, 96);
            this.resultParts.Multiline = true;
            this.resultParts.Name = "resultParts";
            this.resultParts.ReadOnly = true;
            this.resultParts.Size = new System.Drawing.Size(234, 107);
            this.resultParts.TabIndex = 21;
            // 
            // FixPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copyResultButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fixPartsButton);
            this.Controls.Add(this.damageParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixPartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARREGLAR PARTES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FixPartsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultParts;

        private System.Windows.Forms.Button copyResultButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fixPartsButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox damageParts;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}