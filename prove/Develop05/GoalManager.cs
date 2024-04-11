public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu Options: \n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a choice from the menu: ");
                int response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
               CreateGoal();
            }

            else if (response == 2)
            {
                ListGoalNames();
                ListGoalDetails();
            }

            else if (response == 3)
            {
                SaveGoals();  
            }

            else if (response == 4)
            {
                LoadGoals();
            }
            else if (response == 5)
            {
                RecordEvent();
            }
            else if (response == 6)
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Please choose an option from the menu (1-6).");
            }
            }
    }    

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}