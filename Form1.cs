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
        private void button1_Click(object sender, EventArgs e) // TODO ��������� ����
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // �������� ��������� ����
            string filename = openFileDialog1.FileName;
            // ������ ���� � ������
            fileText = System.IO.File.ReadAllText(filename);
            for (int i = 0; i < fileText.Length; i++)
            {
                progressBar1.PerformStep();
            }
            button2.Enabled = true;
           // MessageBox.Show("���� ������");
        }

        private void button2_Click(object sender, EventArgs e) // TODO �������� ���� � ������ �����
        { 
           Form2 form2= new Form2( fileText);
            form2.ShowDialog();
            
            this.Close();  
        }

        private void progressBar1_Click(object sender, EventArgs e) // ��������� �������� ��������
        {
           progressBar1.Minimum= 0;
            progressBar1.Maximum= fileText.Length;
        }
        private void Download_Popup(object sender, PopupEventArgs e) // ��������� ��������
        {

        }
        private void Save_Popup(object sender, PopupEventArgs e) // ��������� ����������
        {

        }

        private void Progress_Popup(object sender, PopupEventArgs e) // ��������� ������ ���������, ��������
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // �������� ����� ���������
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) // ���������� ����� ���������
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string one, two;
            string [] comp = fileText.Split("\r\n"); // ���������� ����� �� �������
           
              // result false
            for (int i = 0; i < comp.Length; i++)
            {
                
            
                //string compProv = comp[i];
                result = comp[i].Contains("701-K2"); // ������� ���������

                if (result == true) // ���� ����� ��   true
                {
                    textBox1.Text += comp[i] +  " "+ "�����\r\n"; // ������ ������������ �������� �� �������
                }
            }
            //result = phrase.Contains("brown fox");      // result true
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        // ��� �������� ��������� ������ ��������� �����
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