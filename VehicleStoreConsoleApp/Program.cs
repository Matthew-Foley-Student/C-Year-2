/*
 * Matthew Foley
 * CST - 250
 * 9/29/2025
 * Vehicle Class Library
 * Activity 1
 */
using System.Runtime.CompilerServices;
using VehicleClassLibrary.Models;
using VehicleClassLibrary.Services.BuisnessLogicLayer;


//----------------------------------------
//Starting Method
//------------------------------------------

Console.WriteLine("Welcome to the shop! To begin, select some vehicles to add to your inventory, and once they are proccessed, you can add some of them to you cart. When your finished you can proceed to the checkout and calculate it will calculate your price.");
ControlLoop();
//-------------------------------------------
//End of the Main Method
//------------------------------------------

//Read an Integer Input From the User
static int ReadChoice()
{
    //Declare and Initilize
    string? input = "";
    int choice = -1;
    //Loop the choice until a valid option is chosen
    while(choice == -1)
    {
        Console.Write("Choose and Action: \n0) Quit \n1) Print Inventory \n2) Print Shopping Cart" +
            "\n3)" +
            "Create a New Vehicle \n4) Add a Pre-Existing Vehicle To Shopping Cart \n5 Checkout \n6 Save Current Inventory To Text File" +
            "\n7) Load A Text File Inventory \nInput: ");

        //----------------------------------------------------------------------------------
        //Reade the input from the console
        input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            try
            {
                //parse the input that is given to make sure it is valid
                choice = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ensure that the input was a valid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ensure that the entered input is not to large or to small");
            }
            catch(Exception exp)
            {
                Console.WriteLine("THere was an excpetion " + exp + "Please try again.");
            }
        }
    }
    //return the input
    return choice;
}
//End of the Input to Console
//------------------------------------------------------------------------------------------------------------

//-----------------------------------------------------------------------------------------------------------
//Control the Car Loop
static void ControlLoop()
{
    //Create the Store Logic
    StoreLogic storeLogic = new StoreLogic();
    //Declare and Initilaze the other variables
    int choice = -1, id = 0, year = 0, numWheels = 0;
    string make = "", model = "";
    decimal price = 0m, total = 0m;
    //Remember to keep the specialty vairibles sperate to make codeing easier
    bool IsConvertible = false, hasSideCar = false, hasBedCover = false;
    decimal trunkSize = 0m, seatHeight = 0m, bedSize = 0m;
    List<VehicleModel> vehicleList = new List<VehicleModel>();
    VehicleModel vehicle = new VehicleModel();

    //Make sure to only leave this loop when the user wants to leave it
    while (choice != 0)
    {
        choice = ReadChoice();

        //use the switch command to cycle options
        switch (choice)
        {
            //Exit command
            case 0:
                Console.WriteLine("Have a Greate Day");
                break;

                // Print Inventory
            case 1:
                vehicleList = storeLogic.GetInventory();
                Console.WriteLine("Inventory: ");
                foreach (VehicleModel inventoryVehicle in vehicleList)
                {
                    Console.WriteLine(inventoryVehicle);
                }
                Console.WriteLine();
                break;

                //Print the Shopping Cart
            case 2:
                vehicleList = storeLogic.GetShoppingCart();
                Console.WriteLine("Shopping Cart: ");
                foreach(VehicleModel shoppingCartVehicle in vehicleList)
                {
                    Console.WriteLine(shoppingCartVehicle);
                }
                Console.WriteLine();
                break;

                //Creat A New Vehicle
            case 3:
                Console.Write("Enter 1 to create a Car, 2 to create a MotorCycle, 3 to create a Pickup Truck, or 4 for an Unmodified Car: ");
                choice = int.Parse(Console.ReadLine());

                //start the write up for the car's specifications
                Console.Write("Enter the Make for the vehicle: ");
                make = Console.ReadLine(); ;
                Console.Write("Enter the Model of the vehicle: ");
                model = Console.ReadLine();
                //rememeber to parse and stop errors when they are able to show up
                Console.Write("Enter the Year of the Vehicle: ");
                year = int.Parse(Console.ReadLine());
                Console.Write("Enter the Price of the vehicle: ");
                price = decimal.Parse(Console.ReadLine());
                Console.Write("Enter the number of Wheels the vehicle has: ");
                numWheels = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Use a switch statement for the previosly asked car specialties
                switch (choice)
                {
                    //Case set for Car's
                    case 1:
                        Console.Write("Enter Either True or False to the following question: Is the car a Convertable?: ");
                        IsConvertible = bool.Parse(Console.ReadLine());
                        Console.Write("Enter the Size of the tunk the car has (in cubic feet): ");
                        trunkSize = decimal.Parse(Console.ReadLine());
                        //Finish the Car creation
                        vehicle = new CarModel(id, make, model, year, price, numWheels, IsConvertible, trunkSize);
                        break;

                    //Case set for Motorcycles
                    case 2:
                        Console.Write("Enter True or False to the following question: does the Motorcycle have a Side-Car?: ");
                        hasSideCar = bool.Parse(Console.ReadLine());
                        Console.Write("Enter the Height of the MotorCycle in Inches: ");
                        seatHeight = decimal.Parse(Console.ReadLine());
                        //Finish the Motorcycle creation
                        vehicle = new MotorCycleModel(id, make, model, year, price, numWheels, hasSideCar, seatHeight);
                        break;

                    //Case set for Pickup Trucks
                    case 3:
                        Console.Write("Enter True or False to the following question: does the Pickup-Truck have a Bed Cover?: ");
                        hasBedCover = bool.Parse(Console.ReadLine());
                        Console.Write("Enter the size the Truck Bed is (in Inches): ");
                        bedSize = decimal.Parse(Console.ReadLine());
                        //finished the Pickup-Truck creation
                        vehicle = new PickupModel(id, make, model, year, price, numWheels, hasBedCover, bedSize);
                        break;

                    //Default Vehicle
                    default:
                        vehicle = new VehicleModel(id, make, model, year, price, numWheels);
                        break;
                }
                //add the newly created vehicle to the list for the inventory
                storeLogic.AddVehicleToInventory(vehicle);
                Console.WriteLine();
                break;

                //Add a Pre-Exisiting Vehicle To The SHopping List
            case 4:
                Console.Write("Enter the Car ID of the vehicle you wish to add to the Shopping Cart: ");
                //remember to parse to avoid errors
                id = int.Parse(Console.ReadLine());
                storeLogic.AddVehicleToCart(id);
                Console.WriteLine();
                break;

                //Checkout
            case 5:
                total = storeLogic.Checkout();
                Console.WriteLine("Your total comes to: $" + total);
                Console.WriteLine();
                break;

                //Save The Current Inventory To A Text File
            case 6:
                storeLogic.WriteInventory();
                Console.WriteLine("The Inventory has been saved to the text file");
                Console.WriteLine();
                break;

                //Load A Pre-Existing File
            case 7:
                storeLogic.ReadInventory();
                Console.WriteLine("The inventory from the text file has been read into the internal inventory");
                Console.WriteLine();
                break;

                //Non-Existing Input
            default:
                Console.WriteLine("Invalid Choice");
                Console.WriteLine();
                break;

        }
    }
}
//End of the Controled Loop
//----------------------------------------------------------------------------------------------