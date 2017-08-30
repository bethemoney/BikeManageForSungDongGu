using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.RentNS
{
    public class RentalShop
    {
        public String Code { get { return m_Code; } }
        public String Name { get { return m_Name; } }
        public String Address { get { return m_Address; } }

        String m_Code;
        String m_Name;
        String m_Address;

        public RentalShop(String code, String name, String address)
        {
            m_Code = code;
            m_Name=name;
            m_Address=address;
        }
    }
}
