using DAL.EF;
using DAL.Interface;
using DAL.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        static DholidayDBEntities db = new DholidayDBEntities();

        public static IRepo<CusLogin, int> GetCusLoginDataAccess()
        {
            return new CusLoginRepo(db);
        }
        public static IRepo<BookingDetail, int> GetBookingDetailsDataAccess()
        {
            return new BookingDetailsRepo(db);
        }
    }
}
