using HMI.ChargingStations.Data;
using HMI.Vehicles.Behaviours;
using HMI.Vehicles.Behaviours.Base;

namespace HMI.ChargingStations.Behaviours
{
    /// <summary>
    /// 电动汽车充电站
    /// </summary>
    public class ChargingStation : EnergyInfluencer
    {
        /// <summary>
        ///充电站配置数据
        /// </summary>
        public ChargingStationData ChargingStationData;

        public override float GetCurrentEnergyInfluence(VehicleBase vehicle, BatteryBase battery)
        {
            return ChargingStationData.PowerGenerated;
        }
    }
}
