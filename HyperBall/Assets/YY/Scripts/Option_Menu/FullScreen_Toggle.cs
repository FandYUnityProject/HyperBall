/* =========================================================
 * -Info-
 *  FullScreen_Toggle.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  フルスクリーンボタン押下時にフルスクリーンのON/OFFを切替
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FullScreen_Toggle : MonoBehaviour {

	public void OnValueChange_FullScreen()
    {
        // 現在のフルスクリーン状況に応じてON/OFFを切替
        if (!Screen.fullScreen && this.GetComponent<Toggle>().isOn)
        {
            Screen.SetResolution(Screen.width, Screen.height, true);
        } else if(Screen.fullScreen && !this.GetComponent<Toggle>().isOn)
        {
            Screen.SetResolution(Screen.width, Screen.height, false);
        }
    }
}
