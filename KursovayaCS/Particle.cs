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

        public float Life;       
        public int Radius; // радиус частицы

        public float X; // X координата частицы 
        public float Y; // Y координата частицы 
        
        public float SpeedX; // скорость перемещения по оси X
        public float SpeedY; // скорость перемещения по оси Y

        public Particle()  // конструктор частицы
        {            
            var direction=(double)rand.Next(360);
            var speed=1+rand.Next(10);
    
            //вектор скорости
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed); // скорость по X
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed); // скорость по Y
            
            Radius = 2 + rand.Next(10); //Рандомный радиус
            Life = 20 + rand.Next(100); //Рандомная длительность жизни частицы
        }
        
        public void Draw(Graphics g)  // метод создания частицы
        {
            //затухание
            float k = Math.Min(1f, Life / 100);           
            int alpha = (int)(k * 255);
            
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);
                  
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2); 
            b.Dispose(); //очитска сборщиком мусора
        }
    }
}
