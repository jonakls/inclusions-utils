using System.ComponentModel;

namespace InclusionsUtils.Form
{
    partial class FixResolvesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixResolvesForm));
            this.label4 = new System.Windows.Forms.Label();
            this.resultResolve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.copyResultButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fixResolve = new System.Windows.Forms.Button();
            this.damageResolve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "RESULTADO";
            // 
            // resultResolve
            // 
            this.resultResolve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultResolve.Location = new System.Drawing.Point(298, 106);
            this.resultResolve.Multiline = true;
            this.resultResolve.Name = "resultResolve";
            this.resultResolve.ReadOnly = true;
            this.resultResolve.Size = new System.Drawing.Size(234, 107);
            this.resultResolve.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "RESUELVE DE PAGINA";
            // 
            // copyResultButton
            // 
            this.copyResultButton.AutoSize = true;
            this.copyResultButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.copyResultButton.FlatAppearance.BorderSize = 2;
            this.copyResultButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyResultButton.Location = new System.Drawing.Point(298, 245);
            this.copyResultButton.Name = "copyResultButton";
            this.copyResultButton.Size = new System.Drawing.Size(199, 32);
            this.copyResultButton.TabIndex = 28;
            this.copyResultButton.Text = "COPIAR RESULTADO";
            this.copyResultButton.UseVisualStyleBackColor = true;
            this.copyResultButton.Click += new System.EventHandler(this.copyResultButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(181, 283);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(199, 32);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "&LIMPIAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fixResolve
            // 
            this.fixResolve.AutoSize = true;
            this.fixResolve.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.fixResolve.FlatAppearance.BorderSize = 2;
            this.fixResolve.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixResolve.Location = new System.Drawing.Point(68, 245);
            this.fixResolve.Name = "fixResolve";
            this.fixResolve.Size = new System.Drawing.Size(199, 32);
            this.fixResolve.TabIndex = 26;
            this.fixResolve.Text = "&ARREGLAR RESUELVE";
            this.fixResolve.UseVisualStyleBackColor = true;
            this.fixResolve.Click += new System.EventHandler(this.fixResolve_Click);
            // 
            // damageResolve
            // 
            this.damageResolve.Location = new System.Drawing.Point(33, 106);
            this.damageResolve.Multiline = true;
            this.damageResolve.Name = "damageResolve";
            this.damageResolve.Size = new System.Drawing.Size(234, 107);
            this.damageResolve.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "JONATHAN NARVAEZ | 2023 - 2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "ARREGLAR RESUELVES";
            // 
            // FixResolvesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultResolve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copyResultButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fixResolve);
            this.Controls.Add(this.damageResolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixResolvesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR RESUELVES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FixResolvesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultResolve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copyResultButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fixResolve;
        private System.Windows.Forms.TextBox damageResolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}