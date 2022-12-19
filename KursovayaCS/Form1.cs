using System.Linq.Expressions;

namespace KursovayaCS
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        List<PointCounter> pointCounters = new List<PointCounter>();
        ParticleRadar particleRadar = new ParticleRadar();
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

                panel1.BackColor = colorDialog1.Color;

                int amountParticles = 0;

                for(int i=0; i < pointCounters.Count; i++)
                {
                    if (!checkBox2.Checked)
                    {
                        for(int j=0; j < emitters.Count; j++)
                        {
                            if (!checkBox2.Checked)
                            {
                                pointCounters[i].IntersectionParticle(emitters[j].particles);
                            }
                        }
                    }
                    pointCounters[i].Draw(g);
                }

                int counter=0;
                
                for(int i=0; i < emitters.Count; i++)
                {
                    if (!checkBox2.Checked)
                    {
                        for(int count=0; count<trackBar3.Value; count++)
                        {
                            emitters[i].particles.Add(new Particle(emitters[i].x, emitters[i].y, emitters[i].color));
                        }

                        amountParticles+=emitters[i].particles.Count;

                        emitters[i].UpdateState(pict);
                    }

                    for (int j=0; j < emitters[i].particles.Count; j++)
                    {
                        emitters[i].particles[j].Intersection(mouseX, mouseY);
                    }

                    if (checkBox3.Checked)
                    {
                        particleRadar.IntersectionParticle(emitters[i].particles);
                        counter += (int)particleRadar.count;
                    }
                    emitters[i].Render(g, isDebug.Checked);
                }
                if (checkBox3.Checked)
                {
                    particleRadar.currentCount = counter;
				    particleRadar.Render(g);
				}
			    amountPart.Text = $"Количество частиц: {amountParticles}";
            }
            pict.Invalidate();
        }


        //--------------------------------------------------------------------------------------
        private void pict_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            if (checkBox3.Checked)
            {
                particleRadar.x=mouseX;
                particleRadar.y=mouseY;                
            }           
        }

        private void pict_MouseClick(object sender, MouseEventArgs e)
        {       
            if (e.Button == MouseButtons.Left)
            {
                emitters.Add(new Emitter(e.X,e.Y, colorDialog1.Color));
               
            } 
            
            else if (e.Button == MouseButtons.Right)
            {
                pointCounters.Add(new PointCounter(e.X, e.Y));          
            }

            else if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < pointCounters.Count; i++)
                {
                    if (pointCounters[i].Intersection(mouseX, mouseY))
                    {
                        pointCounters.Remove(pointCounters[i]);
                    }
                }
                for (int i = 0; i < emitters.Count; i++)
                {
                    if (emitters[i].Intersection(mouseX, mouseY))
                    {
                        emitters.Remove(emitters[i]);
                    }
                }         
            }
        }
       
        //--------------------------------------------------------------------------------------
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Emitter.speedMin = trackBar1.Value;    
        }
        private void tb2_Scroll(object sender, EventArgs e)
        {
            Emitter.speedMax = tb2.Value;        
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            l3.Text = trackBar3.Value.ToString();              
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            Emitter.radiusMax = trackBar4.Value;
            l4.Text = trackBar4.Value.ToString();  
        }               
        
        private void tbLife_Scroll(object sender, EventArgs e)
        {
            Emitter.lifeMax = tbLife.Value;
			lLife.Text = tbLife.Value.ToString();
        }

        private void tbDegrees_Scroll(object sender, EventArgs e)
        {
            Emitter.direction = tbDegrees.Value;
            lDegree.Text = tbDegrees.Value.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < emitters.Count; i++)
            {
                emitters[i].particles.Clear();
            }
            emitters.Clear();
            pointCounters.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
        //--------------------------------------------------------------------------------------
       
    }
}