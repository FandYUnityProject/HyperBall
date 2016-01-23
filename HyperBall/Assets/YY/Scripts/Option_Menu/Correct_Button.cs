/* =========================================================
 * -Info-
 *  Correct_Button.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  現在の音量設定を保存する。
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class Correct_Button : MonoBehaviour {

    private Slider _MasterVolume_Slider;
    private Slider _BGMVolume_Slider;
    private Slider _SEVolume_Slider;

    void Start() {
        _MasterVolume_Slider = GameObject.Find("MasterVolume_Slider").GetComponent<Slider>();
        _BGMVolume_Slider    = GameObject.Find("BGMVolume_Slider").GetComponent<Slider>();
        _SEVolume_Slider     = GameObject.Find("SEVolume_Slider").GetComponent<Slider>();
    }

    public void OnClick_Correct_Button() {
        DebugInfo_Manager.DebugInfo_Update("設定した音量を保存します。");
        DebugInfo_Manager.DebugInfo_Update("MasterVolume:" + (int)(_MasterVolume_Slider.value * 100));
        DebugInfo_Manager.DebugInfo_Update("BGM_Volume  :" + (int)(_BGMVolume_Slider.value * 100));
        DebugInfo_Manager.DebugInfo_Update("SE_Volume   :" + (int)(_SEVolume_Slider.value * 100));

        PlayerPrefs.SetInt("Master_Volume", (int)(_MasterVolume_Slider.value * 100));
        PlayerPrefs.SetInt("BGM_Volume"   , (int)(_BGMVolume_Slider.value * 100));
        PlayerPrefs.SetInt("SE_Volume"    , (int)(_SEVolume_Slider.value * 100));

        Option_Menu_Controll.isOption_MenuOpen = false;
    }
}
