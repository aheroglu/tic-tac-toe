using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe.Forms
{
    public partial class tic_tac_toe_game : Form
    {
        public tic_tac_toe_game()
        {
            InitializeComponent();
        }

        // Moving the form
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        // Game variables
        int clickCount = 0;
        int xWin = 0;
        int yWin = 0;

        void ClearGame()
        {
            clickCount = 0;

            xWinCount.Text = xWin.ToString();
            yWinCount.Text = yWin.ToString();

            button_1.Text = "";
            button_2.Text = "";
            button_3.Text = "";
            button_4.Text = "";
            button_5.Text = "";
            button_6.Text = "";
            button_7.Text = "";
            button_8.Text = "";
            button_9.Text = "";

            button_1.Enabled = true;
            button_2.Enabled = true;
            button_3.Enabled = true;
            button_4.Enabled = true;
            button_5.Enabled = true;
            button_6.Enabled = true;
            button_7.Enabled = true;
            button_8.Enabled = true;
            button_9.Enabled = true;
        }

        void ChechResults()
        {
            // X's odds off winning
            if (button_1.Text == "X" && button_2.Text == "X" && button_3.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_4.Text == "X" && button_5.Text == "X" && button_6.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_7.Text == "X" && button_8.Text == "X" && button_9.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_1.Text == "X" && button_4.Text == "X" && button_7.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_2.Text == "X" && button_5.Text == "X" && button_8.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_3.Text == "X" && button_6.Text == "X" && button_9.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_1.Text == "X" && button_5.Text == "X" && button_9.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }

            if (button_3.Text == "X" && button_5.Text == "X" && button_7.Text == "X")
            {
                MessageBox.Show("'X' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xWin++;
                ClearGame();
            }


            // O's odds off winning
            if (button_1.Text == "O" && button_2.Text == "O" && button_3.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_4.Text == "O" && button_5.Text == "O" && button_6.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_7.Text == "O" && button_8.Text == "O" && button_9.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_1.Text == "O" && button_4.Text == "O" && button_7.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_2.Text == "O" && button_5.Text == "O" && button_8.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_3.Text == "O" && button_6.Text == "O" && button_9.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_1.Text == "O" && button_5.Text == "O" && button_9.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }

            if (button_3.Text == "O" && button_5.Text == "O" && button_7.Text == "O")
            {
                MessageBox.Show("'O' Won!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yWin++;
                ClearGame();
            }


            // Draw
            if (button_1.Text != "" && button_2.Text != "" && button_3.Text != "" && button_4.Text != "" && button_5.Text != "" && button_6.Text != "" && button_7.Text != "" && button_8.Text != "" && button_9.Text != "")
            {
                MessageBox.Show("Draw!", "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGame();
            }
        }

        private void tic_tac_toe_game_Load(object sender, EventArgs e)
        {
            ClearGame();
        }


        private void tic_tac_toe_game_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void tic_tac_toe_game_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = Cursor.Position.X - lastCursor.X;
                int yDiff = Cursor.Position.Y - lastCursor.Y;

                this.Location = new Point(lastForm.X + xDiff, lastForm.Y + yDiff);
            }
        }

        private void tic_tac_toe_game_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_1.Text = "O";
                button_1.Enabled = false;
                ChechResults();
            }

            else
            {
                button_1.Text = "X";
                button_1.Enabled = false;
                ChechResults();
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_2.Text = "O";
                button_2.Enabled = false;
                ChechResults();
            }

            else
            {
                button_2.Text = "X";
                button_2.Enabled = false;
                ChechResults();
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_3.Text = "O";
                button_3.Enabled = false;
                ChechResults();
            }

            else
            {
                button_3.Text = "X";
                button_3.Enabled = false;
                ChechResults();
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_4.Text = "O";
                button_4.Enabled = false;
                ChechResults();
            }

            else
            {
                button_4.Text = "X";
                button_4.Enabled = false;
                ChechResults();
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_5.Text = "O";
                button_5.Enabled = false;
                ChechResults();
            }

            else
            {
                button_5.Text = "X";
                button_5.Enabled = false;
                ChechResults();
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_6.Text = "O";
                button_6.Enabled = false;
                ChechResults();
            }

            else
            {
                button_6.Text = "X";
                button_6.Enabled = false;
                ChechResults();
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_7.Text = "O";
                button_7.Enabled = false;
                ChechResults();
            }

            else
            {
                button_7.Text = "X";
                button_7.Enabled = false;
                ChechResults();
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_8.Text = "O";
                button_8.Enabled = false;
                ChechResults();
            }

            else
            {
                button_8.Text = "X";
                button_8.Enabled = false;
                ChechResults();
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 0)
            {
                button_9.Text = "O";
                button_9.Enabled = false;
                ChechResults();
            }

            else
            {
                button_9.Text = "X";
                button_9.Enabled = false;
                ChechResults();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to reset the application?", "Reset Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                xWin = 0;
                yWin = 0;

                ClearGame();
            }
        }

    }
}
