﻿/* =========================================================
 * -Info-
 *  BGMVolumeSlider.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  オプションのＢＧＭ設定を反映する
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class BGMVolumeSlider : MonoBehaviour {

    private GameObject BGM_Source;

    void Start() {
        BGM_Source = GameObject.Find("BGM_Source");
        GetComponent<Slider>().value = (float)(PlayerPrefs.GetInt("BGM_Volume") / 100.0f);
    }

    public void OnValueChanged_BGMVolumeSlider ()
    {
        BGM_Source.GetComponent<AudioSource>().volume = Mathf.Lerp(0, 1, this.GetComponent<Slider>().value);
    }
	
}
