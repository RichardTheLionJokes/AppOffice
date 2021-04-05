namespace AppOffice
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Defect = new System.Windows.Forms.RichTextBox();
            this.Hardware = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.CreateAct = new System.Windows.Forms.Button();
            this.Defects = new System.Windows.Forms.ComboBox();
            this.AddDefect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteDefect = new System.Windows.Forms.Button();
            this.SaveDefect = new System.Windows.Forms.Button();
            this.ClearDefect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveHardware = new System.Windows.Forms.Button();
            this.Inventarnik = new System.Windows.Forms.MaskedTextBox();
            this.Nazvanie = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear = new System.Windows.Forms.Button();
            this.DeleteHardware = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DrMetNo = new System.Windows.Forms.RadioButton();
            this.DrMetYes = new System.Windows.Forms.RadioButton();
            this.AddInAct = new System.Windows.Forms.Button();
            this.CurrentAct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommissName1 = new System.Windows.Forms.ComboBox();
            this.CommissName3 = new System.Windows.Forms.ComboBox();
            this.CommissName2 = new System.Windows.Forms.ComboBox();
            this.CommissPost1 = new System.Windows.Forms.ComboBox();
            this.CommissPost3 = new System.Windows.Forms.ComboBox();
            this.CommissPost2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Defect
            // 
            this.Defect.Location = new System.Drawing.Point(9, 109);
            this.Defect.Name = "Defect";
            this.Defect.ReadOnly = true;
            this.Defect.Size = new System.Drawing.Size(394, 100);
            this.Defect.TabIndex = 5;
            this.Defect.Text = "";
            // 
            // Hardware
            // 
            this.Hardware.FormattingEnabled = true;
            this.Hardware.Location = new System.Drawing.Point(16, 201);
            this.Hardware.Name = "Hardware";
            this.Hardware.Size = new System.Drawing.Size(248, 21);
            this.Hardware.Sorted = true;
            this.Hardware.TabIndex = 0;
            this.Hardware.SelectedIndexChanged += new System.EventHandler(this.Hardware_SelectedIndexChanged);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(15, 426);
            this.Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Size = new System.Drawing.Size(66, 20);
            this.Quantity.TabIndex = 5;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateAct
            // 
            this.CreateAct.Location = new System.Drawing.Point(17, 27);
            this.CreateAct.Name = "CreateAct";
            this.CreateAct.Size = new System.Drawing.Size(75, 23);
            this.CreateAct.TabIndex = 0;
            this.CreateAct.Text = "Создать";
            this.CreateAct.UseVisualStyleBackColor = true;
            this.CreateAct.Click += new System.EventHandler(this.CreateAct_Click);
            // 
            // Defects
            // 
            this.Defects.FormattingEnabled = true;
            this.Defects.Location = new System.Drawing.Point(6, 44);
            this.Defects.Name = "Defects";
            this.Defects.Size = new System.Drawing.Size(394, 21);
            this.Defects.Sorted = true;
            this.Defects.TabIndex = 0;
            // 
            // AddDefect
            // 
            this.AddDefect.Location = new System.Drawing.Point(6, 80);
            this.AddDefect.Name = "AddDefect";
            this.AddDefect.Size = new System.Drawing.Size(75, 23);
            this.AddDefect.TabIndex = 1;
            this.AddDefect.Text = "Добавить";
            this.AddDefect.UseVisualStyleBackColor = true;
            this.AddDefect.Click += new System.EventHandler(this.AddDefect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteDefect);
            this.groupBox1.Controls.Add(this.SaveDefect);
            this.groupBox1.Controls.Add(this.ClearDefect);
            this.groupBox1.Controls.Add(this.AddDefect);
            this.groupBox1.Controls.Add(this.Defects);
            this.groupBox1.Controls.Add(this.Defect);
            this.groupBox1.Location = new System.Drawing.Point(293, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дефекты";
            // 
            // DeleteDefect
            // 
            this.DeleteDefect.Location = new System.Drawing.Point(297, 80);
            this.DeleteDefect.Name = "DeleteDefect";
            this.DeleteDefect.Size = new System.Drawing.Size(75, 23);
            this.DeleteDefect.TabIndex = 4;
            this.DeleteDefect.Text = "Удалить";
            this.DeleteDefect.UseVisualStyleBackColor = true;
            this.DeleteDefect.Click += new System.EventHandler(this.DeleteDefect_Click);
            // 
            // SaveDefect
            // 
            this.SaveDefect.Location = new System.Drawing.Point(200, 80);
            this.SaveDefect.Name = "SaveDefect";
            this.SaveDefect.Size = new System.Drawing.Size(75, 23);
            this.SaveDefect.TabIndex = 3;
            this.SaveDefect.Text = "Сохранить";
            this.SaveDefect.UseVisualStyleBackColor = true;
            this.SaveDefect.Click += new System.EventHandler(this.SaveDefect_Click);
            // 
            // ClearDefect
            // 
            this.ClearDefect.Location = new System.Drawing.Point(102, 80);
            this.ClearDefect.Name = "ClearDefect";
            this.ClearDefect.Size = new System.Drawing.Size(75, 23);
            this.ClearDefect.TabIndex = 2;
            this.ClearDefect.Text = "Очистить";
            this.ClearDefect.UseVisualStyleBackColor = true;
            this.ClearDefect.Click += new System.EventHandler(this.ClearDefect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Количество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Инвентарный номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название оборудования:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Оборудование:";
            // 
            // SaveHardware
            // 
            this.SaveHardware.Location = new System.Drawing.Point(16, 237);
            this.SaveHardware.Name = "SaveHardware";
            this.SaveHardware.Size = new System.Drawing.Size(75, 23);
            this.SaveHardware.TabIndex = 1;
            this.SaveHardware.Text = "Сохранить";
            this.SaveHardware.UseVisualStyleBackColor = true;
            this.SaveHardware.Click += new System.EventHandler(this.SaveHardware_Click);
            // 
            // Inventarnik
            // 
            this.Inventarnik.Location = new System.Drawing.Point(15, 364);
            this.Inventarnik.Mask = "0000000000";
            this.Inventarnik.Name = "Inventarnik";
            this.Inventarnik.Size = new System.Drawing.Size(120, 20);
            this.Inventarnik.TabIndex = 4;
            // 
            // Nazvanie
            // 
            this.Nazvanie.Location = new System.Drawing.Point(15, 305);
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(249, 20);
            this.Nazvanie.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.addToolStripMenuItem,
            this.addInToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addInToolStripMenuItem
            // 
            this.addInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addInToolStripMenuItem.Image")));
            this.addInToolStripMenuItem.Name = "addInToolStripMenuItem";
            this.addInToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addInToolStripMenuItem.Text = "Добавить в";
            this.addInToolStripMenuItem.Click += new System.EventHandler(this.addInToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(16, 138);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DeleteHardware
            // 
            this.DeleteHardware.Location = new System.Drawing.Point(114, 237);
            this.DeleteHardware.Name = "DeleteHardware";
            this.DeleteHardware.Size = new System.Drawing.Size(75, 23);
            this.DeleteHardware.TabIndex = 2;
            this.DeleteHardware.Text = "Удалить";
            this.DeleteHardware.UseVisualStyleBackColor = true;
            this.DeleteHardware.Click += new System.EventHandler(this.DeleteHardware_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DrMetNo);
            this.groupBox2.Controls.Add(this.DrMetYes);
            this.groupBox2.Location = new System.Drawing.Point(109, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Наличие драг. металлов";
            // 
            // DrMetNo
            // 
            this.DrMetNo.AutoSize = true;
            this.DrMetNo.Checked = true;
            this.DrMetNo.Location = new System.Drawing.Point(95, 21);
            this.DrMetNo.Name = "DrMetNo";
            this.DrMetNo.Size = new System.Drawing.Size(44, 17);
            this.DrMetNo.TabIndex = 1;
            this.DrMetNo.TabStop = true;
            this.DrMetNo.Text = "Нет";
            this.DrMetNo.UseVisualStyleBackColor = true;
            // 
            // DrMetYes
            // 
            this.DrMetYes.AutoSize = true;
            this.DrMetYes.Location = new System.Drawing.Point(6, 21);
            this.DrMetYes.Name = "DrMetYes";
            this.DrMetYes.Size = new System.Drawing.Size(40, 17);
            this.DrMetYes.TabIndex = 0;
            this.DrMetYes.Text = "Да";
            this.DrMetYes.UseVisualStyleBackColor = true;
            // 
            // AddInAct
            // 
            this.AddInAct.Location = new System.Drawing.Point(116, 27);
            this.AddInAct.Name = "AddInAct";
            this.AddInAct.Size = new System.Drawing.Size(75, 23);
            this.AddInAct.TabIndex = 1;
            this.AddInAct.Text = "Добавить";
            this.AddInAct.UseVisualStyleBackColor = true;
            this.AddInAct.Click += new System.EventHandler(this.AddInAct_Click);
            // 
            // CurrentAct
            // 
            this.CurrentAct.Location = new System.Drawing.Point(261, 47);
            this.CurrentAct.Name = "CurrentAct";
            this.CurrentAct.ReadOnly = true;
            this.CurrentAct.Size = new System.Drawing.Size(400, 20);
            this.CurrentAct.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Текущая ведомость:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CreateAct);
            this.groupBox3.Controls.Add(this.CurrentAct);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.AddInAct);
            this.groupBox3.Location = new System.Drawing.Point(16, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 81);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дефектная ведомость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Комиссия:";
            // 
            // CommissName1
            // 
            this.CommissName1.FormattingEnabled = true;
            this.CommissName1.Location = new System.Drawing.Point(293, 375);
            this.CommissName1.Name = "CommissName1";
            this.CommissName1.Size = new System.Drawing.Size(121, 21);
            this.CommissName1.TabIndex = 8;
            // 
            // CommissName3
            // 
            this.CommissName3.FormattingEnabled = true;
            this.CommissName3.Location = new System.Drawing.Point(578, 375);
            this.CommissName3.Name = "CommissName3";
            this.CommissName3.Size = new System.Drawing.Size(121, 21);
            this.CommissName3.TabIndex = 12;
            // 
            // CommissName2
            // 
            this.CommissName2.FormattingEnabled = true;
            this.CommissName2.Location = new System.Drawing.Point(432, 375);
            this.CommissName2.Name = "CommissName2";
            this.CommissName2.Size = new System.Drawing.Size(125, 21);
            this.CommissName2.TabIndex = 10;
            // 
            // CommissPost1
            // 
            this.CommissPost1.FormattingEnabled = true;
            this.CommissPost1.Location = new System.Drawing.Point(293, 410);
            this.CommissPost1.Name = "CommissPost1";
            this.CommissPost1.Size = new System.Drawing.Size(121, 21);
            this.CommissPost1.TabIndex = 9;
            // 
            // CommissPost3
            // 
            this.CommissPost3.FormattingEnabled = true;
            this.CommissPost3.Location = new System.Drawing.Point(578, 410);
            this.CommissPost3.Name = "CommissPost3";
            this.CommissPost3.Size = new System.Drawing.Size(121, 21);
            this.CommissPost3.TabIndex = 13;
            // 
            // CommissPost2
            // 
            this.CommissPost2.FormattingEnabled = true;
            this.CommissPost2.Location = new System.Drawing.Point(432, 410);
            this.CommissPost2.Name = "CommissPost2";
            this.CommissPost2.Size = new System.Drawing.Size(125, 21);
            this.CommissPost2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.CreateAct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.CommissPost2);
            this.Controls.Add(this.CommissPost3);
            this.Controls.Add(this.CommissPost1);
            this.Controls.Add(this.CommissName2);
            this.Controls.Add(this.CommissName3);
            this.Controls.Add(this.CommissName1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DeleteHardware);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Inventarnik);
            this.Controls.Add(this.SaveHardware);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nazvanie);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Hardware);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Defect Creator";
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Defect;
        private System.Windows.Forms.ComboBox Hardware;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Button CreateAct;
        private System.Windows.Forms.ComboBox Defects;
        private System.Windows.Forms.Button AddDefect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearDefect;
        private System.Windows.Forms.Button SaveDefect;
        private System.Windows.Forms.Button SaveHardware;
        private System.Windows.Forms.MaskedTextBox Inventarnik;
        private System.Windows.Forms.TextBox Nazvanie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button DeleteHardware;
        private System.Windows.Forms.Button DeleteDefect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DrMetNo;
        private System.Windows.Forms.RadioButton DrMetYes;
        private System.Windows.Forms.Button AddInAct;
        private System.Windows.Forms.TextBox CurrentAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CommissName1;
        private System.Windows.Forms.ComboBox CommissName3;
        private System.Windows.Forms.ComboBox CommissName2;
        private System.Windows.Forms.ComboBox CommissPost1;
        private System.Windows.Forms.ComboBox CommissPost3;
        private System.Windows.Forms.ComboBox CommissPost2;
    }
}

