using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class CrashModel
    {
        public float HOUR { get; set; }
        public float WEEKDAY { get; set; }
        public float MONTH { get; set; }
        public float MILEPOINT { get; set; }
        public float CITY_ID { get; set; }
        public float COUNTY_ID { get; set; }
        public float WORK_ZONE_RELATED { get; set; }
        public float PEDESTRIAN_INVOLVED { get; set; }
        public float BICYCLIST_INVOLVED { get; set; }
        public float MOTORCYCLE_INVOLVED { get; set; }
        public float IMPROPER_RESTRAINT { get; set; }
        public float UNRESTRAINED { get; set; }
        public float DUI { get; set; }
        public float INTERSECTION_RELATED { get; set; }
        public float WILD_ANIMAL_RELATED { get; set; }
        public float DOMESTIC_ANIMAL_RELATED { get; set; }
        public float OVERTURN_ROLLOVER { get; set; }
        public float COMMERCIAL_MOTOR_VEH_INVOLVED { get; set; }
        public float TEENAGE_DRIVER_INVOLVED { get; set; }
        public float OLDER_DRIVER_INVOLVED { get; set; }
        public float NIGHT_DARK_CONDITION { get; set; }
        public float SINGLE_VEHICLE { get; set; }
        public float DISTRACTED_DRIVING { get; set; }
        public float DROWSY_DRIVING { get; set; }
        public float ROADWAY_DEPARTURE { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                HOUR, WEEKDAY, MONTH, MILEPOINT, CITY_ID, COUNTY_ID,
                WORK_ZONE_RELATED, PEDESTRIAN_INVOLVED,
                BICYCLIST_INVOLVED, MOTORCYCLE_INVOLVED, IMPROPER_RESTRAINT,
                UNRESTRAINED, DUI, INTERSECTION_RELATED, WILD_ANIMAL_RELATED,
                DOMESTIC_ANIMAL_RELATED, OVERTURN_ROLLOVER,
                COMMERCIAL_MOTOR_VEH_INVOLVED, TEENAGE_DRIVER_INVOLVED,
                OLDER_DRIVER_INVOLVED, NIGHT_DARK_CONDITION, SINGLE_VEHICLE,
                DISTRACTED_DRIVING, DROWSY_DRIVING, ROADWAY_DEPARTURE
            };
            int[] dimensions = new int[] { 1, 25 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
