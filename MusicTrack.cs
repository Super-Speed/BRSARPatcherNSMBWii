using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRSARFilePatcher
{
    class MusicTrack
    {
        private String title;
        public String Title 
        {
            get { return title; }
            set { title = value; }
        }

        private String filename;
        public String Filename 
        {
            get { return filename; }
            set { filename = value; }
        }

        private String offset;
        public String Offset 
        {
            get { return offset; }
            set { offset = value; }
        }

        public MusicTrack() {
            //title = "";
            //filename = "";
            //offset = "";
        }
    }
}
