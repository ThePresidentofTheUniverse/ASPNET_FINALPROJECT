namespace FinalProject_ABBOTT.Models
{
    //The class that defines what a school is.
    public class School
    {
        //The PK
        public int SchoolID { get; set; }

        public string SchoolName { get; set; } = string.Empty;

        //Refers to Middle School, High School or College/Post-Secondary
        public string SchoolType {  get; set; } = string.Empty;

        //Where the school is located (does not use states, only city/town).
        public string Location {  get; set; } = string.Empty;

    }
}
