using System;
namespace console.zalupa
{
    class Program
    {
        static void Main()
        {
            int width = 120;
            int height = 30;
            char[] screen = new char[width * height + 1];
            screen[width * height] = '\0';
            float aspect = width / height;
            float pixelAspect = 11.0f / 24.0f;
            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height+1);
            for (int t = 0; t < 10000; t++)
            {
                for (int i = 0; i < width; i++) { 
                    for (int j = 0; j < height; j++)
                    {
                        float x = (float)i / width * 2.0f - 1.0f;
                        float y = (float)j / height * 2.0f - 1.0f;
                        char pixel = ' ';
                        x *= aspect * pixelAspect;
                        x += (float)Math.Sin(t * 0.001f);
                        if (x*x +y*y < 0.6)
                            {
                                pixel = "@"
                            }
                        }
                            
                        

                        screen[i + j * width] = pixel;

                    }
                    
                }
                Print(screen);
            }
            void Print(char[] _char)
            {
                string chars = "";
                foreach (char item in _char)
                {
                    chars += item;
                }
                Console.WriteLine(chars);
                Console.SetCursorPosition(0, 0);
                
            }
            
        }
    }
}
