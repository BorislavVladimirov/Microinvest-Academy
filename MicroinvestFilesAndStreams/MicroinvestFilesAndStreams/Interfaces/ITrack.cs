using System;
using System.Collections.Generic;
using System.Text;

namespace MicroinvestFilesAndStreams.Interfaces
{
    public interface ITrack
    {
        double Legnth { get; }

        int CornersCount { get; }

        string SurfaceType { get; }

        bool IsOpenAllYear { get; }

        string CloseTrack();
        
    }
}
