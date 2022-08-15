using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;

namespace AppOffice
{
    public partial class Form1 : Form
    {
        string HardwarePath = "";
        string CommissionPath = "";

        public Form1() //запуск формы
        {
            InitializeComponent();            

            if (File.Exists(Application.StartupPath + @"\Path\SavePath.txt") == false) //создание файла с путем для сохранения актов, если его нет
            {
                StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Path\SavePath.txt", true, Encoding.Default);
                objWriter.Write(Application.StartupPath + @"\Act\");
                objWriter.Close();
            }

            if (File.Exists(Application.StartupPath + @"\Path\ShablonPath.txt") == false) //создание файла с путем для шаблона, если его нет
            {
                if (File.Exists(Application.StartupPath + @"\Act\Shablon\Shablon.xlsx"))
                {
                    StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Path\ShablonPath.txt", true, Encoding.Default);
                    objWriter.Write(Application.StartupPath + @"\Act\Shablon\Shablon.xlsx");
                    objWriter.Close();
                }
            }

            #region настройка пути к списку оборудования и считывание списка оборудования из файла
            if (File.Exists(Application.StartupPath + @"\Path\HardwarePath.txt") == false) //создание файла с путем к списку оборудования и дефектов, если его нет
            {
                StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Path\HardwarePath.txt", true, Encoding.Default);
                HardwarePath = Application.StartupPath + @"\Hardware\";
                objWriter.Write(HardwarePath);
                objWriter.Close();
            }
            if (File.Exists(Application.StartupPath + @"\Path\HardwarePath.txt")) //если есть файл с путем к списку оборудования и дефектов
            {
                StreamReader objReader1 = new StreamReader(Application.StartupPath + @"\Path\HardwarePath.txt", Encoding.Default);
                HardwarePath = objReader1.ReadLine();
                objReader1.Close();

                if (File.Exists(HardwarePath + @"Hardware.txt")) //формирование списка оборудования из файла
                {
                    StreamReader objReader2 = new StreamReader(HardwarePath + @"Hardware.txt", Encoding.Default);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = objReader2.ReadLine();
                        if (sLine != null) Hardware.Items.Add(sLine);
                    }
                    objReader2.Close();
                }
            }
            #endregion

            #region настройка пути к списку членов комиссии
            if (File.Exists(Application.StartupPath + @"\Path\CommissionPath.txt") == false) //создание файла с путем к списку членов комиссии, если его нет
            {
                StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Path\CommissionPath.txt", true, Encoding.Default);
                CommissionPath = Application.StartupPath + @"\Commission\";
                objWriter.Write(CommissionPath);
                objWriter.Close();
            }
            if (File.Exists(Application.StartupPath + @"\Path\CommissionPath.txt")) //если есть файл с путем к списку членов комиссии
            {
                StreamReader objReader1 = new StreamReader(Application.StartupPath + @"\Path\CommissionPath.txt", Encoding.Default);
                CommissionPath = objReader1.ReadLine();
                objReader1.Close();

                if (File.Exists(CommissionPath + @"Names.txt")) //формирование списка имен членов комиссии из файла
                {
                    StreamReader objReader = new StreamReader(CommissionPath + @"Names.txt", Encoding.Default);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null) CommissName1.Items.Add(sLine);
                        if (sLine != null) CommissName2.Items.Add(sLine);
                        if (sLine != null) CommissName3.Items.Add(sLine);
                    }
                    objReader.Close();
                    CommissName1.Text = CommissName1.Items[0].ToString();
                    CommissName2.Text = CommissName2.Items[1].ToString();
                    CommissName3.Text = CommissName3.Items[2].ToString();
                }
                if (File.Exists(CommissionPath + @"Posts.txt")) //формирование списка должностей членов комиссии из файла
                {
                    StreamReader objReader = new StreamReader(CommissionPath + @"Posts.txt", Encoding.Default);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null) CommissPost1.Items.Add(sLine);
                        if (sLine != null) CommissPost2.Items.Add(sLine);
                        if (sLine != null) CommissPost3.Items.Add(sLine);
                    }
                    objReader.Close();
                    CommissPost1.Text = CommissPost1.Items[0].ToString();
                    CommissPost2.Text = CommissPost2.Items[1].ToString();
                    CommissPost3.Text = CommissPost3.Items[2].ToString();
                }
            }            
            #endregion
        }

        private void CreateAct_Click(object sender, EventArgs e) //создание нового акта
        {
            if ((Hardware.Text != "") && (Defect.Text != "") && (Inventarnik.Text != "") && (CommissName1.Text != "") && (CommissName2.Text != "") && (CommissName3.Text != "")
                && (CommissPost1.Text != "") && (CommissPost2.Text != "") && (CommissPost3.Text != "")) //если все необходимые данные введены
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\SavePath.txt", Encoding.Default); //сохранение в папку по умолчанию
                string SavePath = objReader.ReadLine() + Hardware.Text + " " + Inventarnik.Text;
                objReader.Close();
                Create_Excel_Act(SavePath);
                if (File.Exists(SavePath + ".xlsx")) CurrentAct.Text = SavePath + ".xlsx";
            }
            else
            {
                MessageBox.Show("Не все необходимые данные введены!");
            }
        }

        private void AddInAct_Click(object sender, EventArgs e) //добавление в существующий акт
        {
            if ((Hardware.Text != "") && (Defect.Text != "") && (Inventarnik.Text != "") && (CommissName1.Text != "") && (CommissName2.Text != "") && (CommissName3.Text != "")
                && (CommissPost1.Text != "") && (CommissPost2.Text != "") && (CommissPost3.Text != "")) //если все необходимые данные введены
            {
                Add_In_Excel_Act();
            }
            else
            {
                MessageBox.Show("Не все необходимые данные введены!");
            }
        }

        private void SaveHardware_Click(object sender, EventArgs e) //сохранение нового оборудования в список
        {
            if ((Hardware.Items.Contains(Hardware.Text) == false) && (Hardware.Text != "")) //если такого оборудования в списке нет
            {
                Hardware.Items.Add(Hardware.Text); //добавления оборудования в список и запись в файл
                StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Hardware\Hardware.txt", false, Encoding.Default);
                if (Hardware.Items.Count >= 2)
                {
                    for (int i = 0; i < (Hardware.Items.Count - 1); i++)
                    {
                        objWriter.WriteLine(Hardware.Items[i]);
                    }
                }
                objWriter.Write(Hardware.Items[Hardware.Items.Count - 1]);
                objWriter.Close();
                Defects.Items.Clear();
                Defects.Text = "";
            }
            else
            {
                MessageBox.Show("Не введено название оборудования, либо данное оборудование уже есть в списке!");
            }
        }

        private void DeleteHardware_Click(object sender, EventArgs e) //удаление оборудования и списка дефектов для него
        {
            if (Hardware.Items.Contains(Hardware.Text)) //проверка, есть ли такое оборудование в списке
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить оборудование из списка?" + //если такое оборудование в списке есть, вывод диалогового окна
                " Список дефектов для данного оборудования также будет удален!", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (File.Exists(Application.StartupPath + @"\Hardware\" + Hardware.Text + ".txt")) //удаление списка дефектов для удаляемого оборудования
                    {
                        File.Delete(Application.StartupPath + @"\Hardware\" + Hardware.Text + ".txt");
                        Defects.Items.Clear();
                        Defects.Text = "";
                    }
                    Hardware.Items.Remove(Hardware.Text); //удаление оборудования из списка
                    Hardware.Text = "";
                    StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Hardware\Hardware.txt", false, Encoding.Default);
                    if (Hardware.Items.Count >= 2)
                    {
                        for (int i = 0; i < (Hardware.Items.Count - 1); i++)
                        {
                            objWriter.WriteLine(Hardware.Items[i]);
                        }
                    }
                    if (Hardware.Items.Count != 0) objWriter.Write(Hardware.Items[Hardware.Items.Count - 1]);
                    objWriter.Close();
                }
            }
            else
            {
                MessageBox.Show("Не введено название оборудования, либо данного оборудования нет в списке!");
            }
        }

        private void Hardware_SelectedIndexChanged(object sender, EventArgs e) //формирование списка дефектов из файла
        {
            Defects.Text = "";
            Defects.Items.Clear();
            if (File.Exists(HardwarePath + Hardware.Text + ".txt"))
            {
                StreamReader objReader = new StreamReader(HardwarePath + Hardware.Text + ".txt", Encoding.Default);
                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null) Defects.Items.Add(sLine);
                }
                objReader.Close();
            }
        }

        private void SaveDefect_Click(object sender, EventArgs e) //сохранение нового дефекта в список
        {
            if ((Hardware.Items.Contains(Hardware.Text)) && (Defects.Items.Contains(Defects.Text) == false) && (Defects.Text != "")) //если такого дефекта для данного оборудования в списке нет
            {
                Defects.Items.Add(Defects.Text); //добавления дефекта в список и запись в файл
                StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Hardware\" + Hardware.Text + ".txt", false, Encoding.Default);
                if (Defects.Items.Count >= 2)
                {
                    for (int i = 0; i < (Defects.Items.Count - 1); i++)
                    {
                        objWriter.WriteLine(Defects.Items[i]);
                    }
                }
                objWriter.Write(Defects.Items[Defects.Items.Count - 1]);
                objWriter.Close();
            }
            else
            {
                MessageBox.Show("Не введено название дефекта, либо данный дефект уже есть в списке!");
            }
        }

        private void DeleteDefect_Click(object sender, EventArgs e) //удаление дефекта из списка
        {
            if (Defects.Items.Contains(Defects.Text)) //проверка, есть ли уже такой дефект в списке
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить дефект из списка?", "", MessageBoxButtons.YesNo); //если такой дефект в списке есть, вывод диалогового окна
                if (result == DialogResult.Yes)
                {
                    Defects.Items.Remove(Defects.Text); //удаление дефекта
                    Defects.Text = "";
                    StreamWriter objWriter = new StreamWriter(Application.StartupPath + @"\Hardware\" + Hardware.Text + ".txt", false, Encoding.Default);
                    if (Defects.Items.Count >= 2)
                    {
                        for (int i = 0; i < (Defects.Items.Count - 1); i++)
                        {
                            objWriter.WriteLine(Defects.Items[i]);
                        }
                    }
                    if (Defects.Items.Count != 0) objWriter.Write(Defects.Items[Defects.Items.Count - 1]);
                    objWriter.Close();
                    if (Defects.Items.Count == 0) File.Delete(Application.StartupPath + @"\Hardware\" + Hardware.Text + ".txt"); //если дефектов не осталось, удаление файла с дефектами
                }
            }
            else
            {
                MessageBox.Show("Не введено название дефекта, либо данного дефекта нет в списке!");
            }
        }

        private void AddDefect_Click(object sender, EventArgs e) //добавление дефекта из списка в поле дефектов
        {
            if (Defects.Text != "")
            {
                if (Defect.Text == "") Defect.Text += "- " + Defects.Text + ".";
                else Defect.Text += "\n" + "- " + Defects.Text + ".";
            }
        }

        private void ClearDefect_Click(object sender, EventArgs e) //очистка поля дефектов
        {
            Defect.Text = "";
        }

        private void Create_Excel_Act(string PathSave) //формирование акта
        {
            string ShablonPath = "";
            if (File.Exists(Application.StartupPath + @"\Path\ShablonPath.txt")) //если шаблон выбран, использовать его
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\ShablonPath.txt", Encoding.Default);
                ShablonPath = objReader.ReadLine();
                objReader.Close();
            }
            Excel.Application excelapp;
            Excel.Workbook excelappworkbook;
            Excel.Worksheet excelworksheet;
            Excel.Range excelcells;
            excelapp = new Excel.Application();
            try
            {
                excelappworkbook = excelapp.Workbooks.Open(ShablonPath);
                excelworksheet = excelappworkbook.Worksheets.get_Item(1);
                excelcells = excelworksheet.get_Range("B8");
                excelcells.Value2 = Hardware.Text + " " + Nazvanie.Text;
                excelcells = excelworksheet.get_Range("C8");
                excelcells.Value2 = Inventarnik.Text;
                excelcells = excelworksheet.get_Range("D8");
                excelcells.Value2 = Quantity.Value;
                excelcells = excelworksheet.get_Range("F8");
                if (DrMetYes.Checked == true) excelcells.Value2 = "Да";
                if (DrMetNo.Checked == true) excelcells.Value2 = "Нет";
                excelcells = excelworksheet.get_Range("E8");
                excelcells.Value2 = Defect.Text;
                excelcells = excelworksheet.get_Range("B14");
                excelcells.Value2 = CommissPost1.Text;
                excelcells = excelworksheet.get_Range("D14");
                excelcells.Value2 = CommissName1.Text;
                excelcells = excelworksheet.get_Range("B17");
                excelcells.Value2 = CommissPost2.Text;
                excelcells = excelworksheet.get_Range("D17");
                excelcells.Value2 = CommissName2.Text;
                excelcells = excelworksheet.get_Range("B20");
                excelcells.Value2 = CommissPost3.Text;
                excelcells = excelworksheet.get_Range("D20");
                excelcells.Value2 = CommissName3.Text;
                excelappworkbook.SaveAs(PathSave);
                excelappworkbook.Close();
                excelapp.Quit();
                MessageBox.Show("Дефектная ведомость успешно создана!");
            }
            catch
            {
                excelapp.Quit();
            }
            excelcells = null;
            excelworksheet = null;
            excelappworkbook = null;
            excelapp = null;
            GC.Collect();
        }

        private void Add_In_Excel_Act() //добавление в существующий акт
        {
            string FilePath = "";
            if (File.Exists(CurrentAct.Text)) FilePath = CurrentAct.Text; //если файл существует, добавить в него
            else //если файл не выбран, выбрать и сохранить путь к нему
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Выбор дефектной ведомости для добавления данных";
                openDialog.Filter = "Файл Excel|*.xlsx;*.xls";
                openDialog.ShowDialog();
                FilePath = openDialog.FileName;
                if (FilePath != "") CurrentAct.Text = FilePath;
            }
            Excel.Application excelapp;
            Excel.Workbook excelappworkbook;
            Excel.Worksheet excelworksheet;
            Excel.Range excelcells;
            excelapp = new Excel.Application();
            try
            {
                excelappworkbook = excelapp.Workbooks.Open(FilePath);
                excelworksheet = excelappworkbook.Worksheets.get_Item(1);
                int i = 8;
                excelcells = excelworksheet.Cells[i, 1];
                while (excelcells.Value2 != null) //подсчет количества списанного оборудования в акте
                {
                    i++;
                    excelcells = excelworksheet.Cells[i, 1];
                }
                excelcells = excelworksheet.get_Range("A" + i.ToString(), "F" + i.ToString());
                excelcells.Insert(Excel.XlInsertShiftDirection.xlShiftDown, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove);
                excelcells = excelworksheet.get_Range("B" + i.ToString());
                excelcells.Value2 = Hardware.Text + " " + Nazvanie.Text;
                excelcells = excelworksheet.get_Range("C" + i.ToString());
                excelcells.Value2 = Inventarnik.Text;
                excelcells = excelworksheet.get_Range("D" + i.ToString());
                excelcells.Value2 = Quantity.Value;
                excelcells = excelworksheet.get_Range("F" + i.ToString());
                if (DrMetYes.Checked == true) excelcells.Value2 = "Да";
                if (DrMetNo.Checked == true) excelcells.Value2 = "Нет";
                excelcells = excelworksheet.get_Range("E" + i.ToString());
                excelcells.Value2 = Defect.Text;
                for (int m = 1; m <= ((i + 1) - 8); m++) //заполнение номеров
                {
                    excelcells = excelworksheet.Cells[(7 + m), 1];
                    excelcells.Value2 = m;
                }
                excelcells = excelworksheet.get_Range("A" + i.ToString(), "F" + i.ToString());
                excelcells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelappworkbook.Save();
                excelappworkbook.Close();
                excelapp.Quit();
                MessageBox.Show("Данные успешно добавлены в дефектную ведомость!");

            }
            catch
            {
                excelapp.Quit();
            }
            excelcells = null;
            excelworksheet = null;
            excelappworkbook = null;
            excelapp = null;
            GC.Collect();
        }

        private void Clear_Click(object sender, EventArgs e) //очистка всех полей
        {
            Hardware.Text = "";
            Nazvanie.Text = "";
            Inventarnik.Text = "";
            Quantity.Value = 1;
            DrMetNo.Checked = true;
            Defects.Text = "";
            Defects.Items.Clear();
            Defect.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //создание нового акта
        {
            if ((Hardware.Text != "") && (Defect.Text != "") && (Inventarnik.Text != "") && (CommissName1.Text != "") && (CommissName2.Text != "") && (CommissName3.Text != "")
                && (CommissPost1.Text != "") && (CommissPost2.Text != "") && (CommissPost3.Text != "")) //если все необходимые данные введены
            {
                StreamReader objReader = new StreamReader(Application.StartupPath + @"\Path\SavePath.txt", Encoding.Default); //сохранение в папку по умолчанию
                string SavePath = objReader.ReadLine() + Hardware.Text + " " + Inventarnik.Text;
                objReader.Close();
                Create_Excel_Act(SavePath);
                if (File.Exists(SavePath + ".xlsx")) CurrentAct.Text = SavePath + ".xlsx";
            }
            else
            {
                MessageBox.Show("Не все необходимые данные введены!");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) //создание нового акта в выбранной папке
        {
            if ((Hardware.Text != "") && (Defect.Text != "") && (Inventarnik.Text != "") && (CommissName1.Text != "") && (CommissName2.Text != "") && (CommissName3.Text != "")
                && (CommissPost1.Text != "") && (CommissPost2.Text != "") && (CommissPost3.Text != "")) //если все необходимые данные введены
            {
                SaveFileDialog saveDialog = new SaveFileDialog(); //сохранение в выбранную папку
                saveDialog.Title = "Сохранение дефектной ведомости";
                saveDialog.Filter = "Файл Excel|*.xlsx;*.xls";
                saveDialog.ShowDialog();
                string SavePath = saveDialog.FileName;
                Create_Excel_Act(SavePath);
                if (File.Exists(SavePath)) CurrentAct.Text = SavePath;
            }
            else
            {
                MessageBox.Show("Не все необходимые данные введены!");
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) //добавление в существующий акт
        {
            if ((Hardware.Text != "") && (Defect.Text != "") && (Inventarnik.Text != "") && (CommissName1.Text != "") && (CommissName2.Text != "") && (CommissName3.Text != "")
                && (CommissPost1.Text != "") && (CommissPost2.Text != "") && (CommissPost3.Text != "")) //если все необходимые данные введены
            {
                Add_In_Excel_Act();
            }
            else
            {
                MessageBox.Show("Не все необходимые данные введены!");
            }
        }

        private void addInToolStripMenuItem_Click(object sender, EventArgs e) //добавление в выбранный существующий акт
        {
            if ((Hardware.Text != "") && (Defect.Text != "") && (Inventarnik.Text != "") && (CommissName1.Text != "") && (CommissName2.Text != "") && (CommissName3.Text != "")
                && (CommissPost1.Text != "") && (CommissPost2.Text != "") && (CommissPost3.Text != "")) //если все необходимые данные введены
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Выбор дефектной ведомости для добавления данных";
                openDialog.Filter = "Файл Excel|*.xlsx;*.xls";
                openDialog.ShowDialog();
                if (openDialog.FileName != "")
                {
                    CurrentAct.Text = openDialog.FileName;
                    Add_In_Excel_Act();
                }
            }
            else
            {
                MessageBox.Show("Не все необходимые данные введены!");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //отображение окна "О программе"
        {
            AboutForm1 About = new AboutForm1();
            About.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) //отображение окна "Настройки"
        {
            SettingsForm1 Settings = new SettingsForm1();
            Settings.ShowDialog();

            //применение новых настроек
            #region настройка списков оборудования и дефектов
            Hardware.Items.Clear(); Hardware.Text = "";
            Defects.Items.Clear(); Defects.Text = "";

            if (File.Exists(Application.StartupPath + @"\Path\HardwarePath.txt")) //если есть файл с путем к списку оборудования и дефектов
            {
                StreamReader objReader1 = new StreamReader(Application.StartupPath + @"\Path\HardwarePath.txt", Encoding.Default);
                HardwarePath = objReader1.ReadLine();
                objReader1.Close();

                if (File.Exists(HardwarePath + @"Hardware.txt")) //формирование списка оборудования из файла
                {
                    StreamReader objReader2 = new StreamReader(HardwarePath + @"Hardware.txt", Encoding.Default);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = objReader2.ReadLine();
                        if (sLine != null) Hardware.Items.Add(sLine);
                    }
                    objReader2.Close();
                }
            }
            #endregion

            #region настройка списка членов комиссии
            CommissName1.Items.Clear(); CommissName1.Text = "";
            CommissName2.Items.Clear(); CommissName2.Text = "";
            CommissName3.Items.Clear(); CommissName3.Text = "";
            CommissPost1.Items.Clear(); CommissPost1.Text = "";
            CommissPost2.Items.Clear(); CommissPost2.Text = "";
            CommissPost3.Items.Clear(); CommissPost3.Text = "";

            if (File.Exists(Application.StartupPath + @"\Path\CommissionPath.txt")) //если есть файл с путем к списку членов комиссии
            {
                StreamReader objReader1 = new StreamReader(Application.StartupPath + @"\Path\CommissionPath.txt", Encoding.Default);
                CommissionPath = objReader1.ReadLine();
                objReader1.Close();

                if (File.Exists(CommissionPath + @"Names.txt")) //формирование списка имен членов комиссии из файла
                {
                    StreamReader objReader = new StreamReader(CommissionPath + @"Names.txt", Encoding.Default);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null) CommissName1.Items.Add(sLine);
                        if (sLine != null) CommissName2.Items.Add(sLine);
                        if (sLine != null) CommissName3.Items.Add(sLine);
                    }
                    objReader.Close();
                    CommissName1.Text = CommissName1.Items[0].ToString();
                    CommissName2.Text = CommissName2.Items[1].ToString();
                    CommissName3.Text = CommissName3.Items[2].ToString();
                }
                if (File.Exists(CommissionPath + @"Posts.txt")) //формирование списка должностей членов комиссии из файла
                {
                    StreamReader objReader = new StreamReader(CommissionPath + @"Posts.txt", Encoding.Default);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null) CommissPost1.Items.Add(sLine);
                        if (sLine != null) CommissPost2.Items.Add(sLine);
                        if (sLine != null) CommissPost3.Items.Add(sLine);
                    }
                    objReader.Close();
                    CommissPost1.Text = CommissPost1.Items[0].ToString();
                    CommissPost2.Text = CommissPost2.Items[1].ToString();
                    CommissPost3.Text = CommissPost3.Items[2].ToString();
                }
            }        
            #endregion
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) //выход из приложения
        {
            Close();
        }

    }
}
