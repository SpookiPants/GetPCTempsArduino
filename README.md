# GetPCTempsArduino
A C# Form .NET file that gets the cpu temp of computer, displays it on a custom made hardware monitor, sends the temperature to the com port, and then the Arduino receives it and displays it. (some lights and a buzzer go as well depending on the temperature)

1. Run visual studio as admin (if you dont its fine, the program will force you to relaunch as admin)
2. Verify and upload the Arduino file
3. Run the C# file
4. Pick and open the com port from the C# file (if you dont know which one it is, you can go to the arduino editor > tools > port > com#)

//IMPORTANT// - The arduino code must be ran before the C# connects to the port, otherwise, the port will be active and the arduino cannot pull any data from it
