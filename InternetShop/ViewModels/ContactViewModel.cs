namespace InternetShop.ViewModels
{
    public class ContactViewModel
    {
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string WorkingHours { get; set; } = string.Empty;
        public string? UserName { get; set; }
    }
}