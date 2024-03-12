namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormerViewModel
    {

        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
