namespace InclusionsUtils.Form
{
    partial class PartConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartConverterForm));
            this.oldParts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.defandants = new System.Windows.Forms.TextBox();
            this.partsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.complainants = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.copyComplainants = new System.Windows.Forms.Button();
            this.copyDefandants = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pagesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // oldParts
            // 
            this.oldParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldParts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldParts.Location = new System.Drawing.Point(25, 135);
            this.oldParts.Multiline = true;
            this.oldParts.Name = "oldParts";
            this.oldParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.oldParts.Size = new System.Drawing.Size(372, 245);
            this.oldParts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONVERTIR PARTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "JONATHAN NARVAEZ | 2023 - 2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "PARTES DESDE RAMA JUDICIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "TEXTO PARA ASIGNAR A LITI";
            // 
            // defandants
            // 
            this.defandants.BackColor = System.Drawing.SystemColors.ControlDark;
            this.defandants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defandants.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defandants.Location = new System.Drawing.Point(449, 154);
            this.defandants.Multiline = true;
            this.defandants.Name = "defandants";
            this.defandants.ReadOnly = true;
            this.defandants.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defandants.Size = new System.Drawing.Size(323, 86);
            this.defandants.TabIndex = 7;
            // 
            // partsButton
            // 
            this.partsButton.AutoSize = true;
            this.partsButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.partsButton.FlatAppearance.BorderSize = 2;
            this.partsButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsButton.Location = new System.Drawing.Point(188, 404);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(199, 32);
            this.partsButton.TabIndex = 9;
            this.partsButton.Text = "&CONVERTIR PARTES";
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(188, 442);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(199, 32);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "&LIMPIAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // complainants
            // 
            this.complainants.BackColor = System.Drawing.SystemColors.ControlDark;
            this.complainants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.complainants.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainants.Location = new System.Drawing.Point(449, 294);
            this.complainants.Multiline = true;
            this.complainants.Name = "complainants";
            this.complainants.ReadOnly = true;
            this.complainants.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.complainants.Size = new System.Drawing.Size(323, 86);
            this.complainants.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "DEMANDADOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "DEMANDANTES";
            // 
            // copyComplainants
            // 
            this.copyComplainants.AutoSize = true;
            this.copyComplainants.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.copyComplainants.FlatAppearance.BorderSize = 2;
            this.copyComplainants.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyComplainants.Location = new System.Drawing.Point(418, 442);
            this.copyComplainants.Name = "copyComplainants";
            this.copyComplainants.Size = new System.Drawing.Size(199, 32);
            this.copyComplainants.TabIndex = 15;
            this.copyComplainants.Text = "COPIAR DEMAND&ANTES";
            this.copyComplainants.UseVisualStyleBackColor = true;
            this.copyComplainants.Click += new System.EventHandler(this.copyComplainants_Click);
            // 
            // copyDefandants
            // 
            this.copyDefandants.AutoSize = true;
            this.copyDefandants.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.copyDefandants.FlatAppearance.BorderSize = 2;
            this.copyDefandants.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyDefandants.Location = new System.Drawing.Point(418, 404);
            this.copyDefandants.Name = "copyDefandants";
            this.copyDefandants.Size = new System.Drawing.Size(199, 32);
            this.copyDefandants.TabIndex = 14;
            this.copyDefandants.Text = "COPIAR DEMANDAD&OS";
            this.copyDefandants.UseVisualStyleBackColor = true;
            this.copyDefandants.Click += new System.EventHandler(this.copyDefandants_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "SELECCIONE LA PAGINA DE DONDE VIENEN LOS DATOS";
            // 
            // pagesList
            // 
            this.pagesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagesList.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.pagesList.FormattingEnabled = true;
            this.pagesList.Items.AddRange(new object[] { "RAMA JUDICIAL", "TYBA", "SAMAI", "SIGLO XXI" });
            this.pagesList.Location = new System.Drawing.Point(276, 72);
            this.pagesList.Name = "pagesList";
            this.pagesList.Size = new System.Drawing.Size(257, 24);
            this.pagesList.TabIndex = 17;
            // 
            // PartConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.pagesList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.copyComplainants);
            this.Controls.Add(this.copyDefandants);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.complainants);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.defandants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldParts);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONVERTIR PARTES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartConverterForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartConverterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox pagesList;

        #endregion

        private System.Windows.Forms.TextBox oldParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox defandants;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox complainants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button copyComplainants;
        private System.Windows.Forms.Button copyDefandants;
    }
}