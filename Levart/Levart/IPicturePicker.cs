using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Levart
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}
