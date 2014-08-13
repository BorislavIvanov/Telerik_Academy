using System;

namespace GSMProgram
{
    public enum BatteryType { Null, LiPol, LiIon, NiMH, NiCd };// Task 3

    public class Battery// Task 1
    {
        private string model;// Task 1
        private int? hoursIdle;// Task 1
        private int? hoursTalk;// Task 1
        private BatteryType batteryType;

        public Battery()// Task 2
        {
        }
        public Battery(BatteryType batteryType)
            : this(batteryType, null, null, null)
        {
        }
        public Battery(BatteryType batteryType, string model)
            : this(batteryType, model, null, null)
        {
        }
        public Battery(BatteryType batteryType, string model, int? hoursIdle, int? hoursTalk)
        {
            this.BatteryType = batteryType;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model// Task 5
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null || value.Length > 1)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("The Model must be more than 1 characters!");
                }
            }
        }

        public int? HoursIdle// Task 5
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("The HoursIdle must be more than 0 hours!");
                }
            }
        }

        public int? HoursTalk// Task 5
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value == null || value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("The HoursTalk must be more than 0 hours!");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (Enum.IsDefined(typeof(BatteryType), value))
                {
                    this.batteryType = value;//(1)
                }
                else
                {
                    throw new ArgumentException("The type should be LiPol, LiIon, NiMH or NiCd");//(2)
                }
            }
        }
    }
}