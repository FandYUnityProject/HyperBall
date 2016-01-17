/* -クラスの説明-
 * =======================================================
 *  Opening_LogoAnime.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・オープニングのロゴアニメーション機能
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class Opening_LogoAnime : MonoBehaviour {
    
    public GameObject Circree_Logo;
    public string NextScene_Name = "";

    void Start() {
        Invoke("FadeIn_Start", 0.5f);
        DebugInfo_Manager.DebugInfo_Update("\n========= オープニング開始 =========");
    }

    // フェードアウト用パネルのアニメーション処理
    void Logo_SetAlphaValue(float alpha)
    {
        // フェードイン・アウト中
        Circree_Logo.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, alpha);
    }

    // フェードイン アニメーション
    void FadeIn_Start() {
        DebugInfo_Manager.DebugInfo_Update("ロゴを表示します。");
        iTween.ValueTo(Circree_Logo, iTween.Hash("from", 0.0f, "to", 1.0f, "time", 2.0f, "onupdate", "Logo_SetAlphaValue", "onupdatetarget", gameObject, "oncomplete", "Logo_FadeIn_Complete", "oncompletetarget", gameObject));
    }

    // フェードイン完了後、２秒後にシーン遷移
    void Logo_FadeIn_Complete() {
        DebugInfo_Manager.DebugInfo_Update("ロゴを表示しました。");
        Invoke("NextScene", 2.0f);
    }

    //シーン遷移
    void NextScene(){
        DebugInfo_Manager.DebugInfo_Update("次のシーンへ遷移します。");
        SceneTransition_Controll.NextScene_Transition(NextScene_Name);
    }
}
