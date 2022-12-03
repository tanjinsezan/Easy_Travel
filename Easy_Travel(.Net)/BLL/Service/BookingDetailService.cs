using AutoMapper;
using BLL.BO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class BookingDetailService
    {
        public static List<BookingDetailModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<BookingDetail, BookingDetailModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<BookingDetailModel>>(DataAccessLayer.GetBookingDetailsDataAccess().Get());
            return data;
        }
        public static void Create(BookingDetailModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookingDetailModel, BookingDetail>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BookingDetail>(r);
            DataAccessLayer.GetBookingDetailsDataAccess().Create(data);
        }
        public static BookingDetailModel GetOnly(int id)
        {
            var Data = DataAccessLayer.GetBookingDetailsDataAccess().Get(id);
            var d = new BookingDetailModel() { BookingDetailId = Data.BookingDetailId, BookingId = Data.BookingId, ItemId = Data.ItemId, Quantity = Data.Quantity, UnitPrice = Data.UnitPrice, Total = Data.Total };
            return d;

        }
        public static void Update(BookingDetailModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookingDetailModel, BookingDetail>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BookingDetail>(r);
            DataAccessLayer.GetBookingDetailsDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessLayer.GetBookingDetailsDataAccess().Delete(id);
        }
    }
}



public class HotelBookingController : ApiController
{
    [Route("api/HotelBooking/All")]
    [HttpGet]
    public List<HotelBookingModel> GetAll()
    {
        return HotelBookingService.Get();
    }
    [Route("api/HotelBooking/Create")]
    [HttpPost]
    public HttpResponseMessage Create(HotelBookingModel r)
    {
        HotelBookingService.Create(r);
        return Request.CreateResponse(HttpStatusCode.OK, "Created");
    }
    [Route("api/HotelBooking/{id}")]
    [HttpGet]
    public HttpResponseMessage Get(int id)
    {
        var data = HotelBookingService.GetOnly(id);
        return Request.CreateResponse(HttpStatusCode.OK, data);
    }
    [Route("api/HotelBooking/update")]
    [HttpPost]
    public HttpResponseMessage Update(HotelBookingModel r)
    {
        HotelBookingService.Update(r);
        return Request.CreateResponse(HttpStatusCode.OK, "Updated");

    }
    [Route("api/HotelBooking/delete/{id}")]
    [HttpDelete]
    public HttpResponseMessage Delete(int id)
    {
        HotelBookingService.Delete(id);
        return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
    }
}


public class VehicleBookingController : ApiController
{
    [Route("api/VehicleBooking/All")]
    [HttpGet]
    public List<VehicleBookingModel> GetAll()
    {
        return VehicleBookingService.Get();
    }
    [Route("api/VehicleBooking/Create")]
    [HttpPost]
    public HttpResponseMessage Create(VehicleBookingModel r)
    {
        VehicleBookingService.Create(r);
        return Request.CreateResponse(HttpStatusCode.OK, "Created");
    }
    [Route("api/VehicleBooking/{id}")]
    [HttpGet]
    public HttpResponseMessage Get(int id)
    {
        var data = VehicleBookingService.GetOnly(id);
        return Request.CreateResponse(HttpStatusCode.OK, data);
    }
    [Route("api/VehicleBooking/update")]
    [HttpPost]
    public HttpResponseMessage Update(VehicleBookingModel r)
    {
        VehicleBookingService.Update(r);
        return Request.CreateResponse(HttpStatusCode.OK, "Updated");

    }
    [Route("api/VehicleBooking/delete/{id}")]
    [HttpDelete]
    public HttpResponseMessage Delete(int id)
    {
        VehicleBookingService.Delete(id);
        return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
    }
}
