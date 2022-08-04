using Microsoft.AspNetCore.Components;

namespace Goals.Components
{
    public partial class Goal
    {
        public Goal()
        {
            GoalStatus = Status.Undone;
        }
        Status GoalStatus { get; set; }

        [Parameter]
        public string GoalText { get; set; }

        enum Status
        {
            Undone,
            Started,
            Done
        }

        private void OnStatusChanged(ChangeEventArgs e)
        {
            switch (e.Value.ToString())
            {
                case "Undone":
                    GoalStatus = Status.Undone;
                    break;
                case "Started":
                    GoalStatus = Status.Started;
                    break;
                case "Done":
                    GoalStatus = Status.Done;
                    break;
                default:
                    throw new Exception("Impossible GoalStatus");
            }
            GetStatusColor();
        }

        public string GetStatusColor()
        {
            switch (GoalStatus)
            {
                case Status.Undone:
                    return "red";
                case Status.Started:
                    return "gold";
                case Status.Done:
                    return "green";
                default:
                    return "white";
            }
        }       
    }
    
}
