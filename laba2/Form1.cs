using System.Globalization;
using System.IO;


namespace laba2
{
    public partial class Form1 : Form
    {
        t_T[] times = new t_T[1000];

        int[] num = new int[] { };
        int Q;
        struct t_T
        {
            public int t;
            public int T;
        }

        int[] BT_SJF = new int[1000];
        string[] names_SJF = new string[1000];

        int[] BT_PSJF = new int[1000];
        string[] names_PSJF = new string[1000];

        int[] BT_RRPSJF = new int[1000];
        string[] names_RRPSJF = new string[1000];
        //int[] T = new int[1000];

        int ind = 0;
        int mini;
        int maxi;
        Queue<int> queue = new Queue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        //кнопка "Добавить процесс" в RR
        private void button1_Click(object sender, EventArgs e)
        {
            Q = Convert.ToInt32(textBox3.Text);
            int a = Convert.ToInt32(textBox1.Text);
            if (a > 0 & Q > 0) num = num.Append(a).ToArray();
            else Console.WriteLine("Введите натуральные числа");
            textBox3.Clear();
            textBox1.Clear();
        }

        //кнопка "Очистить" в RR
        private void button2_Click(object sender, EventArgs e)
        {
            Array.Clear(times);
            Array.Resize(ref num, 0);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        //кнопка "Вычислить параметры" в RR
        private void button3_Click(object sender, EventArgs e)
        {
            RR();
        }

        //кнопка "Вычислить параметры" в SJF
        private void button4_Click(object sender, EventArgs e)
        {

            SJF();
            /*string temp = "";
            for (int i=0;i<10;i++)
            {
                temp += " " + Convert.ToString(times[i].T) + " ";
            }
            label5.Text = temp;
            /*temp = "";
            for (int i = 0; i < 10; i++)
            {
                temp += " " + names_SJF[i] + " ";
            }
            label6.Text = temp;*/
        }

        //кнопка "Очистить" в SJF
        private void button5_Click(object sender, EventArgs e)
        {
            Array.Clear(times);
            Array.Clear(BT_SJF);
            Array.Clear(names_SJF);
            ind = 0;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }

        //кнопка "Добавить процесс" в SJF
        private void button6_Click(object sender, EventArgs e)
        {
            int B = Convert.ToInt32(textBox4.Text); // добавить длительность выполнения
            int A = Convert.ToInt32(textBox2.Text); // добавить время прибытия
            if (A >= 0 & B > 0)
            {
                BT_SJF[A] = B;
                times[ind].t = B;
                names_SJF[A] = $"p{ind + 1}";
                ind++;
            }
            else Console.WriteLine("Введите натуральные числа");
            textBox2.Clear();
            textBox4.Clear();
        }

        void print_to_file()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\annak\\Documents\\Аннушка\\Учеба\\Операционки\\Test.txt");
                for (int i = 0; i < 1000; i++)
                {
                    if (times[i].t != 0)
                    {
                        double tt = times[i].t;
                        double TT = times[i].T;
                        double M = TT - tt;
                        double R = tt / TT;
                        double P = TT / tt;
                        sw.WriteLine($"t{i + 1} = {tt} T{i + 1} = {TT} M{i + 1} = {M} R{i + 1} = {R} P{i + 1} = {P} ");
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        void RR()
        {
            for (int i = 1; i <= num.Sum(); i++)
            {
                dataGridView1.Columns.Add($"{i}", $"{i}");
            }

            int k = 0;
            int summa_0 = num.Sum();

            for (int i = 0; i < num.Length; i++)
            {
                times[i].t = num[i];
            }

            while (num.Sum() > Q)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] > Q)
                    {
                        for (int j = k; j < k + Q; j++)
                        {
                            dataGridView1.Rows[0].Cells[j].Value = ($"p{i + 1}");
                        }
                        num[i] -= Q;
                        k += Q;
                    }
                    else
                    {
                        for (int j = k; j < k + num[i]; j++)
                        {
                            dataGridView1.Rows[0].Cells[j].Value = ($"p{i + 1}");
                            times[i].T = j + 1;
                        }
                        k += num[i];
                        num[i] = 0;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = summa_0 - num.Sum(); j < summa_0 - num.Sum() + num[i]; j++)
                {
                    dataGridView1.Rows[0].Cells[j].Value = ($"p{i + 1}");
                    times[i].T = j + 1;
                }
                num[i] = 0;
            }
            print_to_file();
        }

