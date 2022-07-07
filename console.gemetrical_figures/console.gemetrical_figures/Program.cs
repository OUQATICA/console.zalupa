using System;


namespace zalupa
{
    public class Program
    {
        static void Main()
        {
            char[] gradient = new char[] { '.', ':', '!', '/', 'r', '(', 'l', '1', 'Z', '4', 'H', '9', 'W', '8', '$', '@' };
            Array.Reverse(gradient);
            Console.CursorVisible = false;
            int width = 120;
            int height = 30;
            char[] screen = new char[width * height + 1];
            screen[width * height] = '\0';
            float aspect = width / height;
            float pixelAspect = 11.0f / 24.0f;
            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height + 1);
            for (int t = 0; t < 10000; t++)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        float x = (float)i / width * 2.0f - 1.0f;
                        float y = (float)j / height * 2.0f - 1.0f;
                        char pixel = ' ';
                        x *= aspect * pixelAspect;
                        x += (float)Math.Sin(t * 0.001f);
                        //y += (float)Math.Cos(t * 0.001f);
                        for (float gradient_bridth = 15.0f; gradient_bridth != 0; gradient_bridth--)
                            if (x * x + y * y < gradient_bridth / 20) pixel = gradient[(int)gradient_bridth]; //круг
                                //if (Math.Abs(x + y) + Math.Abs(x - y) < gradient_bridth / 15) pixel = gradient[(int)gradient_bridth]; //квадрат
                                //if (Math.Abs(x) + Math.Abs(y) < gradient_bridth / 20) pixel = gradient[(int)gradient_bridth]; //ромб
                        screen[i + j * width] = pixel;
                    }
                }
                Console.WriteLine(screen);
                Console.SetCursorPosition(0, 0);
            }


        }
    }
}