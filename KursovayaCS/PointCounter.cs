using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaCS
{
    internal class PointCounter
    {
          
        public int radius;    // радиус  
        public float positionX; // координата X 
        public float positionY; // соответствующая координата Y 
        public double r;
        public int count;
            
        public PointCounter(float PositionX, float PositionY)  // конструктор частицы
        {  
            this.radius = 50;
            this.positionX= PositionX;
            this.positionY= PositionY;
        }
      
        public bool Intersection(float x, float y)
        {
            float gX = this.positionX - x;
			float gY = this.positionY - y;

			float r = MathF.Sqrt(gX * gX + gY * gY);

			if (r <= this.radius) {
				return true;
			}

			return false;
        }

        public void IntersectionParticle(List<Particle> particles)
        {
            for (int i=0; i<particles.Count; i++)
            {
                float gX = this.positionX - particles[i].x;
			    float gY = this.positionY - particles[i].y;
			    float r = MathF.Sqrt(gX * gX + gY * gY);

			    if (r <= this.radius) {
				    particles[i].life=0;
                    count++;
			    }
            }           
        }


        public virtual void Draw(Graphics g)  // метод создания частицы
        {            
            
            var a = new Pen(Color.Blue);
            g.DrawEllipse(a, positionX-radius, positionY-radius, radius * 2, radius * 2);
            g.DrawString(
                $"{count}",
                new Font("Verdana", 10), // шрифт и его размер
                new SolidBrush(Color.Black), // цвет шрифта
                positionX-10, // расположение в пространстве
                positionY-10
            );
        }
    }
}
