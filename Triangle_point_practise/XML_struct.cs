using System;

namespace Triangle_point_practise
{
    [Serializable] //структура для работы с xml файлами
    public class XML_struct
    {
        public string aX { get; set; }  //координаты точки А
        public string aY { get; set; } 
        public string bX { get; set; } //кординаты точки B
        public string bY { get; set; } 
        public string cX { get; set; } //координаты точки C
        public string cY { get; set; }
        public string pointX { get; set; } //координаты произвольной точки
        public string pointY { get; set; }


    }
}
