// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Outputs
{

    [OutputType]
    public sealed class GetDbtTransformationScheduleResult
    {
        /// <summary>
        /// The set of the days of the week the transformation should be launched on. The following values are supported: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
        /// </summary>
        public readonly ImmutableArray<string> DaysOfWeeks;
        /// <summary>
        /// The time interval in minutes between subsequent transformation runs.
        /// </summary>
        public readonly int Interval;
        /// <summary>
        /// The type of the schedule to run the dbt Transformation on. The following values are supported: INTEGRATED, TIME*OF*DAY, INTERVAL. For INTEGRATED schedule type, interval and time*of*day values are ignored and only the days*of*week parameter values are taken into account (but may be empty or null). For TIME*OF*DAY schedule type, the interval parameter value is ignored and the time*of*day values is taken into account along with days*of*week value. For INTERVAL schedule type, time*of*day value is ignored and the interval parameter value is taken into account along with days*of*week value.
        /// </summary>
        public readonly string ScheduleType;
        /// <summary>
        /// The time of the day the transformation should be launched at. Supported values are: "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"
        /// </summary>
        public readonly string TimeOfDay;

        [OutputConstructor]
        private GetDbtTransformationScheduleResult(
            ImmutableArray<string> daysOfWeeks,

            int interval,

            string scheduleType,

            string timeOfDay)
        {
            DaysOfWeeks = daysOfWeeks;
            Interval = interval;
            ScheduleType = scheduleType;
            TimeOfDay = timeOfDay;
        }
    }
}
