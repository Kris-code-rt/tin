namespace TurnBasedGame
{
    public partial class Form1 : Form
    {

        private Player player1 = new Player("Andeng", 100, 100, 20);
        private Player player2 = new Player("Pacita", 100, 100, 20);
        private Player currentPlayer;
        private Player opponent;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            currentPlayer = player1;
            opponent = player2;
            progressBar1.Maximum = 100;
        }

        private void swapTurns()
        {
            Player temp = currentPlayer;
            currentPlayer = opponent;
            opponent = temp;
            label1.Text = $"{currentPlayer.Name}'s turn";
        }
        private void UpdateUI()
        {
            progressBar1.Value = Math.Max(0, player1.Health);
            progressBar2.Value = Math.Max(0, player2.Health);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPlayer.AttackPlayer(opponent))
            {
                UpdateUI();
                if (opponent.Health <= 0)
                {
                    MessageBox.Show($"{currentPlayer.Name} wins", "Game Over!-");
                    InitializeGame();
                }
                else
                {
                    MessageBox.Show($"{currentPlayer.Name} miss");
                }
                swapTurns();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
