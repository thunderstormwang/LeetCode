namespace WebRequest
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int customerId);
    }
}
