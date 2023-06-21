namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Button[] B;
        public Form1()
        {
            InitializeComponent();
            B = new Button[16] ;
            B[0] = button1;
            B[1] = button2;
            B[2] = button3;
            B[3] = button4;
            B[4] = button5;
            B[5] = button6;
            B[6] = button7;
            B[7] = button8;
            B[8] = button9;
            B[9] = button10;
            B[10] = button11;
            B[11] = button12;
            B[12] = button13;
            B[13] = button14;
            B[14] = button15;
            B[15] = button16;
            CheckWin();
        }
       
        private void CheckWin()
        {
            timer1.Start();
            bool win = true;
            for (int i = 0; i < 15; i++)
            {
                if (B[i].Text != (i + 1).ToString())
                {
                    win = false;
                    break;
                }
            }
            if (win)
            {
                //private void Form1_Load(object sender, EventArgs e)
                //{
                //    Timer timer = new Timer();
                //    timer.Interval = 1000; // интервал в миллисекундах
                //    timer.Enabled = true; // включаем таймер
                //    timer.Tick += new EventHandler(timer_Tick); // добавляем обработчик события Tick
                //}

                MessageBox.Show("Поздравляем! Вы выиграли! " );
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button click= (Button)sender;
            int num = (int) Convert.ToInt16(click.Tag.ToString());
            num = num - 1;
            int y = num / 4;
            int x = num - y * 4;
            int ytop, ybottom;
            int xleft, xright;
            ytop = y - 1;
            ybottom = y + 1;
            xleft= x - 1;
            xright = x + 1;
            if (xright < 4)
            {
                int numr = y * 4 + xright;
                if (!B[numr].Visible)
                {
                    B[numr].Visible = true;
                    B[num].Visible = false;
                    B[numr].Text = B[num].Text;
                }
            }
            if (xleft >=0)
            {
                int numl=y*4 + xleft;
                if (!B[numl].Visible)
                {
                    B[num].Visible = false;
                    B[numl].Visible = true;
                    B[numl].Text = B[num].Text;
                }
            }  
            if (ytop >=0)
            {
                int numt=ytop*4+x;
                if (!B[numt].Visible)
                {
                    B[numt].Visible = true;
                    B[num].Visible=false;
                    B[numt].Text = B[num].Text;
                }
            }
            if (ybottom<4)
            { 
                int numb=ybottom*4+x;
                if (!B[numb].Visible)
                { 
                    B[numb].Visible = true;
                    B[num].Visible = false; 
                    B[numb].Text= B[num].Text;
                }
            }
            
        }


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    Timer timer = new Timer();
        //    timer.Interval = 1000; // интервал в миллисекундах
        //    timer.Enabled = true; // включаем таймер
        //    timer.Tick += new EventHandler(timer_Tick); // добавляем обработчик события Tick
        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    // выполняем необходимые действия
        //   label1.Text = DateTime.Now.ToString();
        //}


        private void button17_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random rnd = new Random();
            for (int i = 15- 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = B[j].Text;
                B[j].Text = B[i].Text;
                B[i].Text = temp;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}