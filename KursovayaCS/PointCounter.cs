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
        public int PositionX; // координата X центра эмиттера
        public int PositionY; // соответствующая координата Y 
         public int AAA;
         public int BBB;     
        public PointCounter()  // конструктор частицы
        {     
            this.Radius = 20;
            this.PositionX=AAA;
            this.PositionY=BBB;
        }
        
        public  void Render(Graphics g,int Position, int PositionY )  // метод создания частицы
        {            
            var b = new SolidBrush(Color.Red);         
            g.FillEllipse(b, PositionX , PositionY , Radius * 2, Radius * 2); 
          
        }
       
        
    }
}
