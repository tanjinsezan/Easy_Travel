using BLL.BO;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProjeect.Controllers
{
    public class BookingDetailController : ApiController
    {
        [Route("api/BookingDetail/All")]
        [HttpGet]
        public List<BookingDetailModel> GetAll()
        {
            return BookingDetailService.Get();
        }
        [Route("api/BookingDetail/Create")]
        [HttpPost]
        public HttpResponseMessage Create(BookingDetailModel r)
        {
            BookingDetailService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/BookingDetail/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = BookingDetailService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/BookingDetail/update")]
        [HttpPost]
        public HttpResponseMessage Update(BookingDetailModel r)
        {
            BookingDetailService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/BookingDetail/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            BookingDetailService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}

...........


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