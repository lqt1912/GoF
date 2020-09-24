using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.NewImage
{
    public interface NewImageInterface
    {
        public string GetImageNameWithoutExtension();
        public void SetImageNameWithoutExtension(string value);
        public string GetImageExtension();
        public void SetImageExtension(string value);
    }
}
