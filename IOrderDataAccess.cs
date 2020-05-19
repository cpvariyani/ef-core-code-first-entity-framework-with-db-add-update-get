using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.ViewModel;

namespace WebApplication2.Infra
{
    public interface IOrderDataAccess
    {
        List<OrderModel> GetAllOrder();

        void SaveOrder(OrderModel order);
    }
}
