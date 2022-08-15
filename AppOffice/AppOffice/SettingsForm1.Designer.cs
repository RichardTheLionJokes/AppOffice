namespace AppOffice
{
    partial class SettingsForm1
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
            this.SaveTo = new System.Windows.Forms.TextBox();
            this.Shablon = new System.Windows.Forms.TextBox();
            this.Hardware = new System.Windows.Forms.TextBox();
            this.Commission = new System.Windows.Forms.TextBox();
            this.SaveToChange = new System.Windows.Forms.Button();
            this.ShablonChange = new System.Windows.Forms.Button();
            this.HardwareChange = new System.Windows.Forms.Button();
            this.CommissionChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Default = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveTo
            // 
            this.SaveTo.Location = new System.Drawing.Point(22, 38);
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.ReadOnly = true;
            this.SaveTo.Size = new System.Drawing.Size(340, 20);
            this.SaveTo.TabIndex = 0;
            // 
            // Shablon
            // 
            this.Shablon.Location = new System.Drawing.Point(22, 85);
            this.Shablon.Name = "Shablon";
            this.Shablon.ReadOnly = true;
            this.Shablon.Size = new System.Drawing.Size(340, 20);
            this.Shablon.TabIndex = 2;
            // 
            // Hardware
            // 
            this.Hardware.Location = new System.Drawing.Point(22, 132);
            this.Hardware.Name = "Hardware";
            this.Hardware.ReadOnly = true;
            this.Hardware.Size = new System.Drawing.Size(340, 20);
            this.Hardware.TabIndex = 4;
            // 
            // Commission
            // 
            this.Commission.Location = new System.Drawing.Point(22, 178);
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            this.Commission.Size = new System.Drawing.Size(340, 20);
            this.Commission.TabIndex = 6;
            // 
            // SaveToChange
            // 
            this.SaveToChange.Location = new System.Drawing.Point(380, 38);
            this.SaveToChange.Name = "SaveToChange";
            this.SaveToChange.Size = new System.Drawing.Size(30, 20);
            this.SaveToChange.TabIndex = 1;
            this.SaveToChange.Text = "...";
            this.SaveToChange.UseVisualStyleBackColor = true;
            this.SaveToChange.Click += new System.EventHandler(this.SaveToChange_Click);
            // 
            // ShablonChange
            // 
            this.ShablonChange.Location = new System.Drawing.Point(380, 84);
            this.ShablonChange.Name = "ShablonChange";
            this.ShablonChange.Size = new System.Drawing.Size(30, 20);
            this.ShablonChange.TabIndex = 3;
            this.ShablonChange.Text = "...";
            this.ShablonChange.UseVisualStyleBackColor = true;
            this.ShablonChange.Click += new System.EventHandler(this.ShablonChange_Click);
            // 
            // HardwareChange
            // 
            this.HardwareChange.Location = new System.Drawing.Point(380, 132);
            this.HardwareChange.Name = "HardwareChange";
            this.HardwareChange.Size = new System.Drawing.Size(30, 19);
            this.HardwareChange.TabIndex = 5;
            this.HardwareChange.Text = "...";
            this.HardwareChange.UseVisualStyleBackColor = true;
            this.HardwareChange.Click += new System.EventHandler(this.HardwareChange_Click);
            // 
            // CommissionChange
            // 
            this.CommissionChange.Location = new System.Drawing.Point(380, 178);
            this.CommissionChange.Name = "CommissionChange";
            this.CommissionChange.Size = new System.Drawing.Size(30, 19);
            this.CommissionChange.TabIndex = 7;
            this.CommissionChange.Text = "...";
            this.CommissionChange.UseVisualStyleBackColor = true;
            this.CommissionChange.Click += new System.EventHandler(this.CommissionChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Папка для сохранения актов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Шаблон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Список оборудования и дефектов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Список членов комиссии:";
            // 
            // Default
            // 
            this.Default.Location = new System.Drawing.Point(49, 216);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(169, 23);
            this.Default.TabIndex = 8;
            this.Default.Text = "Настройки по умолчанию";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(245, 216);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(335, 216);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SettingsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 256);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommissionChange);
            this.Controls.Add(this.HardwareChange);
            this.Controls.Add(this.ShablonChange);
            this.Controls.Add(this.SaveToChange);
            this.Controls.Add(this.Commission);
            this.Controls.Add(this.Hardware);
            this.Controls.Add(this.Shablon);
            this.Controls.Add(this.SaveTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SaveTo;
        private System.Windows.Forms.TextBox Shablon;
        private System.Windows.Forms.TextBox Hardware;
        private System.Windows.Forms.TextBox Commission;
        private System.Windows.Forms.Button SaveToChange;
        private System.Windows.Forms.Button ShablonChange;
        private System.Windows.Forms.Button HardwareChange;
        private System.Windows.Forms.Button CommissionChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}