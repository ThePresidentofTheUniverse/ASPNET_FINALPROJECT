namespace FinalProject_ABBOTT.Models
{
    //The class for the filters
    public class Filters
    {
        public Filters(string filterString)
        {
            FilterString = filterString ?? "-1|-1|-1";
            string[] filters = FilterString.Split('|');
            DivisionID = int.TryParse(filters[0], out var d) ? d : -1;
            SchoolID = int.TryParse(filters[1], out var s) ? s : -1;
            CheckedStatus = filters[2];
        }

        public string FilterString { get; }
        public int DivisionID { get; }
        public int SchoolID { get; }
        public string CheckedStatus { get; }

        public bool HasDivisionID => DivisionID != -1;
        public bool HasSchoolID => SchoolID != -1;
        public bool HasCheckedStatus => CheckedStatus != "-1";

        public static Dictionary<string, string> CheckedFilterValues =>
            new Dictionary<string, string>
            {
                {"true", "True" },
                {"false", "False"},
            };
        public bool IsTrue => CheckedStatus.ToString() == "true";
        public bool IsFalse => CheckedStatus.ToString() == "false";

    }
}
