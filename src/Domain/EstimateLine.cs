using System;
namespace AccountsManager.Domain
{
    public class EstimateLine
    {
        public int Id { get; set; }
        public int EstimateId { get; set; }
        public ServiceType Service { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double VAT { get; set; }
    }
}
