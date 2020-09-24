using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class NewImageToImageAdapter : ImageInterface
    {
        string imageName;
        NewImage.NewImage newImage;

        public NewImageToImageAdapter(NewImage.NewImage newImage)
        {
            this.newImage = newImage;
            imageName = newImage.GetImageNameWithoutExtension() + "." + newImage.GetImageExtension();
        }

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
