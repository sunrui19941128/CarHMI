using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控件数据包含控件标识符(名称)和分配给该标识符的键的映射  
///用户可以使用它来映射一个按键到一个更符合逻辑的名称。  
/// </summary>
[CreateAssetMenu(fileName = "ControlsData", menuName = "HMI/VehicleControlsSetup", order = 1)]
public class Controls_ScriptableObject : ScriptableObject
{
    /// <summary>
    /// 用户将生成的控件类列表  
    /// Name用于标识该控件  
    /// Assigned Key用于识别按键执行操作。  
    /// </summary>

    [Serializable]
    public class ControlsList
    {
        /// <summary>
        /// 控制器的位移标识
        /// </summary>
        public string Name;

        /// <summary>
        /// 分配的按键
        /// </summary>
        public KeyCode AssignedKey;

        /// <summary>
        ///按键应该被连续地触发，还是只有当一个完整的按键被注册?  
        /// </summary>
        public bool Continuous;
    }

    /// <summary>
    /// List of ControlsList that user will populate
    /// </summary>
    public List<ControlsList> ControlsMappingList = new List<ControlsList>();
}