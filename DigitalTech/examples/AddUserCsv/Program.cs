class Program
{
    static string firstName, surname, gender;
    static int age, score, yearGroup;
    const int numDetails = 6;
    static string location = "users.csv";
    static int numUsers;
    static string[] User; //This is initialised during the readInFile() method
    static string[,] Users; //This is initialised during the readInFile() method

    public static void Main(string[] args)
    {
        // Read in the file
        ReadInFile();
        // Add the user
        AddUser();
    }

    static void AddUser()
    {

        Console.WriteLine("Welcome to add a new user!");

        do
        {
            Console.WriteLine("Enter first name");
            firstName = Console.ReadLine();
        }
        while (firstName == "");

        do
        {
            Console.WriteLine("Enter surname");
            surname = Console.ReadLine();
        }
        while (surname == "");

        do
        {
            Console.WriteLine("Enter gender ( E.G 'M' )");
            gender = Console.ReadLine();
        }
        while (gender.Length != 1);

        do
        {
            Console.WriteLine("Enter your age");
            age = Convert.ToInt16(Console.ReadLine());
        }
        while ((age < 11) || (age > 18));

        do
        {
            Console.WriteLine("Enter your score");
            score = Convert.ToInt16(Console.ReadLine());
        }
        while (score == 0);

        do
        {
            Console.WriteLine("Enter your year group");
            yearGroup = Convert.ToInt16(Console.ReadLine());
        }
        while ((yearGroup > 14) || (yearGroup < 8));

        // This stores the new users details in an array to enable us to copy into a new row in our new 2D array
        User = new string[numDetails] { firstName, surname, gender, age.ToString(), score.ToString(), yearGroup.ToString() };

        // Creates a new array one bigger than the current 2D array size preparing it for new addition
        string[,] newUsers = new string[numUsers + 1, numDetails];

        for (int i = 0; i < Users.GetLength(0); i++)
        {
            for (int j = 0; j < numDetails; j++)
            {
                newUsers[i, j] = Users[i, j]; //This populates the new 2D array with the contents of the existing 2D array
            }
        }


        // add a new user to the end of newUsers
        for (int j = 0; j < numDetails; j++)
        {
            newUsers[numUsers, j] = User[j];
        }


        WriteToFile(newUsers);
    }

    //This will write the newUsers 2D array to file
    static void WriteToFile(string[,] newUsers)
    {
        try
        {
            //This creates a StreamWriter object sw through which you can funnel data to the CSV file
            using (StreamWriter sw = new StreamWriter(location))
            {
                for (int i = 0; i < newUsers.GetLength(0); i++)
                {
                    for (int j = 0; j < newUsers.GetLength(1); j++)
                    {
                        sw.Write(newUsers[i, j] + ",");
                    }
                    sw.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("The following error occured: {0}", ex.ToString());
            ReadInFile();
            AddUser();
        }
        Console.WriteLine("User file has been updated");
        ReadInFile();//It reads in the file again with the new user details into the array

    }

    static void ReadInFile()
    {
        string[] ReadInData = File.ReadAllLines(location); //This will read each row from CSV file into each location in the array as an entire string
        numUsers = ReadInData.Length; // Get length of ReadInData
        Users = new string[numUsers, numDetails]; //This will initialise the 2D array to the required size
        string[] tempUser = new string[numDetails]; //This will store the user during each iteration of the loop

        for (int i = 0; i < numUsers; i++)
        {
            tempUser = ReadInData[i].Split(','); //.Split will chop each row from the rawData array by ','
            for (int j = 0; j < numDetails; j++)
            {
                Users[i, j] = tempUser[j]; //This write the array to the 2D array
            }
        }
        Console.WriteLine("File has been read in successfully.");
        Thread.Sleep(1000);
    }
}
