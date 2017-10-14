using System.ComponentModel.DataAnnotations;

namespace PracticeCexV2.Web.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Quantity { get; set; }
    }
}