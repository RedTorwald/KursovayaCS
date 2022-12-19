using System.Linq.Expressions;

namespace KursovayaCS
{
    public partial class Form1 : Form
    {
        
       
        List<Emitter> emitters = new List<Emitter>();
        List<PointCounter> pointCounters = new List<PointCounter>();

        float mouseX, mouseY;
        

        public Form1()
        {
            InitializeComponent();
            pict.Image = new Bitmap(pict.Width, pict.Height);
           
        }

        //--------------------------------------------------------------------------------------


        private void timer_Tick(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(pict.Image))
            {
                g.Clear(Color.White);

                int amountParticles = 0;

               
            }
            pict.Invalidate();
        }


        //--------------------------------------------------------------------------------------
        private void pict_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

       

        private void pict_MouseClick(object sender, MouseEventArgs e)
        {       
            if (e.Button == MouseButtons.Left)
            {
               
            } 
            
            else if (e.Button == MouseButtons.Right)
            {
                           
            }

            else if (e.Button == MouseButtons.Middle)
            {
                           
            }


        }
       
        //--------------------------------------------------------------------------------------
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
                      
        }
        private void tb2_Scroll(object sender, EventArgs e)
        {
                      
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
                       
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
                       
        }
        private void tbLife_Scroll(object sender, EventArgs e)
        {
            
        }

        private void tbDegrees_Scroll(object sender, EventArgs e)
        {
            
        }
        //--------------------------------------------------------------------------------------
       
    }
}