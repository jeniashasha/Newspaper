using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class PoliticsTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story.m_body = "Kanye West is the new President of the USA";
            story.m_title = "Elections 2021";
        }
        internal override void AddStyle()
        {
            story.m_visualStyle = "column";
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
