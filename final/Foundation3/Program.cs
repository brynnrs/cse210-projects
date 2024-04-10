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
            "itsSnotMe@mucus.uk", 
            "Nose Blowing Competition", 
            "This is a reception for the great Barnabus the Great. Ruler of running noses", 
            "11/31/2024", 
            "3:23pm", 
            address2
            );
   


        Address address3 = new Address("678 Home Street", "Backwoods City", "Old West","USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "The Gloomiest of Days",
            "Outdoor Musical: The Play: The Musical: The Play: The Sequel: Electric Boogaloo", 
            "The sequel to the original play about a musical about a play about an outdoor musical", 
            "4 score and 7 seven years ago", 
            "High Noon", 
            address3
            );
        
        
        List<Event> events = new List<Event>
        {
            lecture,
            reception,
            outdoorGathering
        };
        
        Console.Clear();
        Console.WriteLine("~~~ Short Description ~~~\n");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n(Press ENTER to View More Details)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("~~~ Standard Details ~~~\n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n(Press ENTER to View More Details)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("~~~ Full Details ~~~\n");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n(Press ENTER to View Next Event)");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("~~~ Short Description ~~~\n");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n(Press ENTER to View More Details)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("~~~ Standard Details ~~~\n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n(Press ENTER to View More Details)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("~~~ Full Details ~~~\n");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n(Press ENTER to View Next Event)");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("~~~ Short Description ~~~\n");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("\n(Press ENTER to View More Details)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("~~~ Standard Details ~~~\n");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\n(Press ENTER to View More Details)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("~~~ Full Details ~~~\n");
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.Clear();
        Console.WriteLine("Buy YOUR tickets NOW at awesomeevent.com!!!\n\n");
    }
}