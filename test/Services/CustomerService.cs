namespace test.Services
{
    
    public class CustomerService
    {
        private List<string> customers = new List<string> { "Jhoan", "Jonathan", "Santiago" };

        public ICollection<string> GetCustomers(string name) {
            return customers.Where(customers => customers == name).ToList();
        }
<<<<<<< HEAD
        //cambio aca sjsjve rmkdekmedddd fjfjf
=======
        //cambio aca sjsjve rmkdekmeddddfrfrfr
>>>>>>> feaa29006e375be13e990c2eacc98b4ad6fc6c70
    }
}

