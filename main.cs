using System;

class Program {
  public static void Main (string[] args) {


                        // Variables    
    
    double[] array_temperatures = new double[5]; // Array of 5 temperatures
    double range_temperature; // Range of temperatures
    bool validtemperature; // Boolean variable validates temperature range
    bool up = true; // check if the temperature is increasing
    bool down = true; // check if the temperature is decreasing
    double sum = 0; // sum of the temperatures


// Loop for inputting temperatures... It loops between the temperatures and validates the temperature range. 
    for (int i = 0; i < 5; i++)
    {

        do
        {
            Console.Write("INPUT temperature: ");
          // Asks user to input temperature
          
          validtemperature = double.TryParse(Console.ReadLine(), out range_temperature); // Checks if the input is a valid temperature
         
          
            if (!validtemperature || range_temperature < -30 || range_temperature > 130)
            {
                Console.WriteLine("EXCEPTION Temperature "+ (range_temperature)+ " is invalid, Please enter a valid temperature between -30 and 130");
            }
        } // End of do while loop
      
      while (!validtemperature || range_temperature < -30 || range_temperature > 130);

      array_temperatures[i] = range_temperature;
    } // End of for loop


    
    for (int i = 1; i < array_temperatures.Length; i++)
    {
        if (array_temperatures[i] < array_temperatures[i - 1])
        {
            up = false;
        }
        else if (array_temperatures[i] > array_temperatures[i - 1])
        {
            down = false;
        } }// Loop for calculating the sum of the temperatures

  
    if (up)
    {
        Console.WriteLine("Getting warmer");
    }
    else if (down)
    {
        Console.WriteLine("Getting cooler");
    }
    else
    {
        Console.WriteLine("It's a mixed bag");
    }  // This prints out if the temperatures is getting warner of cooler using a if statement or if its a mixed.

    Console.Write("OUTPUT 5-day Temperature [");
    for (int i = 0; i < array_temperatures.Length; i++) // Loop for printing out the temperatures
    {
        Console.Write(array_temperatures[i]);
        if (i < array_temperatures.Length - 1)
        {
            Console.Write(", ");
        }
    } // End of for loop
    
    Console.WriteLine("]"); // This prints out the temperatures in the array


    foreach (double temp in array_temperatures) // Loop for calculating the sum of the temperatures
    
    {
        sum += temp; 
    } // This calculates the sum of the temperatures



    double averageTemperature = sum / array_temperatures.Length; // This calculates the average temperature by dividing the sum of the temperatures by the number of temperatures
    
    Console.WriteLine("OUTPUT Average Temperature is " + (averageTemperature)+ " degrees"); // This prints out the average temperature
  
}
  }