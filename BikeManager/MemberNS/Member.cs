using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.MemberNS
{
    public class Member
    {
        public String Name { get { return m_Name; } }
        public String Code { get { return m_Code; } }
        public String Tel { get { return m_Tel; } }
        public String City { get { return m_City; } }
        public string County { get { return m_County; } }
        public String Address { get { return m_Address; } }
        public String ETC { get { return m_ETC; } }
        public String RegDate { get { return m_RegDate; } }
        public Byte[] Picture { get { return m_Picture; } }
        public Boolean IsFemale { get { return m_IsFemale; } }

        private String m_Name;
        private String m_Code;
        private String m_Tel;
        private String m_City;
        private String m_County;
        private String m_Address;
        private String m_ETC;
        private String m_RegDate;
        private Byte[] m_Picture;
        private Boolean m_IsFemale;
        public Member(String Name, String Code, String Tel,String City,String County, String Address, String ETC, String RegDate, Byte[] Picture, Boolean IsFemale)
        {
            m_Code = Code;
            m_Name = Name;
            m_Tel = Tel;
            m_City = City;
            m_County = County;
            m_Address = Address;
            m_ETC = ETC;
            m_RegDate = RegDate;
            m_Picture = Picture;
            m_IsFemale = IsFemale;
        }
    }
}
