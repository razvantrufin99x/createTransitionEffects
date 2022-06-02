namespace createTransitionEffects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class animation 
        {
            public int maintimedelay;
            public animation(int n) { this.maintimedelay = n; }
        }
        public TransitionEffect t = new TransitionEffect();
        public animation a = new animation(1);

        public class TransitionEffect
        {

            public void makeTransitionEffect(animation a, fotografie o, int xdistance, int ydistance, int seconds)
            {
                int step = 0;
                while (step<seconds) {
                    step++;
                    Thread.Sleep( seconds /  a.maintimedelay);
                    o.Left += xdistance / seconds;
                    o.Top += ydistance / seconds;
                };
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.makeTransitionEffect(this.a, this.fotografie1, 200, 0, 20);
        }
    }
}