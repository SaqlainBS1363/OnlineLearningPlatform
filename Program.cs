using System.Security.Cryptography.X509Certificates;

namespace OnlineLearningPlatform
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var userList = new List<User>();
            var courseList = new List<Courses>();

            Console.WriteLine("---- Online Learning Platform ----");
            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("\nLogin as 1. Admin, 2. User or 3. Exit\n");
                int loginChoice = Convert.ToInt32(Console.ReadLine());

                if (loginChoice == 1)
                {
                    Console.Write("Enter Admin ID: ");
                    string adminId = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string adminPass = Console.ReadLine();

                    if (adminId.Equals("admin") && adminPass.Equals("1234"))
                    {
                        Console.WriteLine("\n\nWelcome Admin\n\n");

                        while (true)
                        {
                            Console.WriteLine("Choose options: \n1. Check users \n2. Add course \n3. Log out.\n");

                            int adminChoice = Convert.ToInt32(Console.ReadLine());

                            if (adminChoice == 1)
                            {
                                Console.WriteLine("Currently registered users: \n");
                                foreach (var user in userList)
                                {
                                    Console.Write("User ID: " + user.getuserId() + " | "
                                    + "Name: " + user.getuserName() + " | "
                                    + "Email: " + user.getemail() + "\n");
                                }
                                Console.WriteLine("\n----------\n");
                            }
                            else if(adminChoice == 2)
                            {
                                Console.WriteLine("Adding course - \n");
                                string cId, cName, cTopic;
                                int cPrice = 0;

                                Courses newCourse = new Courses();

                                Console.Write("Enter Course ID: ");
                                cId = Console.ReadLine();

                                Console.Write("Enter Course Name: ");
                                cName = Console.ReadLine();

                                Console.Write("Enter Course Topic: ");
                                cTopic = Console.ReadLine();

                                Console.Write("Enter Course Price: ");
                                cPrice = Convert.ToInt32(Console.ReadLine());

                                newCourse.setcourseID(cId);
                                newCourse.setcourseName(cName);
                                newCourse.setcourseTopic(cTopic);
                                newCourse.setcoursePrice(cPrice);

                                courseList.Add(newCourse);

                                Message m1 = new Message();

                                m1.GenerateRespectiveMsg();

                            }
                            else if(adminChoice == 3)
                            {
                                Console.WriteLine("Logging out of Admin Panel\n");
                                break;
                            }
                            else 
                            { 
                                Console.WriteLine("Wrong choice!"); 
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong credentials!\n");
                    }
                }
                else if(loginChoice == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter choice: \n1. Sign up  \n2. Log in \n3. Exit \n");

                        int userchoice = Convert.ToInt32(Console.ReadLine());

                        if (userchoice == 1)
                        {
                            Console.WriteLine("\nUser sign up - \n");

                            Console.Write("Enter Name: ");
                            string uName = Console.ReadLine();

                            Console.Write("Enter Email: ");
                            string uEmail = Console.ReadLine();

                            Console.Write("Enter Password: ");
                            string uPassword = Console.ReadLine();

                            User newUser = new User();
                            newUser.setuserName(uName);
                            newUser.setemail(uEmail);
                            newUser.setpassword(uPassword);
                            Random rnd = new Random();
                            newUser.setuserId(uEmail + rnd.Next(1000).ToString());

                            userList.Add(newUser);
                            Console.WriteLine("\n\nNew user added!\n\n");
                        }
                        else if (userchoice == 2)
                        {
                            Console.Write("Enter User Email: ");
                            string userEmail = Console.ReadLine();

                            Console.Write("Enter User Password: ");
                            string userPass = Console.ReadLine();

                            int gotUser = 0;
                            User user1 = new User();

                            foreach (var user in userList)
                            {
                                if (user.getemail().Equals(userEmail) && user.getpassword().Equals(userPass))
                                {
                                    user1 = user;
                                    gotUser = 1; break;
                                }
                            }

                            if (gotUser == 1)
                            {
                                Console.WriteLine("\n\nWelcome " + user1.getuserName() + "\n\n");

                                while (true)
                                {
                                    Console.WriteLine("Choose options: \n1. Check courses \n2. Buy course \n3. Log out.\n");

                                    int userChoice = Convert.ToInt32(Console.ReadLine());

                                    if (userChoice == 1)
                                    {
                                        Console.WriteLine("Available courses are: \n\n");

                                        foreach (var crs in courseList)
                                        {
                                            Console.WriteLine("Course ID: " + crs.getcourseID() + " | "
                                            + "Course Name: " + crs.getcourseName() + " | "
                                            + "Course Topic: " + crs.getcourseTopic() + " | "
                                            + "Course Price: " + crs.getcoursePrice() + "\n");
                                        }
                                        Console.WriteLine("\n----------\n");
                                    }
                                    else if (userChoice == 2)
                                    {
                                        Console.Write("\nEnter Course ID: ");
                                        string cId = Console.ReadLine();

                                        int foundCourse = 0;

                                        foreach (var crs in courseList)
                                        {
                                            if (crs.getcourseID() == cId)
                                            {
                                                foundCourse = 1;
                                                break;
                                            }
                                        }

                                        if (foundCourse == 1)
                                            Console.WriteLine("Course Bought!\n");
                                        else
                                            Console.WriteLine("Course not found!\n");
                                    }
                                    else if (userChoice == 3)
                                    {
                                        Console.WriteLine("You are being logged out!\n");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid entry!\n");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No user found with these credentials!\n");
                            }
                        }
                        else if(userchoice == 3)
                        {
                            Console.WriteLine("User program exit!\n");
                            break;
                        }
                    }
                }
                else if (loginChoice == 3)
                {
                    Console.WriteLine("Program exits\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong choice!\n");
                }
            }
        }
    }
}