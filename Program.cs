using System;

namespace COREY_TrianglesShape_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);
            WelcomeScreen();
            SelectionScreen();
            ComputationScreen();
        }


        //Press enter to continue
        static void PressEnter()
        {
            Console.Write("\nPress ENTER to continue.");
            Console.ReadLine();
        }

        //Invalid input!
        static void InvalidInput()
        {
            Console.Write("\nInvalid Input! Press ENTER to continue.");
            Console.ReadLine();
        }

        //yellow text
        static void YellowText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ResetColor();
        }

        //Compute or Not Message
        static void ComputeOrNotMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to compute, or back at the computation screen? Type YES if you want to\ncompute and NO if otherwise.");
            Console.Write("Type here: ");
            Console.ResetColor();
        }

        //This is because all trig functions in C# returns it in radians
        static double Degrees2Rad(double Angle)
        {
            double Radians = (Angle * (Math.PI)) / 180;
            return Radians;
        }

        //rad to deg
        static double Rad2Degrees(double Radians)
        {
            double Angle = (Radians * 180) / (Math.PI);
            return Angle;
        }

        //Result of the Area Formulas
        static void AreaResult(double Area)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe area is {Area} units^2.\n");
            Console.ResetColor();
        }

        //Result of the Side (for perimeter and other formulas)
        static void SideResult(double Side)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe side is {Side} units.\n");
            Console.ResetColor();
        }

        //For law of sines and cosines
        static void DegreeResult(double DegreeResult)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe angle is {DegreeResult} degrees.\n");
            Console.ResetColor();
        }






        //For Title Screen titles
        static void TitleScreen(string Name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========================================================================================");
            Console.ResetColor();
            Console.WriteLine(" ");
        }






        //WELCOME SCREEN
        static void WelcomeScreen()
        {
            Console.Clear();
            //TRIANGLE-RELATED CALCULATOR with tabs on each letter and 2 newlines on each word
            TitleScreen("\tT\tR\tI\tA\tN\tG\tL\tE\t-\n\n\tR\tE\tL\tA\tT\tE\tD\n\n\tC\tA\tL\tC\tU\tL\tA\tT\tO\tR");

            Console.WriteLine("Welcome user! This is an application that finds the area and perimeters of the triangle.");
            Console.WriteLine("Aside from that, this application has some formulas related to the triangle such as the");
            Console.WriteLine("Pythagorean theorem, Law of Sines, and Law of Cosines.");

            PressEnter();
        }





        //Selection Screen
        static void SelectionScreen()
        {
            Console.Clear();
            TitleScreen("\tPlease select your choice. Type the number that corresponds to your choice.");


            Console.WriteLine("(1) COMPUTATION");
            Console.WriteLine("(2) SUMMARY");
            Console.WriteLine("(3) EXIT");

            Console.Write("\nInput your choice here: ");
            int selectionInput = Convert.ToInt32(Console.ReadLine());

            switch (selectionInput)
            {
                case 1:
                    ComputationScreen();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                case 3:
                    ExitScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        SelectionScreen();
                        break;
                    }
            }
        }


        //Exit Screen
        static void ExitScreen()
        {
            Console.Clear();
            TitleScreen("\t\t\t\t\tExit Screen");
            Console.WriteLine("Thank you for trying my application! There will be updates in the future! You are using\nversion 1.0.");
            Console.WriteLine("\nOne of my plans is also to make a unit converter inside the application and to expand\nformulas, not just triangles.");
            Console.WriteLine("\nAside from that, I will implement the summary screen where the history of inputted data\nand the result are stored.There is so much room for improvement.");

            Console.Write("\nPress ENTER to Exit.");
            Console.ReadLine();
            Environment.Exit(0);
        }


        //Computation Screen
        static void ComputationScreen()
        {
            Console.Clear();
            TitleScreen("\tThis is the computation screen. Please select what do you want to calculate.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------Area----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) Area of a triangle");
            Console.WriteLine("(2) SAS Formula for the Area of a Triangle");
            Console.WriteLine("(3) Heron's Formula");
            Console.WriteLine("(4) Area of an Equilateral Triangle");
            Console.WriteLine("(5) Area of an Isosceles Triangle without Given Height\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------Perimeter----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(6) Perimeter of a triangle\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------Other Formulas----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(7) Pythagorean Theorem");
            Console.WriteLine("(8) Law of Sines");
            Console.WriteLine("(9) Law of Cosines\n");

            Console.WriteLine("(10) Exit to Selection Screen");


            Console.Write("\nInput your choice here: ");
            int selectionInputComputation = Convert.ToInt32(Console.ReadLine());

            switch (selectionInputComputation)
            {
                case 1:
                    AreaOfATriangle();
                    break;
                case 2:
                    SASFormula();
                    break;
                case 3:
                    HeronsFormula();
                    break;
                case 4:
                    AreaEquilateralTriangle();
                    break;
                case 5:
                    AreaIsoscelesWithoutHeight();
                    break;
                case 6:
                    PerimeterOfTriangle();
                    break;
                case 7:
                    PythagoreanTheorem();
                    break;
                case 8:
                    LawOfSines();
                    break;
                case 9:
                    LawOfCosines();
                    break;
                case 10:
                    SelectionScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        ComputationScreen();
                        break;
                    }
            }
        }


        //Title screen for the computation selected
        static void ComputationTitleScreen(string Name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================================================================");
            Console.ResetColor();
            Console.WriteLine(" ");
        }




        //Area of a Triangle
        static void AreaOfATriangle()
        {
            Console.Clear();
            ComputationTitleScreen("Area of a Triangle");

            Console.WriteLine("The area of a triangle, when the height is perpendicular to the base, is:\n");
            Console.WriteLine("A = (1 / 2) * b * h\n");
            Console.WriteLine("Where:");
            Console.WriteLine("A = Area of a triangle (in units squared)");
            Console.WriteLine("h = Height of the triangle");
            Console.WriteLine("b = Base of the triangle\n");

            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        AreaOfATriangle();
                        break;
                    }
            }


            Console.Write("\nType the base (b): ");
            double Base = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the height (h): ");
            double Height = Convert.ToInt32(Console.ReadLine());
            AreaResult(AreaOfATriangleComputation(Base, Height));
            PressEnter();
            AreaOfATriangle();


            static double AreaOfATriangleComputation(double Base, double Height)
            {
                double Area = (0.5) * Base * Height;
                return Area;
            }
        }






        //SAS Formula for the Area of the Triangle
        static void SASFormula()
        {
            Console.Clear();
            ComputationTitleScreen("SAS Formula for the Area of a Triangle");

            Console.WriteLine("The area of a triangle, when there is an included angle and two sides are known, is:\n");
            Console.WriteLine("A = (1 / 2) * c * b * sin B\n");
            Console.WriteLine("Where:");
            Console.WriteLine("A = Area of a triangle (in units squared)");
            Console.WriteLine("B = Included Angle (in degrees)");
            Console.WriteLine("c = Side No. 1");
            Console.WriteLine("b = Side No. 2\n");

            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        SASFormula();
                        break;
                    }
            }

            Console.Write("\nType the value of the first side (c): ");
            double Side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the value of the second side (b): ");
            double Side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the angle in degrees (B): ");
            double AngleDegrees = Convert.ToInt32(Console.ReadLine());
            AreaResult(SASFormulaComputation(Side1, Side2, AngleDegrees));
            PressEnter();
            SASFormula();


            static double SASFormulaComputation(double Side1, double Side2, double AngleDegrees)
            {
                double Area = (0.5) * Side1 * Side2 * Math.Sin(Degrees2Rad(AngleDegrees));
                return Area;
            }
            
        }



        //Heron's Formula
        static void HeronsFormula()
        {
            Console.Clear();
            ComputationTitleScreen("Heron's Formula");

            Console.WriteLine("The area of a triangle, when all three sides are known, is:\n");
            Console.WriteLine("A = sqrt(s * (s -a ) * (s - b) * (s - c))\n");
            Console.WriteLine("Where:");
            Console.WriteLine("A = Area of a triangle (in units squared)");
            Console.WriteLine("a = Side No. 1");
            Console.WriteLine("b = Side No. 2");
            Console.WriteLine("c = Side No. 3");
            Console.WriteLine("s = Semiperimeter, equivalent to (a + b + c)/2 \n");

            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        HeronsFormula();
                        break;
                    }

            }
                
            Console.Write("\nType the value of the first side (a): ");
            double Side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the value of the second side (b): ");
            double Side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the value of the third side (c): ");
            double Side3 = Convert.ToInt32(Console.ReadLine());
            AreaResult(HeronsFormulaComputation(Side1, Side2, Side3));
            PressEnter();
            HeronsFormula();


            static double HeronsFormulaComputation(double Side1, double Side2, double Side3)
            {
                double s = (Side1 + Side2 + Side3) / 2;
                double Area = Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
                return Area;
            }
            
        }


        //Area of an Equilateral Triangle
        static void AreaEquilateralTriangle()
        {
            Console.Clear();
            ComputationTitleScreen("Area of an Equilateral Triangle");

            Console.WriteLine("An equilateral triangle is a kind of triangle where all sides are equal and the\nmeasure of all the angles in the triangle is 60 degrees. \n");
            Console.WriteLine("The area of an equilateral triangle, when all three sides are known, is:\n");
            Console.WriteLine("A = (sqrt(3) / 4) * a^2\n");
            Console.WriteLine("Where:");
            Console.WriteLine("A = Area of a triangle (in units squared)");
            Console.WriteLine("a = Side of a Triangle (of equal sides)\n");


            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        AreaEquilateralTriangle();
                        break;
                    }

            }


            Console.Write("\nType the value of the side of the triangle of equal sides (a): ");
            double Side = Convert.ToInt32(Console.ReadLine());
            AreaResult(AreaEquilateralTriangleComputation(Side));
            PressEnter();
            AreaEquilateralTriangle();


            static double AreaEquilateralTriangleComputation(double Side)
            {
                double Area = (Math.Sqrt(3) / 4) * (Math.Pow(Side, 2));
                return Area;
            }

        }



        //Area of an Isoceles Triangle without Given Height
        static void AreaIsoscelesWithoutHeight()
        {
            Console.Clear();
            ComputationTitleScreen("Area of an Isosceles Triangle without Given Height");

            Console.WriteLine("An isosceles triangle has at least two sides and angles of equal length.");
            Console.WriteLine("The area of an isosceles triangle, when the height is unknown, is:\n");
            Console.WriteLine("A = (1/2) * b * sqrt(a^2 - ((b^2)/4))\n");
            Console.WriteLine("Where:");
            Console.WriteLine("A = Area of a triangle (in units squared)");
            Console.WriteLine("a = Side of a Triangle (of two equal sides)");
            Console.WriteLine("b = Base of a Triangle\n");


            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        AreaIsoscelesWithoutHeight();
                        break;
                    }
            }


            Console.Write("\nType the value of the side of the triangle of two equal sides (a): ");
            double Side = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the base (b): ");
            double Base = Convert.ToInt32(Console.ReadLine());
            AreaResult(AreaIsoscelesWithoutHeightComputation(Side, Base));
            PressEnter();
            AreaIsoscelesWithoutHeight();


            static double AreaIsoscelesWithoutHeightComputation(double Side, double Base)
            {
                double Area = (0.5) * Base * Math.Sqrt(Math.Pow(Side, 2) - (Math.Pow(Base, 2) / 4));
                return Area;
            }

        }




        //Perimeter of a Triangle
        static void PerimeterOfTriangle()
        {
            Console.Clear();
            ComputationTitleScreen("Perimeter of a triangle");

            Console.WriteLine("The perimeter of a triangle, when all three sides are known, is:\n");
            Console.WriteLine("P = a + b + c\n");
            Console.WriteLine("Where:");
            Console.WriteLine("P = Perimeter of a triangle (in units)");
            Console.WriteLine("a = Side No. 1");
            Console.WriteLine("b = Side No. 2");
            Console.WriteLine("c = Side No. 3\n");

            Console.WriteLine("If the triangle is an equilateral, type the same side value three times. If the triangle\nis an isosceles, type the same side value two times and type the different third value.\n");

            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        PerimeterOfTriangle();
                        break;
                    }
            }


            Console.Write("\nType the value of the first side (a): ");
            double Side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the value of the second side (b): ");
            double Side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the value of the third side (c): ");
            double Side3 = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe perimeter is {PerimeterOfTriangleComputation(Side1, Side2, Side3)} units.\n");
            Console.ResetColor();
            PressEnter();
            PerimeterOfTriangle();


            static double PerimeterOfTriangleComputation(double Side1, double Side2, double Side3)
            {
                double Perimeter = Side1 + Side2 + Side3;
                return Perimeter;
            }

        }




        //Pythagorean Theorem
        static void PythagoreanTheorem()
        {
            Console.Clear();
            ComputationTitleScreen("Pythagorean Theorem");

            Console.WriteLine("The hypotenuse of a right triangle is equal to the square root of the sum of the squares of the two sides.\n");
            Console.WriteLine("c^2 = a^2 + b^2\n");
            Console.WriteLine("Where:");
            Console.WriteLine("a = Side No. 1");
            Console.WriteLine("b = Side No. 2");
            Console.WriteLine("c = Hypotenuse\n");


            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        PythagoreanTheorem();
                        break;
                    }
            }


            Console.Write("\nType the value of the first side (a): ");
            double Side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the value of the second side (b): ");
            double Side2 = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe hypotenuse is {PythagoreanComputation(Side1, Side2)} units.\n");
            Console.ResetColor();

            PressEnter();
            PythagoreanTheorem();


            static double PythagoreanComputation(double Side1, double Side2)
            {
                double c = Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
                return c;
            }

        }




        //Law of Sines
        static void LawOfSines()
        {
            Console.Clear();
            ComputationTitleScreen("Law of Sines");

            Console.WriteLine("It shows the relationship between the sides and angles of oblique triangles. To use the\nLaw of Sines, the values of the triangle given must be an AAS (Angle-Angle-Side) or SSA\n(Side-Side-Angle).\n");
            Console.WriteLine("The simplified formula for the Law of Sines is:\n");
            Console.WriteLine("(a / sin A) = (b / sin B)\n");
            Console.WriteLine("Where:");
            Console.WriteLine("A = Angle of A");
            Console.WriteLine("B = Angle of B");
            Console.WriteLine("a = Side of A");
            Console.WriteLine("b = Side of B\n");

            Console.WriteLine("The simplified formula works as long as you have two sides and an angle (SSA) or two\nangles and a side (AAS).\n");


            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        LawOfSines();
                        break;
                    }
            }


            YellowText("\nIs your given an AAS or SSA?: ");
            string AASorSSA = Console.ReadLine();
            AASorSSA = AASorSSA.ToUpper();

            switch (AASorSSA)
            {
                case "AAS":
                    {
                        YellowText("\nSolving for the side.\n");
                        YellowText("Do you want to solve for the right side of the equation (type: a) or the left side\n(type: b)?: ");
                        string AorB = Console.ReadLine();
                        AorB = AorB.ToUpper();

                        switch (AorB)
                        {
                            case "A":
                                {
                                    Console.Write("\nType the value of the Side of B: ");
                                    double B = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Angle of B: ");
                                    double AngleB = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Angle of A: ");
                                    double AngleA = Convert.ToInt32(Console.ReadLine());
                                    SideResult(AAS_UnknownA(B, AngleB, AngleA));
                                    break;
                                }
                            case "B":
                                {
                                    Console.Write("\nType the value of the Side of A: ");
                                    double A = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Angle of A: ");
                                    double AngleA = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Angle of B: ");
                                    double AngleB = Convert.ToInt32(Console.ReadLine());
                                    SideResult(AAS_UnknownB(A, AngleA, AngleB));
                                    break;
                                }
                            default:
                                {
                                    InvalidInput();
                                    LawOfSines();
                                    break;
                                }
                        }
                        break;
                    }

                case "SSA":
                    {
                        YellowText("\nSolving for the angle.\n");
                        YellowText("Do you want to solve for the right side of the equation (type: A) or the left side\n(type: B)?: ");
                        string AorB = Console.ReadLine();
                        AorB = AorB.ToUpper();

                        switch (AorB)
                        {
                            case "A":
                                {
                                    Console.Write("\nType the value of the Side of A: ");
                                    double A = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Side of B: ");
                                    double B = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Angle of B: ");
                                    double AngleB = Convert.ToInt32(Console.ReadLine());
                                    SSA_UnknownAngleA(A, B, AngleB);
                                    break;
                                }
                            case "B":
                                {
                                    Console.Write("\nType the value of the Side of B: ");
                                    double B = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Side of A: ");
                                    double A = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Type the value of the Angle of A: ");
                                    double AngleA = Convert.ToInt32(Console.ReadLine());
                                    SSA_UnknownAngleB(B, A, AngleA);
                                    break;
                                }
                            default:
                                {
                                    InvalidInput();
                                    LawOfSines();
                                    break;
                                }
                        }
                        break;

                    }


                default:
                    {
                        InvalidInput();
                        LawOfSines();
                        break;
                    }
            }


            PressEnter();
            LawOfSines();


            static double AAS_UnknownA(double B, double AngleB, double AngleA)
            {
                double a = B * (Math.Sin(Degrees2Rad(AngleA)) / Math.Sin(Degrees2Rad(AngleB)));
                return a;
            }

            static double AAS_UnknownB(double A, double AngleA, double AngleB)
            {
                double b = A * (Math.Sin(Degrees2Rad(AngleB)) / Math.Sin(Degrees2Rad(AngleA)));
                return b;
            }

            static void SSA_UnknownAngleA(double A, double B, double AngleB)
            {
                double AngleA = Rad2Degrees(Math.Asin((A / B) * Math.Sin(Degrees2Rad(AngleB))));
                bool isNaN = Double.IsNaN(AngleA);

                if (isNaN)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo Triangle!\n");
                    Console.ResetColor();
                }

                else
                {
                    double AngleA2 = 180 - AngleA;

                    if (180 < AngleA2)
                    {
                        DegreeResult(AngleA);
                    }

                    else
                    {
                        Console.WriteLine($"\nTwo Triangles!\nTriangle 1: {AngleA} degrees\nTriangle 2: {AngleA2} degrees");
                    }
                }
            }

            static void SSA_UnknownAngleB(double B, double A, double AngleA)
            {
                double AngleB = Rad2Degrees(Math.Asin((B / A) * Math.Sin(Degrees2Rad(AngleA))));
                bool isNaN = Double.IsNaN(AngleA);

                if (isNaN)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo Triangle!\n");
                    Console.ResetColor();
                }

                else
                {
                    double AngleB2 = 180 - AngleB;

                    if (180 < AngleB2)
                    {
                        DegreeResult(AngleB);
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nTwo Triangles!\nTriangle 1: {AngleB} degrees\nTriangle 2: {AngleB2} degrees");
                        Console.ResetColor();
                    }
                }
            }

        }



        //Law of Cosines
        static void LawOfCosines()
        {
            Console.Clear();
            ComputationTitleScreen("Law of Cosines");

            Console.WriteLine("It is used to find the remaining parts of an oblique triangle. To use the Law of Sines,\nthe values of the triangle given must be an SAS (Side-Angle-Side) or SSS (Side-Side-Side).\n");
            Console.WriteLine("The formula for the Law of Sines is:\n");
            Console.WriteLine("c^2 = a^2 + b^2 - 2ab cos C\n");
            Console.WriteLine("Where:");
            Console.WriteLine("C = Angle of C");
            Console.WriteLine("a = Side of A");
            Console.WriteLine("b = Side of B");
            Console.WriteLine("c = Side of C\n");


            ComputeOrNotMessage();
            string ComputeOrNot = Console.ReadLine();
            ComputeOrNot = ComputeOrNot.ToUpper();

            switch (ComputeOrNot)
            {
                case "YES":
                    break;
                case "NO":
                    ComputationScreen();
                    break;
                default:
                    {
                        InvalidInput();
                        LawOfSines();
                        break;
                    }
            }


            YellowText("\nIs your given an SAS or SSS?: ");
            string SASorSSS = Console.ReadLine();
            SASorSSS = SASorSSS.ToUpper();

            switch (SASorSSS)
            {
                case "SAS":
                    {
                        YellowText("\nSolving for the side.\n");
                        Console.Write("\nType the value of the Side of A: ");
                        double A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Type the value of the Angle of B: ");
                        double B = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Type the value of the Angle of C: ");
                        double AngleC = Convert.ToInt32(Console.ReadLine());
                        SideResult(SAS_UnknownC(A, B, AngleC));
                        break;
                    }

                case "SSS":
                    {
                        YellowText("\nSolving for the angle.\n");
                        Console.Write("\nType the value of the Side of A: ");
                        double A = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Type the value of the Side of B: ");
                        double B = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Type the value of the Side of C: ");
                        double C = Convert.ToInt32(Console.ReadLine());
                        SSS_UnknownAngleC(A, B, C);
                        break;
                    }


                default:
                    {
                        InvalidInput();
                        LawOfSines();
                        break;
                    }
            }


            PressEnter();
            LawOfSines();


            static double SAS_UnknownC(double A, double B, double AngleC)
            {
                double c = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2) - (2 * A * B * Math.Sin(Degrees2Rad(AngleC))));
                return c;
            }


            static void SSS_UnknownAngleC(double A, double B, double C)
            {
                double AngleC = Rad2Degrees(Math.Acos((Math.Pow(C, 2) - Math.Pow(A, 2) - Math.Pow(B, 2)) / (-2 * A * B)));


                bool isNaN = Double.IsNaN(AngleC);

                if (isNaN)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo Triangle!\n");
                    Console.ResetColor();
                }

                else
                {
                    DegreeResult(AngleC);
                }
            }



        }

    }




}
