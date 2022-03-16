using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalGame
{
    

    public partial class ReplacingBooksControl : UserControl
    {

        
        static Random random = new Random();
        public List<decimal> DeweyNumListUnsorted = new List<decimal>();
        public List<decimal> DeweyNumListSorted = new List<decimal>();
        public int Score;
        public int UserXP;
        public bool HasAnswerBeenCheacked = false;

        public ReplacingBooksControl()
        {
            InitializeComponent();
            SetUserStats();
            this.listBox1.AllowDrop = true;
            lbl_GameMode.Text = UserData.GameMode;
            Console.WriteLine(UserData.GameMode);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            DeweyNumListSorted.Clear();
            DeweyNumListUnsorted.Clear();
            listBox2.Visible = false;
            HasAnswerBeenCheacked = false;
            DeweyNumberGenerator();
            AskToPlayGame();///
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HasAnswerBeenCheacked == true)
            {

            }
            else
            {
                listBox2.Items.Clear();
                DeweyNumListSorted.Clear();
                DeweyNumListUnsorted = listBox1.Items.Cast<decimal>().ToList();
                DeweyNumListSorted = DeweyNumListUnsorted.OrderBy(number => number).ToList();

                foreach (var item in DeweyNumListSorted)
                {
                    listBox2.Items.Add(item);
                }
                listBox2.Visible = true;

                bool ListMatch = DeweyNumListUnsorted.SequenceEqual(DeweyNumListSorted);
                if (ListMatch == true)
                {
                    UserData userdata = new UserData();
                    UserXP = userdata.SetUserXP(UserData.UserID, UserData.UserXP + 10);
                    Score = Score + 10;
                    lbl_Score.Text = Score.ToString();
                    SetUserStats();
                    AskToPlayGame();
                }
                else
                {
                    Score = Score - 10;
                    lbl_Score.Text = Score.ToString();
                }
                HasAnswerBeenCheacked = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            HasAnswerBeenCheacked = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            DeweyNumListSorted.Clear();
            DeweyNumListUnsorted.Clear();
            DeweyNumberGenerator();
        }

        

        private void DeweyNumberGenerator() {
            for (int i = 0; i <= 10; i++)
            {
                decimal deweyNumber = random.Next(0,999);
                if (deweyNumber <= 9)
                {
                    deweyNumber = deweyNumber * 100;
                }else 
                if (deweyNumber <= 99)
                {
                    deweyNumber = deweyNumber * 10;
                }
                this.listBox1.Items.Add(deweyNumber);
            }
            
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = this.listBox1.IndexFromPoint(point);
            if (index < 0) index = this.listBox1.Items.Count - 1;
            object data = e.Data.GetData(typeof(decimal));
            this.listBox1.Items.Remove(data);
            this.listBox1.Items.Insert(index, data);
        }

        public void SetUserStats()
        {


            UserData userdata = new UserData();
            lbl_Username.Text = UserData.Username;
            lbl_lvl.Text = userdata.GetUserLvl(UserData.UserID).ToString();
            lbl_XPvalue.Text = userdata.GetUserXP(UserData.UserID).ToString();
            int PB_MAX = userdata.GetLvlMax(UserData.UserLevel); ;
            int PB_VALUE = userdata.GetUserXP(UserData.UserID); ;
            PB_XP.Maximum = 100;
            PB_XP.Value = 100 - (PB_MAX - PB_VALUE);

            //Console.WriteLine(PB_MAX);
            //Console.WriteLine(PB_VALUE);
            //Console.WriteLine( 100 - (PB_MAX - PB_VALUE));
            //Console.WriteLine(UserData.Username);
        }

        public void AskToPlayGame()
        {

            DialogResult res = MessageBox.Show("Well Done!" + "\n" 
                +"Would You Like To Play A Side Mission?", "Play Side Game", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                RockPaperScissorsForm fr2 = new RockPaperScissorsForm();
                fr2.Show();
            }
            if (res == DialogResult.Cancel)
            {
               
            }


        }

        private void btn_EndGame_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            if (panel != null)
            {
                panel.Controls.RemoveByKey("ReplacingBooksControl");
                UserStatsControl userStatsControl = new UserStatsControl();
                panel.Controls.Add(userStatsControl);

            }
        }
    }
}
