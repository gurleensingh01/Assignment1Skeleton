using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Performs Checkout
        /// </summary>

        public override void Checkout()
        {
            Console.Write("Enter the item number of an appliance: \n\t");
            long itemNumber = (long)Convert.ToDouble(Console.ReadLine());

            Appliance foundAppliance = null;

            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }

            }
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.\n");
            }
            else if (foundAppliance.IsAvailable)
            {
                foundAppliance.Checkout();
                Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.\n");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.\n");
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.Write("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            string brand = Console.ReadLine();

            // Create list to hold found Appliance objects

            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
                // Test current appliance brand matches what user entered
                    // Add current appliance in list to found list

            foreach (Appliance appliance in Appliances) 
            {
                if (appliance.Brand == brand)
                {
                    found.Add(appliance);
                }
            }


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);

            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            Console.WriteLine("Enter number of doors: 2 (double door, 3 (three doors) or 4 (four doors)");
            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int numOfDoors = Convert.ToInt32(Console.ReadLine());

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (Appliance app in Appliances) //List is place holder name
            {
                // Test that current appliance is a refrigerator
                if (app is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator fridge = (Refrigerator)app;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (numOfDoors == 0 | fridge.Doors == numOfDoors)
                    {
                        // Add current appliance in list to found list
                        found.Add(fridge);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");

            // Write "Enter grade:"
            Console.Write("Enter grade: ");

            // Get user input as string and assign to variable
            string option = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;

            // Test input is "0"
            // Assign "Any" to grade

            if (option == "0")
            {
                grade = "Any";
            }
            // Test input is "1"
            // Assign "Residential" to grade

            else if (option == "1")
            {
                grade = "Residential";
            }
            // Test input is "2"
            // Assign "Commercial" to grade

            else if (option == "2")
            {
                grade = "Commercial";
            }
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            else
            {
                Console.WriteLine("Invalid Output");
                return;
            }


            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.Write("Enter voltage:");

            // Get user input as string
            // Create variable to hold voltage

            string volt = Console.ReadLine();
            int voltage;

            // Test input is "0"
            // Assign 0 to voltage
            if (volt == "0")
            {
                voltage = 0;
            }

            // Test input is "1"
            // Assign 18 to voltage

            else if (volt == "1")
            {
                voltage = 18;
            }

            // Test input is "2"
            // Assign 24 to voltage

            else if (volt == "2")
            {
                voltage = 24;
            }

            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            else
            {
                Console.WriteLine("Invalid Option.");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            foreach (Appliance appliance in Appliances) 
            {
                if (appliance is Vacuum) 
                {
                    Vacuum vacuum = (Vacuum)appliance;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    // Add current appliance in list to found list

                    if ((vacuum.Grade == "Any" || vacuum.Grade == grade) && (vacuum.BatteryVoltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        found.Add(vacuum);
                    }
                }
            }


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);

            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {


            // Code written to align with provided sample output
            // Display options.
            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");

            // Get user input as char
            char roomType = Convert.ToChar(Console.ReadLine());

            // Check if inputted room type is invalid.
            if (roomType != 'K' && roomType != 'W')
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling method
                return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance app in Appliances) //Placeholder name
            {
                // Test current appliance is Microwave
                if (app is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)app;

                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' | roomType == microwave.RoomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(microwave);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr(Quieter), Qu(Quiet) or M (Moderate): \n    ");
            string optionSelected = Console.ReadLine();

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher washer = (Dishwasher)appliance;

                    if (optionSelected == "Any" | washer.SoundRating == optionSelected)
                    {
                        found.Add(washer);
                    }
                }
            }
            Console.WriteLine("Matching dishwashers:");
            DisplayAppliancesFromList(found, 0);
        }
        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Code written to match instructions in file: 
          
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("0 - Any\n1 - Refrigerators\n2 - Vacuums\n3 - Microwaves\n4 - Dishwashers");
            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");
            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();
 
 
            // Create variable to hold list of found appliances
            List<Appliance> randomFound = new List<Appliance>();
 
            // Loop through appliances
            foreach (Appliance app in Appliances)
            {
                switch (applianceType)
                {
                    // Test inputted appliance type is "0"
                    case "0":
                        // Add current appliance in list to found list
                        randomFound.Add(app);
                        break;
 
                    // Test inputted appliance type is "1"
                    case "1":
                        // Test current appliance type is Refrigerator
                        if (app is Refrigerator)
                        {
                            // Add current appliance in list to found list
                            randomFound.Add(app);
                        }
                        break;
 
                    // Test inputted appliance type is "2"
                    case "2":
                        // Test current appliance type is Vacuum
                        if (app is Vacuum)
                        {
                            // Add current appliance in list to found list
                            randomFound.Add(app);
                        }
                        break;
 
                    // Test inputted appliance type is "3"
                    case "3":
                        // Test current appliance type is Microwave
                        if (app is Microwave)
                        {
                            // Add current appliance in list to found list
                            randomFound.Add(app);
                        }
                        break;
 
                    // Test inputted appliance type is "4"
                    case "4":
                        // Test current appliance type is Dishwasher
                        if (app is Dishwasher)
                        {
                            // Add current appliance in list to found list
                            randomFound.Add(app);
                        }
                        break;   
                }
            }

            // Code written to match sample output

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances:");
            // Get user input as string and assign to variable
            // Convert user input from string to int
            int randomNum = Convert.ToInt32(Console.ReadLine());

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Add the appliances to a found list so they they can be randomly resorted without it affecting the original list of appliances
            foreach (Appliance app in Appliances)
            {
                found.Add(app);
            }

            // Randomize list of found appliances
            randomFound.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(randomFound, randomNum);
        }
    }
}