        void SJF()
        {
            for (int i = 1; i <= BT_SJF.Sum(); i++)
            {
                dataGridView2.Columns.Add($"{i}", $"{i}");
            }
            int ind_sum = 0;
            mini = BT_SJF[0];
            int k = 0;

            while (BT_SJF.Sum() > 0)
            {
                BT_SJF[k] = 0;
                times[Convert.ToInt32(names_SJF[k].Substring(1)) - 1].T = ind_sum;
                for (int i = ind_sum; i < ind_sum + mini; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = names_SJF[k];
                    if (BT_SJF[i] != 0) queue.Enqueue(BT_SJF[i]);
                }
                ind_sum += mini;
                if (queue.Count != 0)
                {
                    mini = queue.ToArray().Min();
                    k = Array.IndexOf(BT_SJF, mini);
                }
                else if (BT_SJF.Sum() > 0)
                {
                    k++;
                    while (BT_SJF[k] == 0)
                    {
                        k++;
                    }
                    mini = BT_SJF[k];
                }
                int queueCount = queue.Count; // запоминаем длину очереди

                for (int i = 0; i < queueCount; i++)
                {
                    int currentElement = queue.Dequeue(); // каждый раз удаляем первый элемент в очереди и запоминаем его.

                    if (currentElement != mini) // если значение этого первого элемента не то, которое нужно удалить, 
                    {
                        queue.Enqueue(currentElement); // то добавляем этот элемент обратно в очередь (в её конец).
                    }
                }
            }
            for (int i = 0; i < 1000; i++)
            {
                times[i].T += times[i].t;
            }
            print_to_file();
        }
        void PSJF()
        {
            for (int j = 0; j < BT_PSJF.Sum(); j++)
            {
                dataGridView3.Columns.Add($"j{j}", $"j{j}");
            }

            int i1 = 0;
            int i2 = 1;
            int ind = 0;
            while (i2 <= maxi)
            {
                while (BT_PSJF[i1] == 0) i1++;
                while (BT_PSJF[i2] == 0 && i2 <= maxi) i2++;
                if ((BT_PSJF[i1] - (i2 - i1) >= BT_PSJF[i2] || BT_PSJF[i1] - (i2 - i1) == 0 || BT_PSJF[i1] <= (i2 - i1)))
                {
                    if (BT_PSJF[i1] <= (i2 - i1)) // если за это время не появилось процесса с меньшей длительностью
                    {
                        for (int j = ind; j < ind + BT_PSJF[i1]; j++)
                        {
                            dataGridView3.Rows[0].Cells[j].Value = names_PSJF[i1];
                        }
                        ind += BT_PSJF[i1];
                    }
                    else // обычное прерывание
                    {
                        for (int j = ind; j < i2; j++)
                        {
                            dataGridView3.Rows[0].Cells[j].Value = names_PSJF[i1];
                        }
                        ind += (i2 - i1);
                    }

                    times[Convert.ToInt32(names_PSJF[i1].Substring(1)) - 1].T = ind;
                    if (BT_PSJF[i1] - (i2 - i1) > 0) BT_PSJF[i1] -= (i2 - i1);
                    else BT_PSJF[i1] = 0;
                    i1 = i2;
                }
                else i2++;
                while (BT_PSJF.Sum() > 0)
                {
                    int mini = minim();
                    for (int j = ind; j < ind + mini; j++)
                    {
                        dataGridView3.Rows[0].Cells[j].Value = names_PSJF[Array.IndexOf(BT_PSJF, mini)];
                    }
                    ind += mini;
                    times[Convert.ToInt32(names_PSJF[Array.IndexOf(BT_PSJF, mini)].Substring(1)) - 1].T = ind;
                    BT_PSJF[Array.IndexOf(BT_PSJF, mini)] = 0;
                }

                print_to_file();
                Array.Clear(times);
                Array.Clear(BT_PSJF);
                Array.Clear(names_PSJF);
                ind = 0;

                int minim()
                {
                    int m = 100000;
                    for (int i = 0; i <= maxi; i++)
                    {
                        if (BT_PSJF[i] != 0)
                        {
                            m = Math.Min(BT_PSJF[i], m);
                        }
                    }
                    return m;
                }

            }
        }
        void RR_SJF()
        {
            for (int j = 0; j < BT_RRPSJF.Sum(); j++)
            {
                dataGridView4.Columns.Add($"{j}", $"{j}");
            }
            int i1 = 0;
            int i2 = 1;
            int ind = 0;
            while (i2 <= maxi)
            {
                while (BT_RRPSJF[i1] == 0) i1++;
                while (BT_RRPSJF[i2] == 0 && i2 <= maxi) i2++;
                if ((i2 - i1) >= Q || (BT_RRPSJF[i1] - (i2 - i1) >= BT_RRPSJF[i2] || BT_RRPSJF[i1] - (i2 - i1) == 0 || BT_RRPSJF[i1] <= (i2 - i1)))
                {
                    if (BT_RRPSJF[i1] <= (i2 - i1)) // если за это время не появилось процесса с меньшей длительностью
                    { // то выполнить нынешний
                        for (int j = ind; j < ind + BT_RRPSJF[i1]; j++)
                        {
                            dataGridView4.Rows[0].Cells[j].Value = names_RRPSJF[i1];
                        }
                        ind += BT_RRPSJF[i1];
                    }
                    else // обычное прерывание
                    {
                        for (int j = ind; j < i2; j++)
                        {
                            dataGridView4.Rows[0].Cells[j].Value = names_RRPSJF[i1];
                        }
                        ind += (i2 - i1);
                    }
                    times[Convert.ToInt32(names_RRPSJF[i1].Substring(1)) - 1].T = ind;
                    if (BT_RRPSJF[i1] - (i2 - i1) >= 0) BT_RRPSJF[i1] -= (i2 - i1);
                    else BT_RRPSJF[i1] = 0;
                    i1 = i2;
                }
                else i2++;
            }

            while (BT_RRPSJF.Sum() > 0)
            {
                int mini = minim();
                if (mini > Q)
                {
                    for (int j = ind; j < ind + Q; j++)
                    {
                        dataGridView4.Rows[0].Cells[j].Value = names_RRPSJF[Array.IndexOf(BT_RRPSJF, mini)];
                    }
                    BT_RRPSJF[Array.IndexOf(BT_RRPSJF, mini)] -= Q;
                    ind += Q;
                }
                else
                {
                    for (int j = ind; j < ind + mini; j++)
                    {
                        dataGridView4.Rows[0].Cells[j].Value = names_RRPSJF[Array.IndexOf(BT_RRPSJF, mini)];
                        times[Array.IndexOf(BT_RRPSJF, mini)].T = j;
                    }
                    ind += mini;
                    times[Convert.ToInt32(names_RRPSJF[Array.IndexOf(BT_RRPSJF, mini)].Substring(1)) - 1].T = ind;
                    BT_RRPSJF[Array.IndexOf(BT_RRPSJF, mini)] = 0;
                }
            }
            print_to_file();
            Array.Clear(times);
            Array.Clear(BT_RRPSJF);
            Array.Clear(names_RRPSJF);
            ind = 0;
        }

    }
}