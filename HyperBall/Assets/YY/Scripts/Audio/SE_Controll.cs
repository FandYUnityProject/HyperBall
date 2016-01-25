/* -クラスの説明-
 * =======================================================
 *  SE_Controll.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  効果音をコントロールする
 ========================================================== */

using UnityEngine;
using System.Collections;

public class SE_Controll : MonoBehaviour {

    public static AudioSource SE_Source;
    public static AudioClip[] SE_Array;
    public AudioClip[] SE_List;

    void Start() {
        SE_Source = gameObject.GetComponent<AudioSource>();
        SE_Array = SE_List;
    }

    public static void SE_Change(int SourceNumber){
        SE_Source.clip = SE_Array[SourceNumber];
    }
}
