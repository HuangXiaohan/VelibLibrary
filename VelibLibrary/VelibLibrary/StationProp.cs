using System;

namespace VelibLibrary
{
    class StationProp
    {
        int bikeNum;
        DateTime timeUpdate;

        public StationProp()
        {
            this.bikeNum = -1;
        }

        public int getBikeNum()
        {
            return this.bikeNum;
        }

        public DateTime getTimeUpdate()
        {
            return this.timeUpdate;
        }

        public void setBikeNum(int bikeNum)
        {
            this.bikeNum = bikeNum;
        }

        public void setTimeUpdate(DateTime timeUpdate)
        {
            this.timeUpdate = timeUpdate;
        }
    }
}