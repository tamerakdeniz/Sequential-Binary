namespace binaryarama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // YAZILAN PROGRAM'DA YILMAZ KOÇAK TARAFINDAN HAZIRLANAN DERS İÇERİĞİ REFERANS ALINMIŞTIR.




        int elemanSayısı;
        int[] dizi1;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("YAZILAN PROGRAM'DA YILMAZ KOÇAK TARAFINDAN HAZIRLANAN DERS İÇERİĞİ REFERANS ALINMIŞTIR.");
            MessageBox.Show("Sıralı Arama ve İkili Arama Üzerine Yazılmıştır.");
            label3.Text = ("----------------------------------------------------");
            label4.Text = ("");
            label5.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elemanSayısı = int.Parse(textBox1.Text);
            dizi1 = new int[elemanSayısı];
            
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] =
                int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ". elemanı giriniz", "DİZİ ELEMANLARI", "", 50, 50));
                label4.Text += dizi1[i] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            int bulundu = 0, ct = 0; int aranan = int.Parse(textBox4.Text); while ((aranan != dizi1[ct]) && (ct < dizi1.Length - 1)) ct++;
            if (dizi1[ct] == aranan)
            {
                bulundu = ct; listBox1.Items.Add("Aranan " + "'" + textBox4.Text + "'" + " Değeri " + (bulundu + 1).ToString() + ".Sırada Bulundu.");
            }
            else
                listBox1.Items.Add("Aranan " + "'" + textBox4.Text + "'" + " Değeri Bulunamadı.");
            listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox1.Clear();
            label4.Text = ("");
            label5.Text = ("");
            textBox4.Clear();
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (int i = 0; i < dizi1.Length - 1; i++)
                for (int j = 0; j < dizi1.Length - i - 1; j++) 
                    if (dizi1[j] > dizi1[j + 1])
                    {
                        int yedek = dizi1[j]; 
                        dizi1[j] = dizi1[j + 1]; 
                        dizi1[j + 1] = yedek;
                    }
            for (int i = 0; i < dizi1.Length; i++)
                label5.Text += dizi1[i] + " ";
            listBox2.Items.Clear();
            listBox2.Items.Add("=================================================================================");
            listBox2.Items.Add("Listeye Eklediğiniz Eleman Dizisi = " + label4.Text + " Şeklindedir.");
            listBox2.Items.Add("---------------------------------------------------------------------------------");
            listBox2.Items.Add("Eleman Dizisinin Sıralanmış Hali = " + label5.Text + " Şeklindedir.");
            listBox2.Items.Add("=================================================================================");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("=================================================================================");
            listBox2.Items.Add("Listeye Eklediğiniz Eleman Dizisi = " + label4.Text + " Şeklindedir.");
            listBox2.Items.Add("=================================================================================");
        }
    }
}