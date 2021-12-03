using HMI.Vehicles.Behaviours.Base;
using HMI.Vehicles.Data;
using UnityEngine;
using Vehicles.Behaviours.Base;

namespace HMI.Vehicles.Behaviours
{
    /// <summary>
    /// 电动汽车由电力驱动的车辆
    /// </summary>
    [RequireComponent(typeof(EngineBase))]
    [RequireComponent(typeof(BrakesBase))]
    [RequireComponent(typeof(TransmissionBase))]
    [RequireComponent(typeof(VehicleDataProvider))]
    public class ElectricVehicle : VehicleBase
    {
        /// <summary>
        /// 发动机
        /// </summary>
        private EngineBase Engine;

        /// <summary>
        ///刹车
        /// </summary>
        private BrakesBase Brakes;

        /// <summary>
        /// 变速箱系统
        /// </summary>
        private TransmissionBase Transmission;

        /// <summary>
        /// 阻力参数
        /// </summary>
        private DragData DragData;

        /// <summary>
        /// 当前车辆速度
        /// </summary>
        public override float CurrentSpeed
        {
            get; set;
        }

        /// <summary>
        ///车辆加速度 对应踩油门
        /// </summary>
        /// <param name="strength">Relative strength of acceleration [0.0..1.0].</param>
        public override void Accelerate(float strength)
        {
            Engine.Accelerate(this, strength: strength, Transmission.CurrentGear);
        }

        /// <summary>
        /// Slow down the vehicle by braking
        /// </summary>
        /// <param name="strength">Relative strength of braking [0.0..1.0].</param>
        public override void Brake(float strength)
        {
            Brakes.Brake(this, strength: strength);
        }

        /// <summary>
        /// 切换下一个档位
        /// </summary>
        public override void NextGear()
        {
            Transmission.SwitchToNextGear();
        }

        /// <summary>
        /// Switch to previous gear
        /// </summary>
        public override void PreviousGear()
        {
            Transmission.SwitchToPreviousGear();
        }

        /// <summary>
        /// Unity Awake callback
        /// </summary>
        private void Awake()
        {
            Engine = GetComponent<EngineBase>();
            Brakes = GetComponent<BrakesBase>();
            Transmission = GetComponent<TransmissionBase>();
            DragData = GetComponent<VehicleDataProvider>().VehicleData.Drag;
        }

        /// <summary>
        /// Unity Update callback
        /// </summary>
        private void Update()
        {
            CurrentSpeed = DragData.CalculateDrag(CurrentSpeed, Time.deltaTime);
        }
    }
}