using System;

namespace It_s_All_Greek_to_Me_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This application calculates the distance between two points and the angle between them.");

            Console.WriteLine("Please enter the first x value: ");
            float firstX = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the first y value: ");
            float firstY = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second x value: ");
            float secondX = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the second y value: ");
            float secondY = float.Parse(Console.ReadLine());

            float deltaX = secondX - firstX;
            float deltaY = secondY - firstY;

            float hypotenuseSquared = deltaX * deltaX + deltaY * deltaY;
            float hypotenuse = (float)Math.Sqrt(hypotenuseSquared);

            Console.WriteLine($"The distance between the first and second point is {hypotenuse}.");

            float angleRadians = (float)Math.Atan2(deltaY, deltaX);
            float angleDegrees = angleRadians * (float)(180 / Math.PI);

            Console.WriteLine($"The angle between the two points is {angleDegrees} degrees.");


        }
    }
}
