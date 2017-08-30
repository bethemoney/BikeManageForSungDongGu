using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.RentNS
{
    public class Rent
    {
        public String BikeCode { get { return m_BikeCode; } }
        public String MemberCode { get { return m_MemberCode; } }
        public DateTime RentDate { get { return m_RentDate; } }
        public String RentShop { get { return m_RentShop; } }
        public String ReturnShop { get { return m_ReturnShop; } }
        public DateTime ReturnDate { get { return m_ReturnDate; } }

        private String m_BikeCode;
        private String m_MemberCode;
        private DateTime m_RentDate;
        private String m_RentShop;
        private String m_ReturnShop;
        private DateTime m_ReturnDate;

        public Rent(String memberCode, String bikeCode, DateTime rentDate, String rentShop, String returnShop, DateTime returnDate)
        {
            m_MemberCode = memberCode;
            m_BikeCode = bikeCode;
            m_RentDate = rentDate;
            m_RentShop = rentShop;
            m_ReturnShop = returnShop;
            m_ReturnDate = returnDate;
        }
    }
}
