using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaCS
{
    internal class ParticleRadar
    {
        public float x;
        public float y;
        public float r=50;
        public float count;
        public float currentCount;

        public void IntersectionParticle(List<Particle> particles)
        {
            count=0;
            for (int i = 0; i < particles.Count; i++) {
				float gX = this.x - particles[i].x;
				float gY = this.y - particles[i].y;

				double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы

				if (r < this.r + particles[i].radius) // если частица оказалось внутри окружности
				{
					count++;
				}
			}
        }
        public void Render(Graphics g) {
			g.DrawEllipse(new Pen(Color.Green, 3), x - r, y - r, r * 2, r * 2);
			g.DrawString(
				$"{currentCount}", 
				new Font("Verdana", 15), // шрифт и его размер
				new SolidBrush(Color.Red), // цвет шрифта
				x - 15, // расположение в пространстве
				y - 15
			);
		}
    }
}
