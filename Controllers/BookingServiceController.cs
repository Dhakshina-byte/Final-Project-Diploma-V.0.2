using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class BookingServiceController
    {
        private ServiceBookingService bookingRepository = new ServiceBookingService();

        public void AddServiceBooking(ServiceBooking booking)
        {
            bookingRepository.InsertServiceBooking(booking);
        }

        public void UpdateServiceBooking(ServiceBooking booking)
        {
            bookingRepository.UpdateServiceBooking(booking);
        }

        public void RemoveServiceBooking(int bookingId)
        {
            bookingRepository.DeleteServiceBooking(bookingId);
        }
    }
}
