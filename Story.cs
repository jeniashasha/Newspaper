using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Story
    {
        public string m_title;
        public string m_body;
        public string m_visualStyle;
        public Story(string m_title, string m_body, string m_visualStyle)
        {
            this.m_title = m_title;
            this.m_body = m_body;
            this.m_visualStyle = m_visualStyle;
        }
        public void SetStyle(string style)
        {
            this.m_visualStyle = style;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} title : {m_title}, body : {m_body}, visual style : {m_visualStyle} ";

        }

    }
}
    
