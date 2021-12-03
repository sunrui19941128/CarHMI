using UnityEngine;

namespace HMI.ChargingStations.Data
{
    /// <summary>
    /// 充电站配置数据
    /// </summary>
    [CreateAssetMenu(fileName = "ChargingStationData.asset", menuName = "HMI/Charging Stations/Charging Station", order = 1)]
    public class ChargingStationData : ScriptableObject
    {
        /// <summary>
        /// 充电站提供的电量以千瓦时计
        /// </summary>
        [Tooltip("充电站提供的电量以千瓦时计")]
        [Range(1, 1000)]
        public float PowerGenerated;
    }
}
