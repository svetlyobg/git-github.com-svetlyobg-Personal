using System;
namespace zaDeshka
{
    class Deshka
    {
        private int age;
        
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0 || value == null)
                    throw new Exception("YOure age cannot be negative ot 0");
                this.age = value;
            }
        }

    }

}

