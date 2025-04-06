using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Proga
{
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        int posX = 0;   
        int posY = 0;   
        int posZ = 0;
        int step = 10;
        private bool sos_act = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmb_com.Items.AddRange(ports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, закрыт ли порт
                if (serial.IsOpen)
                {
                    MessageBox.Show("Порт Открыт. Невозможно выполнить подключение к последовательному порту.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    serial.PortName = cmb_com.SelectedItem.ToString();
                    serial.BaudRate = Convert.ToInt32(cmb_br.Text);
                    serial.DataBits = Convert.ToInt32(cmb_db.Text);
                    serial.StopBits = StopBits.One;
                    serial.Parity = Parity.None;
                    step = int.Parse(cmb_RY.SelectedItem.ToString());
                    serial.Open();
                    posX = 0;
                    posY = 300;
                    posZ = 0;
                    serial.Write("M1112" + "\r"); //\n
                    X.Text = posX.ToString();
                    Y.Text = posY.ToString();
                    Z.Text = posZ.ToString();
                    serial.Write("M1000" + "\r"); //\n
                    label10.Text = "Готова к работе";
                    sos_act = true;


                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            posX = 0;
            posY = 300;
            posZ = 0;
            serial.Write("M1112" + "\r"); //\n
            X.Text = posX.ToString();
            Y.Text = posY.ToString();
            Z.Text = posZ.ToString();
        }

        private void btn_Xb_Click(object sender, EventArgs e)
        {
            if (posX < 209)
            {
                posX += step;
                serial.Write("G0 X" + posX + "\r"); //\n
                X.Text = posX.ToString();
                Y.Text = posY.ToString();
                Z.Text = posZ.ToString();
            }
        }

        private void btn_Xm_Click(object sender, EventArgs e)
        {
            if (posX > 9)
            {
                posX -= step;
                serial.Write("G0 X" + posX + "\r"); //\n
                X.Text = posX.ToString();
                Y.Text = posY.ToString();
                Z.Text = posZ.ToString();
            }

        }

        private void btn_Yb_Click(object sender, EventArgs e)
        {
            if (posY < 299)
            {
                posY += step;
                serial.Write("G0 Y" + posY + "\r"); //\n
                X.Text = posX.ToString();
                Y.Text = posY.ToString();
                Z.Text = posZ.ToString();
            }
        }

        private void btn_Ym_Click(object sender, EventArgs e)
        {
            if (posY > 9)
            {
                posY -= step;
                serial.Write("G0 Y" + posY + "\r"); //\n
                X.Text = posX.ToString();
                Y.Text = posY.ToString();
                Z.Text = posZ.ToString();
            }

        }

        private void btn_Zb_Click(object sender, EventArgs e)
        {
            if (posZ < 299)
            {
                posZ += step;
                serial.Write("G0 Z" + posZ + "\r"); //\n
                X.Text = posX.ToString();
                Y.Text = posY.ToString();
                Z.Text = posZ.ToString();
            }
        }

        private void btn_Zm_Click(object sender, EventArgs e)
        {
            if (posZ > 9)
            {
                posZ -= step;
                serial.Write("G0 Z" + posZ + "\r"); //\n
                X.Text = posX.ToString();
                Y.Text = posY.ToString();
                Z.Text = posZ.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Write("M1112" + "\r"); //\n
            serial.Close();
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, открыт ли порт
                if (serial.IsOpen)
                {
                    // Закрываем порт
                    posX = 0;
                    posY = 300;
                    posZ = 0;
                    serial.Write("M1112" + "\r"); //\n
                    X.Text = "";
                    Y.Text = "";
                    Z.Text = "";
                    serial.Write("M1003" + "\r"); //\n
                    label10.Text = "";
                    sos_act = false;
                    serial.Close();
                    MessageBox.Show("Порт успешно закрыт.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Порт уже закрыт.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                // Обработка ошибок
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_STOP_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, открыт ли порт
                if (serial.IsOpen)
                {
                    // Отправляем команду экстренного торможения
                    X.Text = "";
                    Y.Text = "";
                    Z.Text = "";
                    label10.Text = "";
                    serial.Write("M112" + "\r"); //\n
                    serial.Write("M1003" + "\r"); //\n
                    sos_act = false;
                    MessageBox.Show("Экстренное торможение выполнено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Порт закрыт. Невозможно выполнить экстренное торможение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                // Обработка ошибок
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_db_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_br_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sos_act == true) 
            {
                // Активация присоски
                serial.Write("M1001" + "\r"); //\n
                label10.Text = "Активно";
            }
            else
            {
                // Инициализация присоски
                serial.Write("M1000" + "\r"); //\n
                label10.Text = "Готова к работе";
                sos_act = true; 
            }
        }

            private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            serial.Write("M1002" + "\r"); //\n
            label10.Text = "Выключено";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serial.Write("M1003" + "\r"); //\n
            label10.Text = "Остановлено";
            sos_act = false;    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                if (int.TryParse(txt_X.Text, out int x) &&
                    int.TryParse(txt_Y.Text, out int y) &&
                    int.TryParse(txt_Z.Text, out int z))
                {
                    if (x <= 0 || x > 300 ||
                        y <= 0 || y > 300 ||
                        z <= 0 || z > 300)
                    {
                        MessageBox.Show("Координаты должны быть положительными и меньше чем 300.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    posX = x;
                    posY = y;
                    posZ = z;

                    serial.Write($"G0 X{posX} Y{posY} Z{posZ}\r"); //\n

                    X.Text = posX.ToString();
                    Y.Text = posY.ToString();
                    Z.Text = posZ.ToString();

                }
                else
                {
                    MessageBox.Show("Введите корректные значения для X, Y и Z.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

