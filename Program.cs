namespace OnlineLearningPlatform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userList = new List<User>();
            var courseList = new List<Courses>();

            Console.WriteLine("-- Online Learning Platform --");
            Console.WriteLine("\n\n");

            while (true)
            {
                Console.WriteLine("Login as 1. Admin, 2. User or 3. Exit\n");
                int loginChoice = Convert.ToInt32(Console.ReadLine());

                if (loginChoice == 1)
                {
                    Console.Write("Enter AdminID: ");
                    string adminId = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string adminPass = Console.ReadLine();

                    if (adminId.Equals("admin") && adminPass.Equals("1234"))
                    {
                        Console.WriteLine("\n\nWelcome Admin\n\n");
                        Console.WriteLine("Choose options: \n1. Check users \n2.Add course \n3. Log out.\n");

                        int adminChoice = Convert.ToInt32(Console.ReadLine());
                        if (adminChoice == 1) { 

                            foreach(var user in userList)
                            {
                                Console.Write("User ID: " + user.getuserId());
                                Console.Write("User Name: " + user.getuserName());
                                Console.Write("User Email: " + user.getemail());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error\n");
                            break;
                        }
                    }
                }
                else if(loginChoice == 2)
                {

                }
                else
                {
                    break;
                }


                Console.WriteLine("Enter choice: \n1.Sign up  \n2.Log in\n\n");

                int choice = Convert.ToInt32(Console.ReadLine());

            }


        }
    }
}