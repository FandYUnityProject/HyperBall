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
        if (PlayerPrefs.GetInt("Master_Volume") != 0){
            GetComponent<Slider>().value = (float)(PlayerPrefs.GetInt("Master_Volume") / 100.0f);
        } else {
            GetComponent<Slider>().value = 0.001f;
        }
    }

    [SerializeField]
    UnityEngine.Audio.AudioMixer mixer;

    public void OnValueChanged_MasterVolumeSlider ()
    {
        mixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 5, this.GetComponent<Slider>().value));
    }
	
}
