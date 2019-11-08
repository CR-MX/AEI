using ResHotel.Models;
using System;
using System.Linq;
 
namespace ResHotel.Data
{
    public class DbInitializer
    {
        public static void Initializate(HotelContext context){
            context.Database.EnsureCreated();
            if(context.FacilitieLists.Any()){
                return; //la base de dats ya tiene datos 
            }

            // en caso de usar fechas usar,,,, FilmRelaseDate=DateTime.Parse("1/1/2018")

            var FacilitieList = new FacilitieList[]{
                    new FacilitieList{FacilityID=1,FacilityDesc="Todo Bien"},
                    new FacilitieList{FacilityID=2,FacilityDesc="Todo Correcto"},
                    new FacilitieList{FacilityID=3,FacilityDesc="Y Yo que me alegro"}

            };
            foreach(FacilitieList q in FacilitieList){context.FacilitieLists.Add(q);}
            context.SaveChanges();
            //Roomtypes
            var RoomType = new RoomType[]{
                new RoomType{RoomTypeID=1,RoomTypes="matrimonial"},
                new RoomType{RoomTypeID=2,RoomTypes="individual"},
                new RoomType{RoomTypeID=3,RoomTypes="litera"}
            };
            foreach(RoomType e in RoomType){context.RoomTypes.Add(e);}
            context.SaveChanges();
            //RoomBand
            var RoomBand = new RoomBand[]{
                new RoomBand{RoomBandID=1,BandDesc="sin inconvenientes"},
                new RoomBand{RoomBandID=2,BandDesc="En revision"},
                new RoomBand{RoomBandID=3,BandDesc="listo"}
            };
            foreach(RoomBand r in RoomBand){context.RoomBands.Add(r);}
            context.SaveChanges();
            //RoomPrice
            var RoomPrice = new RoomPrice[]{
                new RoomPrice{RoomPriceID=1,RoomPrices=1200},
                new RoomPrice{RoomPriceID=2,RoomPrices=2200},
                new RoomPrice{RoomPriceID=3,RoomPrices=3200}
            };
            foreach(RoomPrice t in RoomPrice){context.RoomPrices.Add(t);}
            context.SaveChanges();
            //Room
            var Room = new Room[]{
                new Room{RoomID=1,RoomTypeID=1,RoomBandID=1,RoomPriceID=1,Floor="planta baja"},
                new Room{RoomID=2,RoomTypeID=2,RoomBandID=2,RoomPriceID=2,Floor="planta media"},
                new Room{RoomID=3,RoomTypeID=3,RoomBandID=3,RoomPriceID=3,Floor="planta alta"}
            };
            foreach(Room y in Room){context.Rooms.Add(y);}
            context.SaveChanges();
            //RoomFacilitieList
            var RoomFacilitieList = new RoomFacilitieList[]{
                new RoomFacilitieList{FacilityID=1,RoomID=1,FacilityDetails="ningun inconveniente"},
                new RoomFacilitieList{FacilityID=2,RoomID=2,FacilityDetails="En revision"},
                new RoomFacilitieList{FacilityID=3,RoomID=3,FacilityDetails="Lista"}
            };
            foreach(RoomFacilitieList w in RoomFacilitieList){context.RoomFacilitieLists.Add(w);}
            context.SaveChanges();
            
            
            //Guest
            var Guest = new Guest[]{
                new Guest{GuestID=1,GuestTitle="Primero",GuestForenames="juan",GuestSurnames="lumbreras",GuestDOB=DateTime.Parse("1/1/2018"),GuestAddressCountry="México",GuestAddressTown="Zacatecas",GuestAddressStreet="Diaz Ordaz",GuestAddressPostaleCode="98000",GuestContactPhone="4291272323"},
                new Guest{GuestID=2,GuestTitle="Segundo",GuestForenames="Mario",GuestSurnames="Hernandez",GuestDOB=DateTime.Parse("2/2/2018"),GuestAddressCountry="México",GuestAddressTown="CDMX",GuestAddressStreet="Jaurez",GuestAddressPostaleCode="91000",GuestContactPhone="42912243323"},
                new Guest{GuestID=3,GuestTitle="Tercero",GuestForenames="Luis",GuestSurnames="Lopez",GuestDOB=DateTime.Parse("2/2/2018"),GuestAddressCountry="México",GuestAddressTown="Durango",GuestAddressStreet="Concepcion",GuestAddressPostaleCode="90000",GuestContactPhone="42912342323"}
            };
            foreach(Guest u in Guest){context.Guests.Add(u);}
            context.SaveChanges();
            //Customer
            var Customer = new Customer[]{
                new Customer{CustomerID=1,CustomerTitle="Primero",CustomerForenames="joaquin",CustomerSurnames="guzman",CustomerDOB=DateTime.Parse("1/1/2019"),CustomerAddressCountry="USA",CustomerAddressTown="Texas",CustomerAddressStreet="york",CustomerAddressPostalCode="81032",CustomerCustomEmail="joaquin@gmail.com",CustomerHomePhone="0180032343243"},
                new Customer{CustomerID=2,CustomerTitle="Segundo",CustomerForenames="Izela",CustomerSurnames="macera",CustomerDOB=DateTime.Parse("2/2/2019"),CustomerAddressCountry="USA",CustomerAddressTown="Denber",CustomerAddressStreet="johnson",CustomerAddressPostalCode="81340",CustomerCustomEmail="iZELA@gmail.com",CustomerHomePhone="01800324353"},
                new Customer{CustomerID=3,CustomerTitle="Tercero",CustomerForenames="Ariana",CustomerSurnames="Alonzo",CustomerDOB=DateTime.Parse("3/3/2019"),CustomerAddressCountry="USA",CustomerAddressTown="Chicago",CustomerAddressStreet="Clinton",CustomerAddressPostalCode="81023",CustomerCustomEmail="Ariana@gmail.com",CustomerHomePhone="0180032435345243"}

            };
            foreach(Customer i in Customer){context.Customers.Add(i);}
            context.SaveChanges();
            //PaymentMethod


            var PaymentMethod = new PaymentMethod[]{
                new PaymentMethod{PaymentMethodID=1,PaymentMethods="deposito"},
                new PaymentMethod{PaymentMethodID=2,PaymentMethods="OXXO"},
                new PaymentMethod{PaymentMethodID=3,PaymentMethods="MercadoPago"}
            };
            foreach(PaymentMethod o in PaymentMethod){context.PaymentMethods.Add(o);}
            context.SaveChanges();
            //Booking
            var Booking = new Booking[]{
                new Booking{BookingID=1,CustomerID=1,DateBookingMade=DateTime.Parse("1/1/2019"),TimeBookingMade="un dia", BookedStartDate=DateTime.Parse("3/2/2019"),BookedEndDate=DateTime.Parse("4/2/2019"),TotalPaymentDueAmount=200,TotalPaymentDueDate=DateTime.Parse("4/2/2019"),BookingComments="sin dificultades"},
                new Booking{BookingID=2,CustomerID=2,DateBookingMade=DateTime.Parse("2/2/2019"),TimeBookingMade="dos dias", BookedStartDate=DateTime.Parse("4/2/2019"),BookedEndDate=DateTime.Parse("6/2/2019"),TotalPaymentDueAmount=400,TotalPaymentDueDate=DateTime.Parse("4/2/2019"),BookingComments="sin comentarios"},
                new Booking{BookingID=3,CustomerID=3,DateBookingMade=DateTime.Parse("2/2/2019"),TimeBookingMade="tres dias", BookedStartDate=DateTime.Parse("5/2/2019"),BookedEndDate=DateTime.Parse("8/2/2019"),TotalPaymentDueAmount=600,TotalPaymentDueDate=DateTime.Parse("4/2/2019"),BookingComments="pago retrasado"}
            };
            foreach(Booking p in Booking){context.Bookings.Add(p);}
            context.SaveChanges();
            //Payment
            var Payment = new Payment[]{
                new Payment{PaymentID=1,BookingID=1,CustomerID=1,PaymentMethodID=1,PaymentAmount=100,PaymentComments="sin inconveniente"},
                new Payment{PaymentID=2,BookingID=2,CustomerID=2,PaymentMethodID=2,PaymentAmount=150,PaymentComments="tardo 24h"},
                new Payment{PaymentID=3,BookingID=3,CustomerID=3,PaymentMethodID=3,PaymentAmount=200,PaymentComments="sin inconveniente"}
            };
            foreach(Payment a in Payment){context.Payments.Add(a);}
            context.SaveChanges();
            //BookingsRoom
            var BookingRoom = new BookingRoom []{
                new BookingRoom{BookingID=1,RoomID=1,GuestID=1},
                new BookingRoom{BookingID=2,RoomID=2,GuestID=2},
                new BookingRoom{BookingID=3,RoomID=3,GuestID=3}
            };
            foreach(BookingRoom s in BookingRoom){context.BookingRooms.Add(s);}
            context.SaveChanges();
        
        }
    }
}