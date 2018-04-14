using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class FormGame : Form
    {
        int SoDia, ChieuCaoDia, ChieuRongDia, Dolech, X_A, X_B, X_C, Y;
        int SoBuocDi, time;
        int beginA, endA, beginB, endB, beginC, endC, minY, maxY;
        string StringDich;
        Stack<Panel> St_CotA;
        Stack<Panel> St_CotB;
        SoundPlayer soundDrop, soundEnd;

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            soundEnd.Stop();
            soundDrop.Stop();
            soundDrop.Dispose();
            soundEnd.Dispose();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
                if (btnSound.Text == "Sound Off")
                {
                btnSound.Text = "Sound On";
                soundDrop.Stop();
                soundEnd.Stop();
                }
        }

        Stack<Panel> St_CotC;

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            cbSoDia.Enabled = true;
            btnChoiLai.Enabled = false;
            setDefault();
            SinhDia();
            timer.Stop();
        }

        public FormGame()
        {
            InitializeComponent();
            St_CotA = new Stack<Panel>();
            St_CotB = new Stack<Panel>();
            St_CotC = new Stack<Panel>();

            soundEnd = new SoundPlayer(Application.StartupPath + @"/Sound/end.wav");
            soundDrop = new SoundPlayer(Application.StartupPath + @"/Sound/drop.wav");
        }

        private void setDefault()
        {
            X_A = 210;
            Y = 358;
            ChieuCaoDia = 25;
            ChieuRongDia = (CotA.Location.X + CotA.Size.Width / 2 - X_A) * 2;
            Dolech = 20;
            SoBuocDi = 0;
            time = 0;
            lbSoBuocDi.Text = "";
            lbThoiGian.Text = "";
            StringDich = "";
            X_B = X_A + ChieuRongDia;
            X_C = X_B + ChieuRongDia;

            beginA = CotA.Location.X - ChieuRongDia / 2;
            beginB = CotB.Location.X - ChieuRongDia / 2;
            beginC = CotC.Location.X - ChieuRongDia / 2;
            endA = CotA.Location.X + ChieuRongDia / 2 - 10;
            endB = CotB.Location.X + ChieuRongDia / 2 - 10;
            endC = CotC.Location.X + ChieuRongDia / 2;
            minY = CotA.Location.Y;
            maxY = CotA.Location.Y + CotA.Height;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbSoDia.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn vui lòng chọn số đĩa!");
                return;
            }
            else
            {
                SinhDia();
                setMouseEvent(St_CotA.Peek());
                btnStart.Enabled = false;
                btnChoiLai.Enabled = true;
                cbSoDia.Enabled = false;
                timer.Start();
            }
        }

        private void SinhDia()
        {
            setDefault();
            XoaTatCaDia();
            for (int i = 0; i < SoDia; i++)
            {
                Panel pnDia = new Panel();
                pnDia.Name = "Dia" + (SoDia - i);
                pnDia.Tag = "A";
                pnDia.Size = new Size(ChieuRongDia - Dolech * i, ChieuCaoDia);
                pnDia.Location = new Point(X_A + (Dolech / 2) * i, Y - (ChieuCaoDia + 2) * i);
                pnDia.BackColor = Color.Yellow;
                pnDia.Visible = true;
                Label lb = new Label();
                lb.AutoSize = true;
                lb.ForeColor = Color.DarkViolet;
                lb.Text = (SoDia - i).ToString();
                pnDia.Controls.Add(lb);
                St_CotA.Push(pnDia);
            }
            
            foreach (Panel pnDia in St_CotA)
            {
                this.Controls.Add(pnDia);
                pnDia.BringToFront();
            }
            lbSoBuocDi.Visible = true;
            lbThoiGian.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            lbThoiGian.Text = time < 10 ? "0" + time.ToString(): time.ToString();
        }

        private void setMouseEvent(Panel pn)
        {
            removeMouseEvent(pn);
            pn.Cursor = Cursors.Hand;
            pn.MouseDown += new MouseEventHandler(down);
            pn.MouseUp += new MouseEventHandler(up);
        }

        private void removeMouseEvent(Panel pn)
        {
            pn.MouseDown -= new MouseEventHandler(down);
            pn.MouseUp -= new MouseEventHandler(up);
        }

        private void down(object sender, MouseEventArgs e)
        {
            Panel pnDia = sender as Panel;
            pnDia.BackColor = Color.Red;
        }
        private void up(object sender, MouseEventArgs e)
        {
            Panel pnDia = sender as Panel;
            string ViTriChuot = LayViTriChuot(e, pnDia);
            pnDia.BackColor = Color.Yellow;
            PushStack(pnDia.Tag.ToString(), ViTriChuot);
        }

        private string LayViTriChuot(MouseEventArgs e, Panel pnDia)
        {
            int eX = e.X + pnDia.Location.X;
            int eY = e.Y + pnDia.Location.Y;
            if(eY > maxY || eY < minY)
            {
                return "";
            }
            if (eX > beginA && eX < endA)
            {
                return "A";
            }
            if (eX > beginB && eX < endB)
            {
                return "B";
            }
            if (eX > beginC && eX < endC)
            {
                return "C";
            }
            return "";
        }

        private void PushStack(string strNguon, string strDich)
        {
            StringDich = strDich;
            if(strNguon == strDich)
            {
                return;
            }
            Stack<Panel> nguon;
            Stack<Panel> dich;
            Panel pnDia;
            int chieucao;
            Panel Cot;

            switch (strNguon)
            {
                case "A":
                    nguon = St_CotA;
                    break;
                case "B":
                    nguon = St_CotB;
                    break;
                case "C":
                    nguon = St_CotC;
                    break;
                default: return;
            }
            switch (strDich)
            {
                case "A":
                    dich = St_CotA;
                    Cot = CotA;
                    break;
                case "B":
                    dich = St_CotB;
                    Cot = CotB;
                    break;
                case "C":
                    dich = St_CotC;
                    Cot = CotC;
                    break;
                default: return;
            }
            if (nguon.Count == 0)
                return;
            if (dich.Count != 0 && nguon.Peek().Width > dich.Peek().Width)
                return;
            pnDia = nguon.Pop();
            if(nguon.Count > 0)
            {
                setMouseEvent(nguon.Peek());
            }
            int ToaDoX = Cot.Location.X + Cot.Width/2 - pnDia.Width/2;
            if (btnSound.Text == "Sound Off")
            {
                soundDrop.Play();
            }
            if (dich.Count > 0)
            {
                chieucao = dich.Peek().Location.Y;
                pnDia.Location = new Point(ToaDoX, chieucao - (ChieuCaoDia + 2));
                removeMouseEvent(dich.Peek());
            }
            else
            {
                pnDia.Location = new Point(ToaDoX, Y);
            }
            pnDia.BringToFront();
            pnDia.Tag = strDich;
            dich.Push(pnDia);
            setMouseEvent(dich.Peek());
            SoBuocDi++;
            lbSoBuocDi.Text = SoBuocDi.ToString();
            if(St_CotC.Count == SoDia)
            {
                if (btnSound.Text == "Sound Off")
                {
                    soundEnd.Play();
                }
                timer.Stop();
                MessageBox.Show("Bạn Đã Chiến Thắng\n"+SoBuocDi+" bước di chuyển trong "+lbThoiGian.Text + " giây!", "The Tower Of Hanoi",MessageBoxButtons.OK);
                removeMouseEvent(St_CotC.Peek());
            }
        }

        private void XoaTatCaDia()
        {
            foreach (Panel pnDia in St_CotA)
            {
                this.Controls.Remove(pnDia);
            }
            foreach (Panel pnDia in St_CotB)
            {
                this.Controls.Remove(pnDia);
            }
            foreach (Panel pnDia in St_CotC)
            {
                this.Controls.Remove(pnDia);
            }
            St_CotA.Clear();
            St_CotB.Clear();
            St_CotC.Clear();
        }
        private void cbSoDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoDia = cbSoDia.SelectedIndex + 1;
        }
    }
}
