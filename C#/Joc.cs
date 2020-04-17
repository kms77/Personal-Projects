using System;
using System.Windows.Forms;

namespace Atractii_turistice
{
    public partial class Joc : Form
    {
        int timeSec, timeMin, timeH;
        bool isActive,Haveimage,ok=false;
        public Joc()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        public void FinishGame()
        {
            MessageBox.Show("Felicitări !"+"\n"+"Ai terminat jocul în:"+ "\n"+"Ore: "+timeH +"\n"+"Minute: "+timeMin +"\n"+"Secunde: "+ timeSec,"Puzzle terminat",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isActive = false;
            var ofd = new OpenFileDialog
            {
                Filter = "Graphics Files|*.jpg;*.gif;*.png|All Files|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                timeSec = 0;
                timeMin = 0;
                timeH = 0;
                isActive = true;
                Haveimage = true;
                ok = true;
                Functions.LoadPicture(ofd.FileName, puzzleImage, this);
            }
            else
                if(Haveimage)
                   isActive = true;
        }

        private void Joc_Load(object sender, EventArgs e)
        {
            timeSec = 0;
            timeMin = 0;
            timeH = 0;
            isActive = false;
            Haveimage = false;
        }

        
        private void SelectMode(object sender,EventArgs e)
        {
            var mode = (ToolStripMenuItem) sender;
            if (mode != easyModeToolStripMenuItem)
            {
                Functions._targetSize = 100;
                if(ok)
                {
                    timeSec = 0;
                    timeMin = 0;
                    timeH = 0;
                    isActive = true;
                    Haveimage = true;
                }
            }
            else
            {
                Functions._targetSize = 200;
                if (ok)
                {
                    timeSec = 0;
                    timeMin = 0;
                    timeH = 0;
                    isActive = true;
                    Haveimage = true;
                }
            }
            Functions.StartGame(puzzleImage);
        }
        private void puzzleImage_MouseDown(object sender, MouseEventArgs e)
        {
            Functions._movingPiece = null;
            foreach (var piece in Functions._pieces)
            {
                if (!piece.IsTHePieceHome() && piece.Contains(e.Location))
                    Functions._movingPiece = piece;
            }
            if (Functions._movingPiece == null)
                return;
            Functions._movingPoint = e.Location;
            Functions._pieces.Remove(Functions._movingPiece);
            Functions._pieces.Add(Functions._movingPiece);
            Functions.MakeBackground(puzzleImage);
        }
        private void puzzleImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (Functions._movingPiece == null)
                return;
            int dx = e.X - Functions._movingPoint.X;
            int dy = e.Y - Functions._movingPoint.Y;
            Functions._movingPiece._currentLocation.X += dx;
            Functions._movingPiece._currentLocation.Y += dy;
            Functions._movingPoint = e.Location;
            Functions.DrawBoard(puzzleImage);
        }
        private void puzzleImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (Functions._movingPiece == null)
                return;
            if (Functions._movingPiece.IsThePieceCloseToHome())
            {
                Functions._pieces.Remove(Functions._movingPiece);
                Functions._pieces.Reverse();
                Functions._pieces.Add(Functions._movingPiece);
                Functions._pieces.Reverse();
                Functions._gameOver = true;
                foreach (var piece in Functions._pieces)
                {
                    if (piece.IsThePieceCloseToHome())
                        continue;
                    Functions._gameOver = false;
                    break;
                }
            }
            Functions._movingPiece = null;
            Functions.MakeBackground(puzzleImage);
            Functions.DrawBoard(puzzleImage);
            if (Functions._gameOver)
            {
                isActive = false;
                Haveimage = false;
                FinishGame();
            }
        }
        private void EasyModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AskPermission(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ești sigur că vrei să ieși ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Meniu f = new Meniu();
                f.Show();
                this.Hide();
            }
            else
            {
                if(Haveimage)
                  isActive = true;               
            } 
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isActive = false;
            AskPermission(sender, e as FormClosingEventArgs);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSec++;
                if (timeSec >60)
                {
                    timeMin++;
                    timeSec = 0;
                    if (timeMin > 60)
                    {
                        timeH++;
                        timeMin = 0;
                    }
                }
            }
            DrawTime();
        }
        private void DrawTime()
        {
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);
            lblHor.Text = String.Format("{0:00}", timeH);
        }
        private void PuzzleImage_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
