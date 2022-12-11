using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaCS
{
    internal class PointCounter: Particle
    {
          
        public int Radius; // радиус  
        public int PositionX; // координата X центра эмиттера
        public int PositionY; // соответствующая координата Y 
       
        
        public PointCounter()  // конструктор частицы
        {     
            Radius = 20;
            /*
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            g.FillEllipse(new SolidBrush(Color.Green), -R/2, -R/2, R, R);
            g.DrawEllipse(new Pen(Color.Green),  -R/2,-R/2, R, R);
            g.DrawString( ((int)(timer)).ToString(), new Font("Arial", 8), 
            new SolidBrush(Color.Green), R/3, R/3);*/            
        }
        
        public  void Draw(Graphics g)  // метод создания частицы
        {
            
            var b = new SolidBrush(Color.Red);         
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2); 
            b.Dispose(); //очитска сборщиком мусора
        }


    }
}
