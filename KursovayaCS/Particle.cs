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



    }
}
