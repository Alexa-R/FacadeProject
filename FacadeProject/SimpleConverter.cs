using System;
using FacadeProject.Codecs;

namespace FacadeProject
{
    public class SimpleConverter
    {
        private ICodec _codec;

        public void Convert(string filename, string format)
        {
            Console.WriteLine($"File's name = {filename}, file's format = {format}");
            switch (format)
            {
                case "mp4":
                    _codec = new Mpeg4Codec();
                    break;
                case "ogg":
                    _codec = new OggCodec();
                    break;
                default:
                    Console.WriteLine("Incorrect format entered!");
                    break;
            }

            Console.WriteLine(_codec.GetType().Name + " is used for conversion");
            new VideoCoverter().Convert(new VideoFile(filename), _codec);
            Console.WriteLine("File successfully converted!");
        }
    }
}