namespace Commander.Models                                      //representation of the main data within the application
{
    public class Command{                                       //gets and sets for all values
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}