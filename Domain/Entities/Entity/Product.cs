using Domain.Entities.Base;
using Domain.Entities.Constant;

namespace Domain.Entities.Entity
{
    public class Product : DomainEntity
    {
        public Product()
        {
            State = (int)ConstantsDomain.Stock;
        }
        public string Name { get; set; }

        public void MarkOutlet()
        {
            State = (int)ConstantsDomain.Outlet;
        }

        public void MarkFaulty()
        {
            State = (int)ConstantsDomain.Faulty;
        }
    }
}
