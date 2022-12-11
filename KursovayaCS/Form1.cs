namespace KursovayaCS
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();       
        List<Emitter> emitters = new List<Emitter>();
       
        public Form1()
        {
            InitializeComponent();
            pict.Image = new Bitmap(pict.Width, pict.Height);

        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            //emitter.UpdateState();

            using (var g = Graphics.FromImage(pict.Image))
            {
                g.Clear(Color.White);
                foreach (Emitter emitter in emitters)
                {
                    emitter.UpdateState();
                    emitter.Render(g);
                }
               // emitter.Render(g); // а тут теперь рендерим через эмиттер
            }
            pict.Invalidate();
        }
        
        private void pict_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            foreach (Emitter emitter in emitters)
            {
                emitter.SpeedMin=trackBar1.Value;
                l1.Text = $"{trackBar1.Value}";
            }            
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            foreach (Emitter emitter in emitters)
            {
                emitter.SpeedMax= tb2.Value;
                l2.Text = $"{ tb2.Value}";
            }           
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            foreach (Emitter emitter in emitters)
            {
                emitter.ParticlesPerTick= trackBar3.Value;
                l3.Text = $"{ trackBar3.Value}";
            }            
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            foreach (Emitter emitter in emitters)
            {
                emitter.RadiusMax= trackBar4.Value;
                l4.Text = $"{ trackBar4.Value}";
            }            
        }

        private void pict_MouseClick(object sender, MouseEventArgs e)
        {           
            Emitter emitter = new Emitter();
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
            emitters.Add(emitter);            
        }

        private void tbLife_Scroll(object sender, EventArgs e)
        {
            foreach (Emitter emitter in emitters)
            {
                emitter.LifeMax= tbLife.Value;               
                lLife.Text = $"{ tbLife.Value}";
            } 
        }

        private void tbDegrees_Scroll(object sender, EventArgs e)
        {
            foreach (Emitter emitter in emitters)
            {
                emitter.Direction= tbDegrees.Value;  
                emitter.Spreading= 0; 
                lDegree.Text = $"{ tbDegrees.Value}";
            } 
        }
    }
}