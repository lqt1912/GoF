using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Image : ImageInterface
    {
        private string imageName;

        public string GetImageName()
        {
            return imageName;
        }

        public void SetImageName(string value)
        {
            imageName = value;
        }
    }
}
