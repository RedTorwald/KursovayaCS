using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaCS
{
    internal class PointCounter
    {
          
        public int Radius;    // радиус  
        public float PositionX; // координата X центра эмиттера
        public float PositionY; // соответствующая координата Y 
            
        public PointCounter(float PositionX, float PositionY)  // конструктор частицы
        {  
            this.Radius = 1;
            this.PositionX= PositionX;
            this.PositionY= PositionY;
        }
        
        public  void Draw(Graphics g, float PositionX, float PositionY, int Radius )  // метод создания частицы
        {            
            var b = new Pen(Color.Red);
            var a = new Pen(Color.Blue);
            g.DrawEllipse(a, PositionX, PositionY, Radius * 2, Radius * 2);
        }
       
        
    }
}
