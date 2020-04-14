using System;
namespace AccountsManager.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Street { get; set; }
        public string CityTown { get; set; }
        public string County { get; set; }
        public string PostCod { get; set; }
        public string Country { get; set; }
    }
}
