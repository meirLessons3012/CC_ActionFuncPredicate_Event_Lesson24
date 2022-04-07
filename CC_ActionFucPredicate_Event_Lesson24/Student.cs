namespace CC_ActionFucPredicate_Event_Lesson24
{
    public class Student
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public BankDetails BankDetails { get; set; }
    }

    public class BankDetails
    {
        public int BankNo { get; set; }
        public int AccountNo { get; set; }
        public int Branch { get; set; }
    }

}