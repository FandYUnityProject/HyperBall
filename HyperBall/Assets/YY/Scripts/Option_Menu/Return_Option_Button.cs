/* =========================================================
 * -Info-
 *  Return_Option_Button.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  "戻る"ボタン押下時にオプションメニューを閉じる
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class Return_Option_Button : MonoBehaviour {

    private Slider _MasterVolume_Slider;
    private Slider _BGMVolume_Slider;
    private Slider _SEVolume_Slider;

    void Start() {
        _MasterVolume_Slider = GameObject.Find("MasterVolume_Slider").GetComponent<Slider>();
        _BGMVolume_Slider    = GameObject.Find("BGMVolume_Slider").GetComponent<Slider>();
        _SEVolume_Slider     = GameObject.Find("SEVolume_Slider").GetComponent<Slider>();
    }

    public void OnClick_Return_Option_Button() {
        DebugInfo_Manager.DebugInfo_Update("設定した音量を戻します。");
        DebugInfo_Manager.DebugInfo_Update("MasterVolume:" + PlayerPrefs.GetInt("Master_Volume"));
        DebugInfo_Manager.DebugInfo_Update("BGM_Volume  :" + PlayerPrefs.GetInt("BGM_Volume"));
        DebugInfo_Manager.DebugInfo_Update("SE_Volume   :" + PlayerPrefs.GetInt("SE_Volume"));

        _MasterVolume_Slider.value = (float)(PlayerPrefs.GetInt("Master_Volume") / 100.0f);
        _BGMVolume_Slider.value    = (float)(PlayerPrefs.GetInt("BGM_Volume") / 100.0f);
        _SEVolume_Slider.value     = (float)(PlayerPrefs.GetInt("SE_Volume") / 100.0f);

        Option_Menu_Controll.isOption_MenuOpen = false;
    }
}
