using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3;
            double side_a, side_b, side_c;
            double perimeter, area, semi_perimeter;
            double median_point_a_x, median_point_a_y, median_point_b_x, median_point_b_y, median_point_c_x, median_point_c_y;
            double centroid_x, centroid_y;
            double cosA, cosB, cosC, sinA, sinB, sinC;
            double angle_a, angle_b, angle_c;
            double area_of_inscribed_circle;
            double radius_of_inscribed_circle;
            double radius_of_circumscribed_circle;
            double area_of_circumscribed_circle;
            double length_of_bisector;
            int bullet_x, bullet_y, option;
            double area_1, area_2, area_3, total_area;
            bool triangle;
            int Nazan_kaya, Ali_kurt, Elif_polat;
            double point;
            string user1;
            side_a = 0;
            side_b = 0;
            side_c = 0;
            triangle = true;
            user1 = "";
            point = 0;
            x1 = 0;
            x2 = 0;
            x3 = 0;
            y1 = 0;
            y2 = 0;
            y3 = 0;

            do
            {

                Console.WriteLine("Welcome to the Battleship Game!");
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1.Battleship location");
                Console.WriteLine("2.Properties of the ship");
                Console.WriteLine("3.Shooting at the ship");
                Console.WriteLine("4.High score table");
                Console.WriteLine("5.Exit");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        while (triangle)
                        {
                            Console.WriteLine("Please enter the coordinates!");
                            Console.Write("x1 = ");
                            x1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y1 = ");
                            y1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("x2 = ");
                            x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y2 = ");
                            y2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("x3 = ");
                            x3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("y3 = ");
                            y3 = Convert.ToDouble(Console.ReadLine());


                            side_a = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))), 2);
                            side_b = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2))), 2);
                            side_c = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))), 2);

                            if ((Math.Abs(side_a + side_b)) > side_c & side_c > (Math.Abs(side_a - side_b)) &
                                (Math.Abs(side_b + side_c)) > side_a & side_a > (Math.Abs(side_c - side_b)) &
                                (Math.Abs(side_a + side_c)) > side_b & side_b > (Math.Abs(side_a - side_c)))
                            {
                                Console.WriteLine("It is a triangle");
                                triangle = false;
                            }

                            else
                                Console.WriteLine("It is not a triangle");
                        }
                        Console.Clear();
                        Console.WriteLine("12|");
                        Console.WriteLine("11|");
                        Console.WriteLine("10|");
                        Console.WriteLine(" 9|");
                        Console.WriteLine(" 8|");
                        Console.WriteLine(" 7|");
                        Console.WriteLine(" 6|");
                        Console.WriteLine(" 5|");
                        Console.WriteLine(" 4|");
                        Console.WriteLine(" 3|");
                        Console.WriteLine(" 2|");
                        Console.WriteLine(" 1|");
                        Console.WriteLine(" 0|");
                        Console.WriteLine("  +__________");
                        Console.WriteLine("   123456789012345678901234567890");

                        Console.SetCursorPosition(2 + Convert.ToInt32(x1), Convert.ToInt32(12 - y1));
                        Console.Write("A");
                        Console.SetCursorPosition(2 + Convert.ToInt32(x2), Convert.ToInt32(12 - y2));
                        Console.Write("B");
                        Console.SetCursorPosition(2 + Convert.ToInt32(x3), Convert.ToInt32(12 - y3));
                        Console.Write("C");
                        Console.SetCursorPosition(0, 16);

                        break;

                    case 2:

                        if ((Math.Abs(side_a + side_b)) > side_c & side_c > (Math.Abs(side_a - side_b)) &
                           (Math.Abs(side_b + side_c)) > side_a & side_a > (Math.Abs(side_c - side_b)) &
                           (Math.Abs(side_a + side_c)) > side_b & side_b > (Math.Abs(side_a - side_c)))
                        {
                            Console.WriteLine("Properties of the battleship");

                            side_a = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2))), 2);
                            side_b = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2))), 2);
                            side_c = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))), 2);
                            perimeter = Math.Round((side_a + side_b + side_c), 2);
                            semi_perimeter = Math.Round(((side_a + side_b + side_c) / 2), 2);
                            area = Math.Round(Math.Sqrt(((semi_perimeter - side_a) * (semi_perimeter - side_b) * (semi_perimeter - side_c) * semi_perimeter)), 2);

                            median_point_a_x = (x1 + x2) / 2;
                            median_point_a_y = (y1 + y2) / 2;
                            median_point_b_x = (x2 + x3) / 2;
                            median_point_b_y = (y2 + y3) / 2;
                            median_point_c_x = (x3 + x1) / 2;
                            median_point_c_y = (y3 + y1) / 2;

                            centroid_x = Math.Round(((x1 + x2 + x3) / 3), 2);
                            centroid_y = Math.Round(((y1 + y2 + y3) / 3), 2);

                            cosA = (side_b * side_b + side_c * side_c - side_a * side_a) / (2 * side_b * side_c);
                            cosB = (side_a * side_a + side_c * side_c - side_b * side_b) / (2 * side_a * side_c);
                            cosC = (side_b * side_b + side_a * side_a - side_c * side_c) / (2 * side_b * side_a);

                            angle_b = Math.Round(Math.Acos(cosB) * 180 / Math.PI, 2);
                            angle_a = Math.Round(Math.Acos(cosA) * 180 / Math.PI, 2);
                            angle_c = Math.Round(Math.Acos(cosC) * 180 / Math.PI, 2);

                            radius_of_inscribed_circle = area / semi_perimeter;
                            area_of_inscribed_circle = Math.Round(Math.PI * (Math.Pow(radius_of_inscribed_circle, 2)), 2);

                            sinA = (2 * area) / (side_b * side_c);
                            sinB = (2 * area) / (side_a * side_c);
                            sinC = (2 * area) / (side_b * side_a);

                            radius_of_circumscribed_circle = (side_a) / (2 * sinA);
                            area_of_circumscribed_circle = Math.Round(Math.PI * (Math.Pow(radius_of_circumscribed_circle, 2)), 2);

                            length_of_bisector = Math.Round(Math.Sqrt((side_b * side_c) * (1 - ((side_a * side_a) / Math.Pow((side_b + side_c), 2)))), 2);

                            Console.WriteLine("Ship Info:");

                            if ((angle_a == angle_b) & (angle_b == angle_c))
                                Console.WriteLine("The type of the ship is an equilateral triangle.");

                            else if ((angle_a == angle_b) | (angle_b == angle_c) | (angle_a == angle_c))
                                Console.WriteLine("The type of the ship is an isosceles triangle.");

                            else Console.WriteLine("The type of the ship is scalene triangle.");

                            if ((angle_a < 90) && (angle_b < 90) && (angle_c < 90))
                                Console.WriteLine("It is a Acute-angled");

                            else if ((angle_a <= 90) || (angle_b <= 90) || (angle_c <= 90))
                                Console.WriteLine("It is a Right-angled");

                            else
                                Console.WriteLine("It is a Obtuse-angled");

                            Console.WriteLine("Side A = " + side_a + "  Side B = " + side_b + "  Side C = " + side_c);
                            Console.WriteLine("The perimeter of the ship is =" + perimeter);
                            Console.WriteLine("The semi perimeter of the ship is =" + semi_perimeter);
                            Console.WriteLine("The area of the ship is =" + area);
                            Console.WriteLine("The median point a is = (" + median_point_a_x + ", " + median_point_a_y + ")");
                            Console.WriteLine("The median point b is = (" + median_point_b_x + ", " + median_point_b_y + ")");
                            Console.WriteLine("The median point c is = (" + median_point_c_x + ", " + median_point_c_y + ")");
                            Console.WriteLine("The centroid of the ship is = (" + centroid_x + " , " + centroid_y + ")");
                            Console.WriteLine("The angle of the side A is = " + angle_a);
                            Console.WriteLine("The angle of the side B is = " + angle_b);
                            Console.WriteLine("The angle of the side C is = " + angle_c);
                            Console.WriteLine("The area of inscribed circle is = " + area_of_inscribed_circle);
                            Console.WriteLine("The area of circumscribed circle is = " + area_of_circumscribed_circle);
                            Console.WriteLine("The length of the bisector A is =" + length_of_bisector);
                        }
                        else
                            Console.WriteLine("Please enter coordinates");
                        break;

                    case 3:

                        Random random = new Random();
                        bullet_x = random.Next(1, 30);
                        bullet_y = random.Next(1, 12);

                        Console.Clear();
                        Console.WriteLine("12|");
                        Console.WriteLine("11|");
                        Console.WriteLine("10|");
                        Console.WriteLine(" 9|");
                        Console.WriteLine(" 8|");
                        Console.WriteLine(" 7|");
                        Console.WriteLine(" 6|");
                        Console.WriteLine(" 5|");
                        Console.WriteLine(" 4|");
                        Console.WriteLine(" 3|");
                        Console.WriteLine(" 2|");
                        Console.WriteLine(" 1|");
                        Console.WriteLine(" 0|");
                        Console.WriteLine("  +____");
                        Console.WriteLine("   123456789012345678901234567890");

                        Console.SetCursorPosition(2 + Convert.ToInt32(x1), Convert.ToInt32(12 - y1));
                        Console.Write("A");
                        Console.SetCursorPosition(2 + Convert.ToInt32(x2), Convert.ToInt32(12 - y2));
                        Console.Write("B");
                        Console.SetCursorPosition(2 + Convert.ToInt32(x3), Convert.ToInt32(12 - y3));
                        Console.Write("C");
                        Console.SetCursorPosition(2 + Convert.ToInt32(bullet_x), Convert.ToInt32(12 - bullet_y));
                        Console.Write("X");
                        Console.SetCursorPosition(0, 16);


                        area = Math.Round((Math.Abs((x1 * y2 + x2 * y3 + x3 * y1) - (x2 * y1 + x3 * y2 + x1 * y3))/ 2),2);
                        area_1 = Math.Round(Math.Abs(((bullet_x * y2 + x2 * y3 + x3 * bullet_y) - (x2 * bullet_y + x3 * y2 + bullet_x * y3))/2), 2);
                        area_2 = Math.Round(Math.Abs(((x1 * bullet_y + bullet_x * y3 + x3 * y1) - (bullet_x * y1 + x3 * bullet_y + x1 * y3))/2), 2);
                        area_3 = Math.Round(Math.Abs(((x1 * y2 + x2 * bullet_y + bullet_x * y1) - (x2 * y1 + bullet_x * y2 + x1 * bullet_y))/2), 2);
                        total_area = (area_1 + area_2 + area_3);


                        if (total_area > area)
                        {
                            Console.WriteLine("The battleship is survived");
                            Console.WriteLine("Your score is= " + area);
                            point = area;
                            Console.WriteLine("Please enter your name:");
                            user1 = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("The battleship is sank");
                            Console.WriteLine("Your score is= 0");
                        }


                        break;

                    case 4:

                        Nazan_kaya = 60;
                        Ali_kurt = 30;
                        Elif_polat = 24;

                        if (point > Nazan_kaya)
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name             Score");
                            Console.WriteLine(user1 + "     " + point);
                            Console.WriteLine("Nazan Kaya        60");
                            Console.WriteLine("Ali Kurt          30");
                        }
                        else if (point <= Nazan_kaya & point > Ali_kurt)
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name             Score");
                            Console.WriteLine("Nazan Kaya        60");
                            Console.WriteLine(user1 + "      " + point);
                            Console.WriteLine("Ali Kurt          30");
                        }
                        else if (point <= Nazan_kaya & point <= Ali_kurt & point > Elif_polat)
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name             Score");
                            Console.WriteLine("Nazan Kaya        60");
                            Console.WriteLine("Ali Kurt          30");
                            Console.WriteLine(user1 + "        " + point);
                        }
                        else
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name             Score");
                            Console.WriteLine("Nazan Kaya        60");
                            Console.WriteLine("Ali Kurt          30");
                            Console.WriteLine("Elif Polat        24");
                        }



                        break;
                }
            }
            while (option != 5);

        }
    }
}
