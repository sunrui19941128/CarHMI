using HMI.Vehicles.Services;
using UnityEngine;

namespace HMI.Vehicles.Behaviours
{
    /// <summary>
    /// 车辆控制器
    /// </summary>
    public class VehicleController : MonoBehaviour
    {
        /// <summary>
        ///切换下一个档位
        /// </summary>
        public void NextGear()
        {
            VehicleService.GetTransmission().SwitchToNextGear();
        }

        /// <summary>
        /// 切换到前档
        /// </summary>
        public void PreviousGear()
        {
            VehicleService.GetTransmission().SwitchToPreviousGear();
        }

        /// <summary>
        /// 车辆加速
        /// </summary>
        public void Accelerate()
        {
            VehicleService.GetVehicle().Accelerate(1f);
        }

        /// <summary>
        /// 刹车
        /// </summary>
        public void Brake()
        {
            VehicleService.GetVehicle().Brake(1f);
        }

        /// <summary>
        /// 开始或暂停引擎
        /// </summary>
        public static void StartStopEngine()
        {
           var engine = VehicleService.GetEngine();

            if(engine.IsEngineOn)
            {
                engine.TurnEngineOff();
            }
            else
            {
                engine.TurnEngineOn();
            }
        }

        /// <summary>
        /// 提高 ADAS 目标速度
        /// </summary>
        public static void AdasIncreaseGoalSpeed()
        {
            VehicleService.GetSpeedController().IncreaseGoalSpeed();
        }

        /// <summary>
        /// 减小自动驾驶的速度
        /// </summary>
        public static void AdasDecreaseGoalSpeed()
        {
            VehicleService.GetSpeedController().DecreaseGoalSpeed();
        }

        /// <summary>
        /// 设置自动巡航 
        /// </summary>
        public static void AdasSet()
        {
            VehicleService.GetSpeedController().SetAutomaticSpeedControl();
        }

        /// <summary>
        /// 取消自动驾驶
        /// </summary>
        public static void AdasCancel()
        {
            VehicleService.GetSpeedController().CancelAutomaticSpeedControl();
        }
    }
}
