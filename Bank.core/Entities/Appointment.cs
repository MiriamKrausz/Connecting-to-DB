
namespace Bank.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Official> Officials { get; set; }

        //public Appointment(int id, DateTime date, List<Customer> customers, List<Official> officials)
        //{
        //    Id = id;
        //    Date = date;
        //    Customers = customers;
        //    Officials = officials;
        //}
    }
}
