//https://github.com/mooict/Side-Scrolling-Platform-game-in-Windows-Form/blob/main/Side%20Scrolling%20Game%20MOO%20ICT/Form1.Designer.cs


namespace Attempt2
{
    public partial class Form1 : Form
    {
        int score;
        bool goLeft;
        bool goRight;
        List<bool> treeMap = new List<bool>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            StartGame();
        }
        public void StartGame()
        {
            treeMap.Clear();
            for (int i = 0; i < 5; i++)
            {
                if (random.Next(1, 3) == 1)
                    treeMap.Add(true);
                else
                    treeMap.Add(false);
            }
            score = 0;
            UpdateDisplay();
        }
        public void UpdateDisplay()
        {
            PnlBranches.Controls.Clear();
            for (int i = 0; i < treeMap.Count; i++)
            {
                Panel p = new Panel();
                p.BackColor = Color.Brown;
                p.Size = new Size(100, 20);
                if (treeMap[i])
                {
                    p.Location = new Point(0, 200 - i * 50);
                }
                else
                {
                    p.Location = new Point(200, 200 - i * 50);
                }
                PnlBranches.Controls.Add(p);
                p.BringToFront();
            }
        }
        public void MainEvent(object sender, EventArgs e)
        {
            if (goRight || goLeft)
            {
                if (goLeft && !treeMap[0])
                {
                    score++;
                    treeMap.RemoveAt(0); 
                    if (random.Next(1, 3) == 1)
                        treeMap.Add(true);
                    else
                        treeMap.Add(false);
                    PbxLumberJack.Location = new Point(185, 291);
                }
                else if (goRight && treeMap[0])
                {
                    score++;
                    treeMap.RemoveAt(0); 
                    if (random.Next(1, 3) == 1)
                        treeMap.Add(true);
                    else
                        treeMap.Add(false);
                    PbxLumberJack.Location = new Point(430, 291);
                }
                else
                {
                    MessageBox.Show("You Lost!\nYour score was " + score);
                    StartGame();
                }
            }
            
            goLeft = false;
            goRight = false;
            LblScore.Text = score.ToString();
            UpdateDisplay();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            MainEvent(sender, e);
        }
    }
}