using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
  internal class HealthTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story.m_title = "COVID19";
            story.m_body = "Coronovirus is defeated";
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
