﻿/* =========================================================
 * -Info-
 *  SEVolumeSlider.cs
 *  作成日：2015/12/29
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  オプションのＳＥ設定を反映する
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class SEVolumeSlider : MonoBehaviour {

    private GameObject SE_Source;

    void Start()
    {
        SE_Source = GameObject.Find("SE_Source");
    }

    public void OnValueChanged_SEVolumeSlider ()
    {
        SE_Source.GetComponent<AudioSource>().volume = Mathf.Lerp(0, 1, this.GetComponent<Slider>().value);
    }
	
}
