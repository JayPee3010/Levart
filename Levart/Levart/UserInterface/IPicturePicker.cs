using System;
using System.IO;
using System.Threading.Tasks;

namespace Levart.UserInterface
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }

}

