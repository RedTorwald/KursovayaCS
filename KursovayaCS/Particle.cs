using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaCS
{
    internal class Particle
    {
        public static Random rand = new Random();
        public float life, x, y;       
        public int radius; // радиус частицы             
        public float speedX, speedY;
        public Color color;
        public bool isActive = false;


        public Particle(float x, float y, Color color)  // конструктор частицы
        {
            this.x = x;
            this.y = y;
            this.color = color;

            var direction=Emitter.direction;
            var speed=rand.Next((int)Emitter.speedMin, (int)Emitter.speedMax);
    
            //вектор скорости
            speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed); // скорость по X
            speedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed); // скорость по Y
                      
        
            radius = rand.Next((int)Emitter.radiusMin, (int)Emitter.radiusMax); //Рандомный радиус
            life = rand.Next((int)Emitter.lifeMin, (int)Emitter.lifeMax); //Рандомная длительность жизни частицы
        }

        public void Intersection(float x, float y){
            float gX = this.x - x;
			float gY = this.y - y;

			float r = MathF.Sqrt(gX * gX + gY * gY);
            if(r < this.radius)
            {
                isActive= true;
            }
            else
            {
                isActive= false;
            }
        }
        
        public virtual void Draw(Graphics g,  bool isDebug)  // метод создания частицы
        {
            if (life >= 0)
            {
                color=Color.FromArgb((int)life, color);
            }
            else
            {
                color=Color.FromArgb(0, color);
            }
            
            g.FillEllipse(new SolidBrush(color), x - radius, y - radius, radius * 2, radius * 2);
            if(isDebug)
            {
                g.DrawLine(new Pen(Color.Black), x, y, x + speedX, y + speedY);
                if (this.isActive)
                {
                    g.DrawEllipse(new Pen(Color.Black, 1), x - radius, y - radius, radius*2, radius*2);
					g.DrawString(
				        $"x: {Math.Round(x)}\ny: {Math.Round(y)}\nlife: {Math.Round(life)}",
				        new Font("Verdana", 10),
				        new SolidBrush(Color.Black),
				        x + radius, y + radius); 
                }
            }
        }
    }
}
