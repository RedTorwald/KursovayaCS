using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaCS
{
    internal class Emitter
    {
        public List<Particle> particles = new List<Particle>();
       
        public float x; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public float y; // соответствующая координата Y 
        public float radius = 15;
        public static float direction = 0; // вектор направления в градусах 
        public static float spreading = 360; // разброс частиц относительно Direction
        public static float speedMin = 1; // начальная минимальная скорость движения частицы          --------------------------------- taskBar
        public static float speedMax = 10; // начальная максимальная скорость движения частицы        --------------------------------- taskBar
        public static float radiusMin = 2; // минимальный радиус частицы
        public static float radiusMax = 10; // максимальный радиус частицы                            --------------------------------- taskBar


        public static float lifeMin = 0; // минимальное время жизни частицы
        public static float lifeMax = 255; // максимальное время жизни частицы
        public Color color;
        
        public float GravitationX = 0;
        public float GravitationY = 1; 
       
       public Emitter(float x, float y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        
       

        public void UpdateState(PictureBox pict)
        {  

            for (int i=0; i<particles.Count; i++)
            { 

                if (particles[i].life <= 0 || particles[i].y>=pict.Height || particles[i].y<=0
                    || particles[i].x>=pict.Width || particles[i].x<=0)
                {
                    particles.Remove(particles[i]);
                }  
                else
                {     
                    
                    particles[i].speedX += GravitationX;
                    particles[i].speedY += GravitationY;

                    particles[i].x += particles[i].speedX;
                    particles[i].y += particles[i].speedY; 
                    particles[i].life-=1f;
                }
            }
        }

        public bool Intersection(float x, float y)
        {
            float gX = this.x - x;
			float gY = this.y - y;

			float r = MathF.Sqrt(gX * gX + gY * gY);
            if (r<=this.radius)
            {
                return true;
            }
            return false;
        }
        
        public virtual void Render(Graphics g, bool isDebug) // метод Render
        { 
            g.DrawEllipse(new Pen(color, 2), x - radius, y - radius, radius*2, radius*2);
            foreach (var particle in particles)
            {
                particle.Draw(g, isDebug);
            }            
        }
    }
}
