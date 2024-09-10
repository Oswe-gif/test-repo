namespace test.Services
{
    
    public class CustomerService
    {
        private List<string> customers = new List<string> { "Jhoan", "Jonathan", "Santiago" };

        public ICollection<string> GetCustomers(string name) {
            return customers.Where(customers => customers == name).ToList();
        }

    }
}

