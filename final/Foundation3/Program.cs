using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Popular Street", "Cool City", "Awesome","USA");
        Lecture lecture = new Lecture(
            "John Doe", 
            300, 
            "How to Stand Out", 
            "Join us to hear about John Doe's revolutionary approach to making a name for yourself.", 
            "9/35/2024", 
            "4:15pm", 
            address1
            );


        Address address2 = new Address("345 Unknown Street", "Mysterious City", "Hidden","Secret Country");
        Reception reception = new Reception(
            "johnandjane4ever@gmail.com", 
            "John & Jane's Wedding Reception", 
            "Join us in celebrating the union of John and Jane Doe for time and all eternity.", 
            "11/31/2024", 
            "3:23pm", 
            address2
            );
   

        Address address3 = new Address("678 Home Street", "Backwoods City", "Old West","USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Cloudy (with a chance of raining food)",
            "\"Cloudy with a Chance of Meatballs\" Movie in the Park Night", 
            "Come see a childhood favorite film at the Backwoods City Park while eating your favorite foods.", 
            "7/25/2024", 
            "7:00pm (Movie starts at dusk)", 
            address3
            );
        

        
        Console.Clear();
        Console.WriteLine("~~~ EVENT 1 ~~~\n");
        Console.WriteLine("- SHORT DESCRIPTION -");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n- STANDARD DETAILS -");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n- FULL DETAILS -");
        Console.WriteLine(lecture.GetFullDetails());


        Console.WriteLine("\n\n\n~~~ EVENT 2 ~~~\n");
        Console.WriteLine("- SHORT DESCRIPTION -");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n- STANDARD DETAILS -");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n- FULL DETAILS -");
        Console.WriteLine(reception.GetFullDetails());


        Console.WriteLine("\n\n\n~~~ EVENT 3 ~~~\n");
        Console.WriteLine("- SHORT DESCRIPTION -");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("\n- STANDARD DETAILS -");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\n- FULL DETAILS -");
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.WriteLine("\n\n!!! Buy YOUR tickets NOW at awesomeevent.com !!!\n\n\n");
    }
}