using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AppOffice
{
    public partial class SettingsForm1 : Form
    {
        string SavePath;
        string ShablonPath;
        string HardwarePath;
        string CommissionPath;

        public SettingsForm1()
        {
            InitializeComponent();
            if (File.Exists(Application.StartupPath + @"\Path\SavePath.txt")) //вывод пути для сохранения актов
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\SavePath.txt", Encoding.Default);
                SavePath = objReader.ReadLine();
                objReader.Close();
                SaveTo.Text = SavePath;
            }
            if (File.Exists(Application.StartupPath + @"\Path\ShablonPath.txt")) //вывод пути к шаблону
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\ShablonPath.txt", Encoding.Default);
                ShablonPath = objReader.ReadLine();
                objReader.Close();
                Shablon.Text = ShablonPath;
            }
            if (File.Exists(Application.StartupPath + @"\Path\HardwarePath.txt")) //вывод пути к списку оборудования и дефектов
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\HardwarePath.txt", Encoding.Default);
                HardwarePath = objReader.ReadLine();
                objReader.Close();
                Hardware.Text = HardwarePath;
            }
            if (File.Exists(Application.StartupPath + @"\Path\CommissionPath.txt")) //вывод пути к списку членов комиссии
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\CommissionPath.txt", Encoding.Default);
                CommissionPath = objReader.ReadLine();
                objReader.Close();
                Commission.Text = CommissionPath;
            }
        }

        private void SaveToChange_Click(object sender, EventArgs e) //изменение папки для сохранения дефектных ведомостей
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выборите папку для сохранения дефектных ведомостей";
            folderDialog.ShowDialog();            
            if (folderDialog.SelectedPath != "")
            {
                SavePath = folderDialog.SelectedPath + @"\";
                SaveTo.Text = SavePath;
            }
        }

        private void ShablonChange_Click(object sender, EventArgs e) //изменение шаблона
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Выберите шаблон для создания дефектных ведомостей";
            openDialog.Filter = "Файл Excel|*.xlsx;*.xls";
            openDialog.ShowDialog();            
            if (openDialog.FileName != "")
            {
                ShablonPath = openDialog.FileName;                
                Shablon.Text = ShablonPath;
            }
        }

        private void HardwareChange_Click(object sender, EventArgs e) //изменение папки, из которой берется список оборудования и дефектов
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку, из которой будет браться список оборудования и дефектов";
            folderDialog.ShowDialog();            
            if (folderDialog.SelectedPath != "")
            {
                HardwarePath = folderDialog.SelectedPath + @"\";
                Hardware.Text = HardwarePath;
            }
        }

        private void CommissionChange_Click(object sender, EventArgs e) //изменение папки, из которой берется список членов комиссии
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку, из которой будет браться список членов комиссии";
            folderDialog.ShowDialog();
            if (folderDialog.SelectedPath != "")
            {
                CommissionPath = folderDialog.SelectedPath + @"\";
                Commission.Text = CommissionPath;
            }
        }

        private void Default_Click(object sender, EventArgs e) //настройки по умолчанию
        {
            SavePath = Application.StartupPath + @"\Act\";
            SaveTo.Text = SavePath;

            ShablonPath = Application.StartupPath + @"\Act\Shablon\Shablon.xlsx";
            Shablon.Text = ShablonPath;

            HardwarePath = Application.StartupPath + @"\Hardware\";
            Hardware.Text = HardwarePath;

            CommissionPath = Application.StartupPath + @"\Commission\";
            Commission.Text = CommissionPath;
        }

        private void OK_Click(object sender, EventArgs e) //применение настроек
        {
            StreamWriter objWriter1 = new StreamWriter(Application.StartupPath + @"\Path\SavePath.txt", false, Encoding.Default);
            objWriter1.Write(SavePath);
            objWriter1.Close();

            StreamWriter objWriter2 = new StreamWriter(Application.StartupPath + @"\Path\ShablonPath.txt", false, Encoding.Default);
            objWriter2.Write(ShablonPath);
            objWriter2.Close();

            StreamWriter objWriter3 = new StreamWriter(Application.StartupPath + @"\Path\HardwarePath.txt", false, Encoding.Default);
            objWriter3.Write(HardwarePath);
            objWriter3.Close();

            StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Path\CommissionPath.txt", false, Encoding.Default);
            objWriter.Write(CommissionPath);
            objWriter.Close();

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e) //отмена
        {
            Close();
        }
    }
}
