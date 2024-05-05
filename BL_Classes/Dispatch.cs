using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.BL_Classes
{
    public class Dispatch
    {
        public int DispatchID { get; set; }
        public DateTime DispatchDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TransportationID { get; set; }
        public Dispatch(int dispatchID, DateTime dispatchDate, decimal totalAmount, int transportationID)
        {
            DispatchID = dispatchID;
            DispatchDate = dispatchDate;
            TotalAmount = totalAmount;
            TransportationID = transportationID;
        }
        public Dispatch(DateTime dispatchDate, decimal totalAmount, int transportationID)
        {
            DispatchDate = dispatchDate;
            TotalAmount = totalAmount;
            TransportationID = transportationID;
        }
    }
}
