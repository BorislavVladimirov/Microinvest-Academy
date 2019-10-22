using MicroinvestFilesAndStreams.Common;
using MicroinvestFilesAndStreams.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroinvestFilesAndStreams.Models
{
    public class RaceTrack : ITrack
    {
        #region Declarations

        private double length;
        private int cornersCount;
        private string surfaceType;

        #endregion

        #region Initializations

        public RaceTrack(double length, int cornersCount, string surfaceType, bool isOpenAllYear)
        {
            Legnth = length;
            CornersCount = cornersCount;
            SurfaceType = surfaceType;
            IsOpenAllYear = isOpenAllYear;
        }

        #endregion

        #region Properties

        public double Legnth
        {
            get => length;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidTrackLength);
                }

                length = value;
            }
        }

        public int CornersCount
        {
            get => cornersCount;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidCornersCount);
                }

                cornersCount = value;
            }
        }

        public string SurfaceType
        {
            get => surfaceType;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidSurfaceType);
                }

                surfaceType = value;
            }
        }

        public bool IsOpenAllYear { get; private set; }

        #endregion

        #region Methods

        public string CloseTrack()
        {
            return GlobalConstants.ClosedRaceTrack;
        }

        #endregion
    }
}
