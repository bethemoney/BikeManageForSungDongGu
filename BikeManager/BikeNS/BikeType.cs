using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.BikeNS
{
    public class BikeType
    {
        String m_Code;
        String m_Decription;
        String m_Name;


        public String Code { get { return m_Code; } }
        public String Decription { get { return m_Decription; } }
        public String Name { get { return m_Name; } }

        public BikeType(String code, String description, String name)
        {
            m_Code = code;
            m_Decription = description;
            m_Name = name;
        }
     
    }
}
