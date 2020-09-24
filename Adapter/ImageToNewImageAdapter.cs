using Adapter.NewImage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
   public  class ImageToNewImageAdapter : NewImageInterface
    {
        protected Image image;
        protected string name;
        protected string extension;

        public ImageToNewImageAdapter(Image image)
        {
            this.image = image;
            var str = image.GetImageName().Split('.');
            name = str[0];
            extension = str[1];
        }

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
