using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalServices
{
    public class Database
    {
        public static int contractCounter = 1;
        public static int feedbackCounter = 1;
        public static bool allowRegisterOwner = true;
        public static string businessName = "DEMETER";
        public static Owner owner = new Owner("LE THUAN THIEN", "9999", new DateTime(1977, 9, 8), "0702569999", new DateTime(2000, 1, 1));
        public static List<Car> cars = new List<Car>();
        public static List<Driver> drivers = new List<Driver>();
        public static List<Assistant> assistants = new List<Assistant>();
        public static List<Renter> renter = new List<Renter>();
        public static List<Contract> contracts = new List<Contract>();
        public static List<Feedback> feedbacks = new List<Feedback>();

        static PassengerCar passengerCar1 = new PassengerCar("29-L143883", "0x8942", ECarCompany.Hyundai, ECarSeats.S29seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar2 = new PassengerCar("45-J735295", "0x5231", ECarCompany.Toyota, ECarSeats.S29seats, ECarClassification.SleeperCar, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar3 = new PassengerCar("62-T629261", "0x7395", ECarCompany.Hyundai, ECarSeats.S29seats, ECarClassification.Limousine, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar4 = new PassengerCar("65-L525635", "0x9255", ECarCompany.Hyundai, ECarSeats.S36seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar5 = new PassengerCar("72-K752029", "0x5132", ECarCompany.Toyota, ECarSeats.S36seats, ECarClassification.SleeperCar, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar6 = new PassengerCar("43-L735242", "0x4273", ECarCompany.Hyundai, ECarSeats.S36seats, ECarClassification.Limousine, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar7 = new PassengerCar("23-H836252", "0x7252", ECarCompany.Hyundai, ECarSeats.S45seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar8 = new PassengerCar("52-D885247", "0x6152", ECarCompany.Toyota, ECarSeats.S45seats, ECarClassification.SleeperCar, new DateTime(2022, 1, 1), true);
        static PassengerCar passengerCar9 = new PassengerCar("94-N225284", "0x9725", ECarCompany.Hyundai, ECarSeats.S45seats, ECarClassification.Limousine, new DateTime(2022, 1, 1), true);

        static TouristCar touristCar1 = new TouristCar("63-K982556", "0x2343", ECarCompany.BMW, ECarSeats.S4seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar2 = new TouristCar("66-F732289", "0x8624", ECarCompany.Honda, ECarSeats.S4seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar3 = new TouristCar("42-M735241", "0x6244", ECarCompany.Audi, ECarSeats.S4seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar4 = new TouristCar("39-G735223", "0x8291", ECarCompany.Mazda, ECarSeats.S7seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar5 = new TouristCar("91-Y725282", "0x4925", ECarCompany.VinFast, ECarSeats.S7seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar6 = new TouristCar("39-I722178", "0x7526", ECarCompany.VinFast, ECarSeats.S7seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar7 = new TouristCar("72-K285235", "0x2522", ECarCompany.Ford, ECarSeats.S16seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar8 = new TouristCar("63-T751926", "0x3527", ECarCompany.Ford, ECarSeats.S16seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);
        static TouristCar touristCar9 = new TouristCar("74-J582538", "0x2152", ECarCompany.Hyundai, ECarSeats.S16seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true);

        static SelfDrivingCar selfDrivingCar1 = new SelfDrivingCar("56-H677007", "0x5671", ECarCompany.Toyota, ECarSeats.S4seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar2 = new SelfDrivingCar("73-F836292", "0x6242", ECarCompany.Audi, ECarSeats.S4seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar3 = new SelfDrivingCar("69-Y283293", "0x8262", ECarCompany.Ford, ECarSeats.S7seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar4 = new SelfDrivingCar("84-F732262", "0x9362", ECarCompany.BMW, ECarSeats.S7seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar5 = new SelfDrivingCar("92-U732272", "0x6242", ECarCompany.Mazda, ECarSeats.S16seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar6 = new SelfDrivingCar("84-T722827", "0x7359", ECarCompany.BMW, ECarSeats.S16seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar7 = new SelfDrivingCar("93-D836282", "0x4382", ECarCompany.Hyundai, ECarSeats.S24seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);
        static SelfDrivingCar selfDrivingCar8 = new SelfDrivingCar("27-S628262", "0x9563", ECarCompany.Hyundai, ECarSeats.S24seats, ECarClassification.CarSeats, new DateTime(2022, 1, 1), true, ECollateral.Movables);

        static TransitCar transitCar1 = new TransitCar("97-I859744", "0x8464", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.RegularCar, new DateTime(2022, 1, 1), true, ECarLoad.W1dot50ton);
        static TransitCar transitCar2 = new TransitCar("82-Y937282", "0x7252", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.RegularCar, new DateTime(2022, 1, 1), true, ECarLoad.W2dot50ton);
        static TransitCar transitCar3 = new TransitCar("63-U382722", "0x2428", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.RegularCar, new DateTime(2022, 1, 1), true, ECarLoad.W3dot50ton);
        static TransitCar transitCar4 = new TransitCar("73-H352824", "0x8362", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.FreezingCar, new DateTime(2022, 1, 1), true, ECarLoad.W10dot00ton);
        static TransitCar transitCar5 = new TransitCar("35-J836282", "0x2638", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.FreezingCar, new DateTime(2022, 1, 1), true, ECarLoad.W8dot00ton);
        static TransitCar transitCar6 = new TransitCar("83-M832926", "0x6273", ECarCompany.Hyundai, ECarSeats.S2seats, ECarClassification.FreezingCar, new DateTime(2022, 1, 1), true, ECarLoad.W10dot00ton);

        static Driver lequangduc = new Driver("LE QUANG DUC", "1001", new DateTime(1980, 11, 29), "0914453588", new DateTime(2010, 1, 6));
        static Driver nguyenducthinh = new Driver("NGUYEN DUC THINH", "1002", new DateTime(1979, 11, 29), "0948157159", new DateTime(2020, 7, 13));
        static Driver dinhquanghoang = new Driver("DINH QUANG HOANG", "1003", new DateTime(1985, 8, 25), "0912300247", new DateTime(2017, 3, 5));
        static Driver duongvanngoan = new Driver("DUONG VAN NGOAN", "1004", new DateTime(1977, 9, 10), "0915133607", new DateTime(2018, 11, 1));
        static Driver hoangvantuy = new Driver("HOANG VAN TUY", "1005", new DateTime(1978, 5, 17), "0979749536", new DateTime(2015, 7, 19));
        static Driver lequylam = new Driver("LE QUY LAM", "1006", new DateTime(1981, 4, 9), "0915843713", new DateTime(2017, 6, 26));
        static Driver nguyenhuutam = new Driver("NGUYEN HUU TAM", "1007", new DateTime(1979, 11, 5), "0945951146", new DateTime(2016, 2, 2));
        static Driver nguyenthanhtien = new Driver("NGUYEN THANH TIEN", "1008", new DateTime(1975, 6, 17), "0914550981", new DateTime(2012, 2, 20));
        static Driver voquangvuong = new Driver("VO QUANG VUONG", "1009", new DateTime(1977, 7, 15), "0912044706", new DateTime(2015, 4, 7));
        static Driver hoangtrungthong = new Driver("HOANG TRUNG THONG", "1010", new DateTime(1982, 3, 18), "0912044656", new DateTime(2014, 8, 30));

        static Assistant dinhvanhoa = new Assistant("DINH VAN HOA", "2001", new DateTime(1995, 3, 27), "0915391312", new DateTime(2020, 7, 17));
        static Assistant tranngocnuong = new Assistant("TRAN NGOC NUONG", "2002", new DateTime(1997, 6, 16), "0913602103", new DateTime(2019, 3, 5));
        static Assistant lethanhhoa = new Assistant("LE THANH HOA", "2003", new DateTime(1998, 2, 11), "0905372666", new DateTime(2020, 4, 12));
        static Assistant buithanhpphong = new Assistant("BUI THANH PHONG", "2004", new DateTime(1995, 4, 1), "0911375199", new DateTime(2018, 6, 10));
        static Assistant nguyenminhvu = new Assistant("NGUYEN MINH VU", "2005", new DateTime(1996, 5, 6), "0913295947", new DateTime(2017, 3, 29));
        static Assistant truongthingocanh = new Assistant("TRUONG THI NGOC ANH", "2006", new DateTime(1994, 10, 8), "0932358522", new DateTime(2018, 2, 17));
        static Assistant nguyendangsu = new Assistant("NGUYEN DANG SU", "2007", new DateTime(1993, 11, 3), "0943747830", new DateTime(2019, 5, 13));
        static Assistant dothiyen = new Assistant("DO THI YEN", "2008", new DateTime(1999, 12, 9), "0915956905", new DateTime(2021, 4, 21));
        static Assistant nguyenvanlai = new Assistant("NGUYEN VAN LAI", "2009", new DateTime(1989, 1, 15), "0932351229", new DateTime(2016, 6, 17));
        static Assistant maithithuynhung = new Assistant("MAI THI THUY NHUNG", "2010", new DateTime(2000, 7, 7), "0932351277", new DateTime(2022, 5, 23));

        static Renter phamkhanhhuy = new Renter("PHAM KHANH HUY", "3001", new DateTime(2000, 2, 16), "0949522905", DateTime.Now.AddDays(-10));
        static Renter nguyenkieutrang = new Renter("NGUYEN KIEU TRANG", "3002", new DateTime(2004, 7, 28), "0949234388", DateTime.Now.AddDays(-10));
        static Renter luongducthoai = new Renter("LUONG DUC THOAI", "3003", new DateTime(1995, 9, 15), "0914500150", DateTime.Now.AddDays(-10));
        static Renter vanductrong = new Renter("VAN DUC TRONG", "3004", new DateTime(1999, 4, 21), "0912222798", DateTime.Now.AddDays(-10));
        static Renter nguyennhuy = new Renter("NGUYEN NHU Y", "3005", new DateTime(2004, 11, 29), "0944747978", DateTime.Now.AddDays(-10));
        static Renter nguyenthutrang = new Renter("NGUYEN THU TRANG", "3006", new DateTime(1991, 8, 22), "0914418539", DateTime.Now.AddDays(-10));
        static Renter phamhongson = new Renter("PHAM HONG SON", "3007", new DateTime(1985, 4, 9), "0917822121", DateTime.Now.AddDays(-10));
        static Renter dinhtiencuong = new Renter("DINH TIEN CUONG", "3008", new DateTime(1978, 12, 26), "0912980878", DateTime.Now.AddDays(-10));
        static Renter dinhngocthuy = new Renter("DINH NGOC THUY", "3009", new DateTime(1991, 1, 19), "0919795257", DateTime.Now.AddDays(-10));
        static Renter nguyenthanhquyet = new Renter("NGUYEN THANH QUYET", "3010", new DateTime(1971, 5, 22), "0944574408", DateTime.Now.AddDays(-10));
        static Renter caoxuanduong = new Renter("CAO XUAN DUONG", "3011", new DateTime(1987, 7, 14), "0944678318", DateTime.Now.AddDays(-10));
        static Renter phananhnguyet = new Renter("PHAN ANH NGUYET", "3012", new DateTime(1992, 9, 24), "0942774239", DateTime.Now.AddDays(-10));
        static Renter luuducthuan = new Renter("LUU DUC THUAN", "3013", new DateTime(1982, 6, 15), "0916448340", DateTime.Now.AddDays(-10));
        static Renter lengocuyen = new Renter("LE NGOC UYEN", "3014", new DateTime(1977, 10, 27), "0912983727", DateTime.Now.AddDays(-10));
        static Renter nguyenkimyen = new Renter("NGUYEN KIM YEN", "3015", new DateTime(1973, 10, 19), "0948885031", DateTime.Now.AddDays(-10));
        static Renter nguyenhuutu = new Renter("NGUYEN HUU TU", "3016", new DateTime(1988, 2, 20), "0943998731", DateTime.Now.AddDays(-10));
        static Renter hothinguyet = new Renter("HO THI NGUYET", "3017", new DateTime(1991, 4, 18), "0975139341", DateTime.Now.AddDays(-10));
        static Renter lequangninh = new Renter("LE QUANG NINH", "3018", new DateTime(1994, 5, 12), "0914851119", DateTime.Now.AddDays(-10));
        static Renter tranvanhuyen = new Renter("TRAN VAN HUYEN", "3019", new DateTime(1980, 8, 22), "0932351288", DateTime.Now.AddDays(-10));
        static Renter nguyenthiphuong = new Renter("NGUYEN THI PHUONG", "3020", new DateTime(1972, 3, 13), "0986737677", DateTime.Now.AddDays(-10));

        static Contract contract1 = new Contract(owner, phamkhanhhuy, lequangduc, buithanhpphong, passengerCar1, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-2), 100);
        static Contract contract2 = new Contract(owner, phamkhanhhuy, dinhquanghoang, tranngocnuong, touristCar1, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(0), 100);
        static Contract contract3 = new Contract(owner, phamkhanhhuy, new Driver(), dinhvanhoa, selfDrivingCar1, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(0), 100);
        static Contract contract4 = new Contract(owner, phamkhanhhuy, duongvanngoan, tranngocnuong, transitCar3, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), 100);
        static Contract contract5 = new Contract(owner, phamkhanhhuy, lequangduc, new Assistant(), passengerCar2, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(0), 100);
        static Contract contract6 = new Contract(owner, nguyenthutrang, dinhquanghoang, lethanhhoa, touristCar6, DateTime.Now.AddDays(1), DateTime.Now.AddDays(3), 100);
        static Contract contract7 = new Contract(owner, phamkhanhhuy, duongvanngoan, buithanhpphong, selfDrivingCar3, DateTime.Now.AddDays(3), DateTime.Now.AddDays(4), 100);
        static Contract contract8 = new Contract(owner, luongducthoai, nguyenducthinh, dinhvanhoa, touristCar3, DateTime.Now.AddDays(5), DateTime.Now.AddDays(5), 100);
        static Contract contract9 = new Contract(owner, vanductrong, nguyenducthinh, new Assistant(), touristCar5, DateTime.Now.AddDays(5), DateTime.Now.AddDays(7), 100);
        static Contract contract10 = new Contract(owner, phamkhanhhuy, nguyenhuutam, dothiyen, passengerCar3, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-2), 100);
        static Contract contract11 = new Contract(owner, hothinguyet, new Driver(), maithithuynhung, selfDrivingCar2, DateTime.Now.AddDays(1), DateTime.Now.AddDays(3), 100);
        static Contract contract12 = new Contract(owner, nguyenhuutu, lequylam, nguyendangsu, transitCar1, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), 100);
        static Contract contract13 = new Contract(owner, nguyenthiphuong, voquangvuong, new Assistant(), touristCar2, DateTime.Now.AddDays(4), DateTime.Now.AddDays(6), 100);
        static Contract contract14 = new Contract(owner, lequangninh, new Driver(), maithithuynhung, selfDrivingCar4, DateTime.Now.AddDays(3), DateTime.Now.AddDays(5), 100);
        static Contract contract15 = new Contract(owner, caoxuanduong, hoangtrungthong, dothiyen, passengerCar7, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), 100);
        static Contract contract16 = new Contract(owner, phananhnguyet, lequangduc, nguyenminhvu, transitCar6, DateTime.Now.AddDays(7), DateTime.Now.AddDays(9), 100);
        static Contract contract17 = new Contract(owner, nguyenhuutu, lequylam, new Assistant(), touristCar9, DateTime.Now.AddDays(4), DateTime.Now.AddDays(5), 100);
        static Contract contract18 = new Contract(owner, tranvanhuyen, new Driver(), tranngocnuong, selfDrivingCar5, DateTime.Now.AddDays(0), DateTime.Now.AddDays(2), 100);
        static Contract contract19 = new Contract(owner, dinhtiencuong, nguyenhuutam, truongthingocanh, passengerCar5, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-2), 100);
        static Contract contract20 = new Contract(owner, nguyenkieutrang, nguyenthanhtien, nguyendangsu, transitCar5, DateTime.Now.AddDays(6), DateTime.Now.AddDays(8), 100);

        static Feedback feedback1 = new Feedback(phamkhanhhuy, owner, ECategory.CommitmentInContract, ERate.Five, "The car rental experience was seamless and efficient. Highly recommended!", DateTime.Now);
        static Feedback feedback2 = new Feedback(phamkhanhhuy, lequangduc, ECategory.ServiceAttitude, ERate.Four, "Great selection of cars and excellent customer service. Will definitely rent again.", DateTime.Now);
        static Feedback feedback3 = new Feedback(phamkhanhhuy, nguyenducthinh, ECategory.ServiceAttitude, ERate.Five, "Smooth pickup and drop-off process. The vehicle was clean and well-maintained.", DateTime.Now);
        static Feedback feedback4 = new Feedback(nguyenkieutrang, dinhquanghoang, ECategory.CommitmentInContract, ERate.Five, "Affordable rates and friendly staff. Made my trip hassle-free.", DateTime.Now);
        static Feedback feedback5 = new Feedback(luongducthoai, duongvanngoan, ECategory.ServiceAttitude, ERate.Four, "Impressed with the professionalism of the car rental team. A positive experience overall.", DateTime.Now);
        static Feedback feedback6 = new Feedback(vanductrong, dinhvanhoa, ECategory.ServiceAttitude, ERate.Five, "Quick and easy reservation process. The car exceeded my expectations.", DateTime.Now);
        static Feedback feedback7 = new Feedback(nguyennhuy, tranngocnuong, ECategory.CommitmentInContract, ERate.Five, "Responsive customer support and transparent pricing. I had a stress-free rental.", DateTime.Now);
        static Feedback feedback8 = new Feedback(nguyenthutrang, lethanhhoa, ECategory.ServiceAttitude, ERate.Four, "The flexibility of rental options made it convenient for my travel plans.", DateTime.Now);
        static Feedback feedback9 = new Feedback(nguyenkieutrang, buithanhpphong, ECategory.ServiceAttitude, ERate.Five, "The condition of the car was excellent, and the staff was helpful and courteous.", DateTime.Now);
        static Feedback feedback10 = new Feedback(hothinguyet, maithithuynhung, ECategory.ServiceAttitude, ERate.Four, "Friendly staff and good service. Car was clean and well-maintained.", DateTime.Now);
        static Feedback feedback11 = new Feedback(caoxuanduong, nguyenhuutu, ECategory.CommitmentInContract, ERate.Five, "Smooth rental process and transparent pricing. Will recommend to others.", DateTime.Now);
        static Feedback feedback12 = new Feedback(phananhnguyet, lequylam, ECategory.ServiceAttitude, ERate.Three, "Average service. Car condition could have been better.", DateTime.Now);
        static Feedback feedback13 = new Feedback(nguyenthiphuong, dothiyen, ECategory.CommitmentInContract, ERate.Four, "Reasonable prices and good communication. Overall satisfied.", DateTime.Now);
        static Feedback feedback14 = new Feedback(nguyenthanhquyet, truongthingocanh, ECategory.ServiceAttitude, ERate.Five, "Excellent service. Staff went above and beyond to assist.", DateTime.Now);
        static Feedback feedback15 = new Feedback(caoxuanduong, lengocuyen, ECategory.ServiceAttitude, ERate.Three, "Satisfactory service. Car was not as clean as expected.", DateTime.Now);
        static Feedback feedback16 = new Feedback(luuducthuan, dinhtiencuong, ECategory.ServiceAttitude, ERate.Four, "Helpful staff. The rental process was quick and efficient.", DateTime.Now);
        static Feedback feedback17 = new Feedback(nguyenkieutrang, dinhvanhoa, ECategory.CommitmentInContract, ERate.Four, "Highly reliable service. Car matched the description in the contract.", DateTime.Now);
        static Feedback feedback18 = new Feedback(lequangninh, owner, ECategory.ServiceAttitude, ERate.Five, "Average service. Car condition could have been better.", DateTime.Now);
        static Feedback feedback19 = new Feedback(caoxuanduong, voquangvuong, ECategory.ServiceAttitude, ERate.Four, "Responsive customer support. The car was in good condition.", DateTime.Now);
        static Feedback feedback20 = new Feedback(phananhnguyet, dinhvanhoa, ECategory.CommitmentInContract, ERate.Five, "Smooth rental process and transparent pricing. Will recommend to others.", DateTime.Now);
        static Feedback feedback21 = new Feedback(nguyenthutrang, passengerCar1, ECategory.CommitmentInContract, ERate.Five, "I am extremely impressed with the quality of the car. It's stylish, comfortable, and the performance is outstanding.", DateTime.Now);
        static Feedback feedback22 = new Feedback(nguyenthiphuong, passengerCar1, ECategory.CommitmentInContract, ERate.Four, "The car's build quality is top-notch. It feels sturdy, and the attention to detail in both the interior and exterior design is remarkable.", DateTime.Now);

        static Database()
        {
            cars.Add(passengerCar1);
            cars.Add(passengerCar2);
            cars.Add(passengerCar3);
            cars.Add(passengerCar4);
            cars.Add(passengerCar5);
            cars.Add(passengerCar6);
            cars.Add(passengerCar7);
            cars.Add(passengerCar8);
            cars.Add(passengerCar9);
            cars.Add(touristCar1);
            cars.Add(touristCar2);
            cars.Add(touristCar3);
            cars.Add(touristCar4);
            cars.Add(touristCar5);
            cars.Add(touristCar6);
            cars.Add(touristCar7);
            cars.Add(touristCar8);
            cars.Add(touristCar9);
            cars.Add(selfDrivingCar1);
            cars.Add(selfDrivingCar2);
            cars.Add(selfDrivingCar3);
            cars.Add(selfDrivingCar4);
            cars.Add(selfDrivingCar5);
            cars.Add(selfDrivingCar6);
            cars.Add(selfDrivingCar7);
            cars.Add(selfDrivingCar8);
            cars.Add(transitCar1);
            cars.Add(transitCar2);
            cars.Add(transitCar3);
            cars.Add(transitCar4);
            cars.Add(transitCar5);
            cars.Add(transitCar6);

            drivers.Add(lequangduc);
            drivers.Add(nguyenducthinh);
            drivers.Add(dinhquanghoang);
            drivers.Add(duongvanngoan);
            drivers.Add(hoangvantuy);
            drivers.Add(lequylam);
            drivers.Add(nguyenhuutam);
            drivers.Add(nguyenthanhtien);
            drivers.Add(voquangvuong);
            drivers.Add(hoangtrungthong);

            assistants.Add(dinhvanhoa);
            assistants.Add(tranngocnuong);
            assistants.Add(lethanhhoa);
            assistants.Add(buithanhpphong);
            assistants.Add(nguyenminhvu);
            assistants.Add(truongthingocanh);
            assistants.Add(nguyendangsu);
            assistants.Add(dothiyen);
            assistants.Add(nguyenvanlai);
            assistants.Add(maithithuynhung);

            renter.Add(phamkhanhhuy);
            renter.Add(nguyenkieutrang);
            renter.Add(luongducthoai);
            renter.Add(vanductrong);
            renter.Add(nguyennhuy);
            renter.Add(nguyenthutrang);
            renter.Add(phamhongson);
            renter.Add(dinhtiencuong);
            renter.Add(dinhngocthuy);
            renter.Add(nguyenthanhquyet);
            renter.Add(caoxuanduong);
            renter.Add(phananhnguyet);
            renter.Add(luuducthuan);
            renter.Add(lengocuyen);
            renter.Add(nguyenkimyen);
            renter.Add(nguyenhuutu);
            renter.Add(hothinguyet);
            renter.Add(lequangninh);
            renter.Add(tranvanhuyen);
            renter.Add(nguyenthiphuong);

            contract1.AddPrepayment(contract1.PreSettlementValue);
            contract2.AddPrepayment(contract2.PreSettlementValue);
            contract3.AddPrepayment(contract3.PreSettlementValue);
            contract4.AddPrepayment(contract4.PreSettlementValue);
            contract5.AddPrepayment(contract5.PreSettlementValue);
            contract6.AddPrepayment(contract6.PreSettlementValue);
            contract7.AddPrepayment(contract7.PreSettlementValue);
            contract8.AddPrepayment(contract8.PreSettlementValue);
            contract9.AddPrepayment(contract9.PreSettlementValue);
            contract10.AddPrepayment(contract10.PreSettlementValue);
            contract11.AddPrepayment(contract11.PreSettlementValue);
            contract12.AddPrepayment(contract12.PreSettlementValue);
            contract13.AddPrepayment(contract13.PreSettlementValue);
            contract14.AddPrepayment(contract14.PreSettlementValue);
            contract15.AddPrepayment(contract15.PreSettlementValue);
            contract16.AddPrepayment(contract16.PreSettlementValue);
            contract17.AddPrepayment(contract17.PreSettlementValue);
            contract18.AddPrepayment(contract18.PreSettlementValue);
            contract19.AddPrepayment(contract19.PreSettlementValue);
            contract20.AddPrepayment(contract20.PreSettlementValue);
            contracts.Add(contract1);
            contracts.Add(contract2);
            contracts.Add(contract3);
            contracts.Add(contract4);
            contracts.Add(contract5);
            contracts.Add(contract6);
            contracts.Add(contract7);
            contracts.Add(contract8);
            contracts.Add(contract9);
            contracts.Add(contract10);
            contracts.Add(contract11);
            contracts.Add(contract12);
            contracts.Add(contract13);
            contracts.Add(contract14);
            contracts.Add(contract15);
            contracts.Add(contract16);
            contracts.Add(contract17);
            contracts.Add(contract18);
            contracts.Add(contract19);
            contracts.Add(contract20);
            contract1.ContractPayments(DateTime.Now, EPayments.COD, 100000000);
            contract1.AddDamage(EDamage.AccessibleWheels); contract1.AddDamage(EDamage.GoodsNotAllowed);
            contract2.ContractPayments(DateTime.Now, EPayments.COD, 100000000);
            contract2.AddDamage(EDamage.AccessibleWheels); contract1.AddDamage(EDamage.GoodsNotAllowed);
            contract3.ContractPayments(DateTime.Now, EPayments.COD, 100000000);
            contract3.AddDamage(EDamage.AccessibleWheels); contract1.AddDamage(EDamage.GoodsNotAllowed);
            contract4.ContractPayments(DateTime.Now, EPayments.Visa, 100000000);
            contract4.AddDamage(EDamage.AccessibleWheels); contract4.AddDamage(EDamage.GoodsNotAllowed);

            feedbacks.Add(feedback1);
            feedbacks.Add(feedback2);
            feedbacks.Add(feedback3);
            feedbacks.Add(feedback4);
            feedbacks.Add(feedback5);
            feedbacks.Add(feedback6);
            feedbacks.Add(feedback7);
            feedbacks.Add(feedback8);
            feedbacks.Add(feedback9);
            feedbacks.Add(feedback10);
            feedbacks.Add(feedback11);
            feedbacks.Add(feedback12);
            feedbacks.Add(feedback13);
            feedbacks.Add(feedback14);
            feedbacks.Add(feedback15);
            feedbacks.Add(feedback16);
            feedbacks.Add(feedback17);
            feedbacks.Add(feedback18);
            feedbacks.Add(feedback19);
            feedbacks.Add(feedback20);
            feedbacks.Add(feedback21);
            feedbacks.Add(feedback22);

            var listCarAmenities = new List<ECarAmenities> { ECarAmenities.Wifi, ECarAmenities.Television, ECarAmenities.AirConditioning, ECarAmenities.Blanket, ECarAmenities.EscapeTools, ECarAmenities.HealthcareBox, ECarAmenities.DrinkingWater, ECarAmenities.WetTowel, ECarAmenities.SeatBelt};
            
            passengerCar1.AddRangeCarAmenities(listCarAmenities);
            passengerCar2.AddRangeCarAmenities(listCarAmenities);
            passengerCar3.AddRangeCarAmenities(listCarAmenities);
            passengerCar4.AddRangeCarAmenities(listCarAmenities);
            passengerCar5.AddRangeCarAmenities(listCarAmenities);
            passengerCar6.AddRangeCarAmenities(listCarAmenities);
            passengerCar7.AddRangeCarAmenities(listCarAmenities);
            passengerCar8.AddRangeCarAmenities(listCarAmenities);
            passengerCar9.AddRangeCarAmenities(listCarAmenities);

            touristCar1.AddRangeCarAmenities(listCarAmenities);
            touristCar2.AddRangeCarAmenities(listCarAmenities);
            touristCar3.AddRangeCarAmenities(listCarAmenities);
            touristCar4.AddRangeCarAmenities(listCarAmenities);
            touristCar5.AddRangeCarAmenities(listCarAmenities);
            touristCar6.AddRangeCarAmenities(listCarAmenities);
            touristCar7.AddRangeCarAmenities(listCarAmenities);
            touristCar8.AddRangeCarAmenities(listCarAmenities);
            touristCar9.AddRangeCarAmenities(listCarAmenities);

            selfDrivingCar1.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar2.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar3.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar4.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar5.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar6.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar7.AddRangeCarAmenities(listCarAmenities);
            selfDrivingCar8.AddRangeCarAmenities(listCarAmenities);

            transitCar1.AddRangeCarAmenities(listCarAmenities);
            transitCar2.AddRangeCarAmenities(listCarAmenities);
            transitCar3.AddRangeCarAmenities(listCarAmenities);
            transitCar4.AddRangeCarAmenities(listCarAmenities);
            transitCar5.AddRangeCarAmenities(listCarAmenities);
            transitCar6.AddRangeCarAmenities(listCarAmenities);
        }
        public static string GenerateContractCode()
        {
            string contractCode = "VRS" + contractCounter.ToString("D3");
            contractCounter++;
            return contractCode;
        }
        public static string GenerateFeedbackCode()
        {
            string feedbackCode = "FEB" + feedbackCounter.ToString("D3");
            feedbackCounter++;
            return feedbackCode;
        }
    }
}
