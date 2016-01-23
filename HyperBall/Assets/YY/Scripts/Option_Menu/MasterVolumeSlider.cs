/* =========================================================
 * -Info-
 *  MasterVolumeSlider.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  オプションのマスターボリューム設定を反映する
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class MasterVolumeSlider : MonoBehaviour {

    void Start() {
        GetComponent<Slider>().value = (float)(PlayerPrefs.GetInt("Master_Volume") / 100.0f);
    }

    [SerializeField]
    UnityEngine.Audio.AudioMixer mixer;

    public void OnValueChanged_MasterVolumeSlider ()
    {
        mixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 5, this.GetComponent<Slider>().value));
    }
	
}
