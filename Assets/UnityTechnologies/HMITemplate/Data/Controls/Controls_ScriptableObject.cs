using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ؼ����ݰ����ؼ���ʶ��(����)�ͷ�����ñ�ʶ���ļ���ӳ��  
///�û�����ʹ������ӳ��һ��������һ���������߼������ơ�  
/// </summary>
[CreateAssetMenu(fileName = "ControlsData", menuName = "HMI/VehicleControlsSetup", order = 1)]
public class Controls_ScriptableObject : ScriptableObject
{
    /// <summary>
    /// �û������ɵĿؼ����б�  
    /// Name���ڱ�ʶ�ÿؼ�  
    /// Assigned Key����ʶ�𰴼�ִ�в�����  
    /// </summary>

    [Serializable]
    public class ControlsList
    {
        /// <summary>
        /// ��������λ�Ʊ�ʶ
        /// </summary>
        public string Name;

        /// <summary>
        /// ����İ���
        /// </summary>
        public KeyCode AssignedKey;

        /// <summary>
        ///����Ӧ�ñ������ش���������ֻ�е�һ�������İ�����ע��?  
        /// </summary>
        public bool Continuous;
    }

    /// <summary>
    /// List of ControlsList that user will populate
    /// </summary>
    public List<ControlsList> ControlsMappingList = new List<ControlsList>();
}