using UnityEngine;

/// <summary>
///允许用户通过按escape关闭应用程序  
/// </summary>
public class EscapeToQuitApplication : MonoBehaviour
{
    /// <summary>
    /// Unity Update callback
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
