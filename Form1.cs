using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forum_12_12_2022_input_output_file
{
    public partial class Form1 : Form
    {
        public bool result = false;
        string? fileText = null;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }
        private void button1_Click(object sender, EventArgs e) // TODO «ј√–”«»“№ ‘ј…Ћ
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            fileText = System.IO.File.ReadAllText(filename);
            for (int i = 0; i < fileText.Length; i++)
            {
                progressBar1.PerformStep();
            }
            button2.Enabled = true;
            button3.Enabled = true;
            // MessageBox.Show("‘айл открыт");
        }

        private void button2_Click(object sender, EventArgs e) // TODO показать файл в другой форме
        {
            Form2 form2 = new Form2(fileText);
            form2.ShowDialog();

            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e) // »зменение скорости загрузки
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = fileText.Length;
        }
        private void Download_Popup(object sender, PopupEventArgs e) // подсказки загрузки
        {

        }
        private void Save_Popup(object sender, PopupEventArgs e) // подсказки сохранение
        {

        }

        private void Progress_Popup(object sender, PopupEventArgs e) // подсказки статус программы, скорость
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // загрузка файла системное
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // сохранение файла системное
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            string one, two;

            string[] comp = fileText.Split("\r\n"); // разделение файла по строкам и добавл€ем в массив
            List<string> list = new List<string>(); // список дл€ записи имени кабел€ [0] будут дубликаты
            List<string> list_no_du = new List<string>(); // список без дубликатов
            foreach (var item in comp)      // проходим по всему файлу, который в переменной fileText
            {
                string comp1 = item;
                string[] comp2 = comp1.Split("\t"); // делим строку на две части и добавл€ем в массив
                list.Add(comp2[0]);                 // добавл€ем в список только [0]- элемент, им€ кабел€
                
            }
            foreach (var item in list)
            {
                list_no_du = list.Distinct().ToList(); // удал€ем дубликаты из списка, будем использовать дл€ поиска
            }
            // result false
            for (int i = 0, k =1; i < comp.Length; i++)
            {
                //string compProv = comp[i];
                result = comp[i].Contains(list_no_du[k]); // искома€ подстрока

                if (result == true) // если нашли то   true
                {
                    textBox1.Text += comp[i] + " " + "нашел\r\n"; // делаем определенные действи€ со строкой
                }
            }
            //result = phrase.Contains("brown fox");      // result true
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // дл€ разбивки текстовой строки массивами чаров
        void Spl()
        {
            string str = null;
            string[] strArr = null;
            int count = 0;
            str = "Welcome to CSharp split test scenario";
            char[] splitchar = { 'W', 'C', 'o' };
            strArr = str.Split(splitchar);
            for (count = 0; count <= strArr.Length - 1; count++)
            {
                textBox1.Text += (strArr[count] + "\r\n");
            }
        }
        
    }
}