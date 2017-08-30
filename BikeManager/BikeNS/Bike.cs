using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.BikeNS
{
    public class Bike
    {
        public String Type { get { return m_Type; } }
        public String Code { get { return m_Code; } }
        public String CurrentRentalShop { get { return m_CurrentRentalShop; } }
        public String InitRentalShop{get {return m_InitRentalShop;}}
        public String ETC { get { return m_ETC; } }
        public String RegDate { get { return m_RegDate; } }
        public Byte[] Picture { get { return m_Picture; } }

        private String m_Type;                              //자전거 종류
        private String m_InitRentalShop;                    //자전거 초기등록지
        private String m_CurrentRentalShop;                 //자전거 현재 보관위치
        private String m_Code;                              //자전거 번호
        private String m_ETC;                               //자전거 기타 사항
        private String m_RegDate;                           //자전거 등록일
        private Byte[] m_Picture;                           //자전거 사진

        public Bike(String Type, String Code, String InitRentalShop, String CurrentRentalShop, String ETC, String RegDate, Byte[] Picture)
        {
            m_Type = Type;
            m_Code = Code;
            m_CurrentRentalShop = CurrentRentalShop;
            m_InitRentalShop =InitRentalShop;
            m_ETC = ETC;
            m_RegDate = RegDate;
            m_Picture = Picture;
        }

    }
}
