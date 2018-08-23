using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlConsoleApp
{

    public class Metro
    {
        public string GroupOfLine { get; set; }
        public string DisplayTime { get; set; }
        public string TransportMode { get; set; }
        public string LineNumber { get; set; }
        public string Destination { get; set; }
        public int JourneyDirection { get; set; }
        public string StopAreaName { get; set; }
        public int StopAreaNumber { get; set; }
        public int StopPointNumber { get; set; }
        public string StopPointDesignation { get; set; }
        public DateTime TimeTabledDateTime { get; set; }
        public DateTime ExpectedDateTime { get; set; }
        public int JourneyNumber { get; set; }
        public object Deviations { get; set; }
    }

    public class ResponseData
    {
        public DateTime LatestUpdate { get; set; }
        public List<Metro> Metros { get; set; }
    }

    public class RootObject
    {
        public ResponseData ResponseData { get; set; }
    }



    //class Metro
    //{
    //    //    public string GroupOfLine { get => GroupOfLine;  set  => GroupOfLine = value; }
    //    //    public string DisplayTime { get => DisplayTime;  set  => DisplayTime = value; }
    //    //    public string TransportMode { get => TransportMode;  set  => TransportMode = value; }
    //    //    public int LineNumber { get => LineNumber;  set  => LineNumber = value; }
    //    //    public string Destination { get => Destination;  set  => Destination = value; }
    //    //    public int JourneyDirection { get => JourneyDirection;  set  => JourneyDirection = value; }
    //    //    public string StopAreaName { get => StopAreaName;  set  => StopAreaName = value; }
    //    //    public int StopAreaNumber { get => StopAreaNumber;  set  => StopAreaNumber = value; }
    //    //    public int StopPointNumber { get => StopPointNumber;  set  => StopPointNumber = value; }
    //    //    public string StopPointDesignation { get => StopPointDesignation;  set  => StopPointDesignation = value; }
    //    //    public DateTime TimeTableDateTime { get => TimeTableDateTime;  set  => TimeTableDateTime = value; }
    //    //    public DateTime ExpectedDateTime { get => ExpectedDateTime;  set  => ExpectedDateTime = value; }
    //    //    public int JourneyNumber { get => JourneyNumber;  set  => JourneyNumber = value; }
    //    //    public string Deviation { get => Deviation;  set  => Deviation = value; }

    //    public string GroupOfLine { get; set; }
    //    public string DisplayTime { get; set; }
    //    public string TransportMode { get; set; }
    //    public string LineNumber { get; set; }
    //    public string Destination { get; set; }
    //    public int JourneyDirection { get; set; }
    //    public string StopAreaName { get; set; }
    //    public int StopAreaNumber { get; set; }
    //    public int StopPointNumber { get; set; }
    //    public string StopPointDesignation { get; set; }
    //    public DateTime TimeTabledDateTime { get; set; }
    //    public DateTime ExpectedDateTime { get; set; }
    //    public int JourneyNumber { get; set; }
    //    public object Deviations { get; set; }


    //    public class ResponseData
    //    {
    //        public DateTime LatestUpdate { get; set; }
    //        public List<Metro> Metros { get; set; }
    //    }

    //    public class RootObject
    //    {
    //        public ResponseData ResponseData { get; set; }
    //    }
    //}
}
