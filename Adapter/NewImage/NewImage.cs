using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.NewImage
{
    public class NewImage : NewImageInterface
    {
        private string name;
        private string extension;
        public string GetImageExtension()
        {
            return extension;
        }

        public string GetImageNameWithoutExtension()
        {
            return name;
        }

        public void SetImageExtension(string value)
        {
            extension = value;
        }

        public void SetImageNameWithoutExtension(string value)
        {
            name = value;
        }
    }
}
