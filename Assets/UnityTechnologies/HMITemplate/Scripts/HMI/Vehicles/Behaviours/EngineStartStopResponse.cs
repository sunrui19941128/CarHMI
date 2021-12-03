using HMI.Vehicles.Behaviours.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace HMI.Vehicles.Behaviours
{
    /// <summary>
    /// 响应发动机启停事件，将变速器转换为P  
    /// </summary>
    public class EngineStartStopResponse : MonoBehaviour
    {
        /// <summary>
        /// Vehicle Engine
        /// </summary>
        public EngineBase Engine;

        /// <summary>
        /// Vehicle Transmission
        /// </summary>
        public TransmissionBase Transmission;

        /// <summary>
        /// Engine State changed
        /// </summary>
        public void OnEngineStateChange()
        {
            if(Engine.IsEngineOn)
            {
                Transmission.SwitchToDesiredGear("P");
            }
            else
            {
                Transmission.SwitchToDesiredGear("P");
            }
        }
    }
}
