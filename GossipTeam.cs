using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    class GossipTeam : NewsTeam
    {
        internal override void CreateStory()
        {
            story.m_body = "Katy Perry is pregnant";
            story.m_title = "Katy Perry";
        }
    }
}
