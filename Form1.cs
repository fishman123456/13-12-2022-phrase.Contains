using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forum_12_12_2022_input_output_file
{
    public partial class Form1 : Form
    {
        public bool result = false;
        string? fileText =null;
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
           // MessageBox.Show("‘айл открыт");
        }

        private void button2_Click(object sender, EventArgs e) // TODO показать файл в другой форме
        { 
           Form2 form2= new Form2( fileText);
            form2.ShowDialog();
            
            this.Close();  
        }

        private void progressBar1_Click(object sender, EventArgs e) // »зменение скорости загрузки
        {
           progressBar1.Minimum= 0;
            progressBar1.Maximum= fileText.Length;
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
            string [] comp = fileText.Split("\n");
            

            //result = phrase.Contains("brown fox");      // result true
            result = comp.Contains("lazy fox.");      // result false
            if (result = true)
            {
                textBox1.Text += "12";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}