namespace Queueing_Management_System.ViewModel

{
    public class BookingViewModel
    {

        //department
        public int TransactionId { get; set; }
        public string TransactionName { get; set; }


        public int BookingId { get; set; }
        public string BookingDate { get; set; }
        public string Status { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public int? Age { get; set; }
        public string Prioritynumber { get; set; }
        public string ValidId { get; set; }
        public string Gmail { get; set; }
    }
}