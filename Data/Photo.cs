using System;

namespace MyPhotoshop
{


    public class Photo
    {
        public readonly int width;
        public readonly int height;
        private readonly Pixel[,] data;

        public ref Pixel this[int weight, int height] {
            get {
                if (weight >= this.width || height >= this.height)
                    throw new IndexOutOfRangeException();
                else 
                    return ref data[weight, height];
            }
        }

        public Photo(int width, int height)
        {
            this.height = height;
            this.width = width;
            data = new Pixel[width,height];
        }
    }
}

