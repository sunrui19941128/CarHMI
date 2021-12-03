using HMI.Vehicles.Behaviours.Base;
using HMI.Vehicles.Data;
using Util;
using UnityEngine;
using Vehicles.Behaviours.Base;

namespace HMI.Vehicles.Behaviours
{
    /// <summary>
    /// 里程表表示旅行的距离
    /// </summary>
    [RequireComponent(typeof(VehicleBase))]
    [RequireComponent(typeof(VehicleDataProvider))]
    public class Odometer : OdometerBase
    {
        /// <summary>
        /// 代表里程表的数据集
        /// </summary>
        private OdometerData OdometerData;

        /// <summary>
        /// 车辆
        /// </summary>
        private VehicleBase Vehicle;

    
        private double DistanceTraveledInternal;

        /// <summary>
        ///车辆行驶的总距离，以公里为单位  
        /// </summary>
        public override double DistanceTraveled { get { return DistanceTraveledInternal; } }

        /// <summary>
        /// Internal field for read only property
        /// </summary>
        private double TripDistanceTraveledInternal;

        /// <summary>
        /// 车辆行驶的距离，以公里为单位  
        /// </summary>
        public override double TripDistanceTraveled { get { return TripDistanceTraveledInternal; } }

        /// <summary>
        /// Unity Awake callback
        /// </summary>
        private void Awake()
        {
            Vehicle = GetComponent<VehicleBase>();
            OdometerData = GetComponent<VehicleDataProvider>().VehicleData.Odometer;
            DistanceTraveledInternal = OdometerData.DistanceTraveled;
            TripDistanceTraveledInternal = 0f;
        }

        /// <summary>
        /// Unity Update callback
        /// </summary>
        private void Update()
        {
            // make absolute, speed also indicates a neg. in reverse
            var currentSpeed = Mathf.Abs(Vehicle.CurrentSpeed);

            // speed is in kilometers/hour, convert to kilometers traveled between frames
            var kilometersTraveled = UnitConversion.HoursPerSecond * currentSpeed * Time.deltaTime;
            DistanceTraveledInternal += kilometersTraveled;
            TripDistanceTraveledInternal += kilometersTraveled;
        }
    }
}