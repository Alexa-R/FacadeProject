﻿using System;
using FacadeProject.Codecs;

namespace FacadeProject
{
    public class VideoCoverter
    {
        public VideoCoverter()
        {
        }

        public void Convert(VideoFile file, ICodec codec)
        {
            Console.WriteLine($"{file.FileName} conversion started...");
        }
    }
}