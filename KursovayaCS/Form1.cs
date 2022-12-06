namespace KursovayaCS
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();
        List<Particle> particles = new List<Particle>();

        List<Emitter> emitters = new List<Emitter>();
       
        public Form1()
        {
            InitializeComponent();
            pict.Image = new Bitmap(pict.Width, pict.Height);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(pict.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }
            pict.Invalidate();
        }

        private void pict_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;

        }
    }
}