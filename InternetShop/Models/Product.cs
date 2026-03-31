using System.ComponentModel.DataAnnotations;

namespace InternetShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле 'Название' обязательно для заполнения")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Название должно содержать от 2 до 100 символов")]
        [Display(Name = "Название товара")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле 'Цена' обязательно для заполнения")]
        [Range(0.01, 1000000, ErrorMessage = "Цена должна быть от 0.01 до 1 000 000 руб.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Поле 'Описание' обязательно для заполнения")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Описание должно содержать от 10 до 500 символов")]
        [Display(Name = "Описание товара")]
        public string Description { get; set; } = string.Empty;
    }
}