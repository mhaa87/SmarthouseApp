namespace SmartHouseWebApp.Models{
    public class Light
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }

        public string GetStateText(){
            return IsOn ? "On" : "Off";
        }
    }
    
    }