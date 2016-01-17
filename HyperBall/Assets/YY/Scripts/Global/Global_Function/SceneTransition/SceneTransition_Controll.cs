/* -クラスの説明-
 * =======================================================
 *  FadeOut_Panel_Controll.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  全シーン遷移時にフェードイン/アウトアニメーションを行う
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition_Controll : MonoBehaviour {

    public static bool isScene_Transition = false;
    public static GameObject Fadeout_Panel;

    void Start()
    {
        // 初期化
        isScene_Transition = false;

        Fadeout_Panel = GameObject.Find("Fadeout_Panel");  // フェードアウト用パネルの取得
        Fadeout_Panel.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.0f); // 透明度の初期化
    }

    /// <summary>
    /// 指定したシーンへ、暗転アニメーションと共に遷移します。
    /// </summary>
    /// <param name="SceneName">遷移するシーン</param>
    public static void NextScene_Transition(string SceneName)
    {
        isScene_Transition = true;  // シーン切替中

        // ゲーム起動時がOpeningシーンから開始している場合
        if(Fadeout_Panel != null) {
            Fadeout_Panel.SetActive(true);
            FadeOut_Panel_Start(SceneName);
        } else {

            // それ以外（デバッグ時等）はシーン遷移
            SceneManager.LoadScene(SceneName);
        }
    }

    // フェードアウト用パネルのアニメーション処理
    void FadeOut_Panel_SetAlphaValue(float alpha)
    {
        // フェードイン・アウト中
        Fadeout_Panel.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, alpha);
    }

    // フェードアウト処理　⇒　シーン遷移
    public static void FadeOut_Panel_Start(string SceneName)
    {
        iTween.ValueTo(Fadeout_Panel, iTween.Hash("from", 0.0f, "to", 1.0f, "time", 2.0f, "onupdate", "FadeOut_Panel_SetAlphaValue", "onupdatetarget", Fadeout_Panel, "oncomplete", "FadeOut_Panel_FadeOut_Complete", "oncompleteparams", SceneName));
    }

    // フェードアウト完了後　⇒　シーン遷移（一度サーバーを切断） ⇒　フェードイン処理
    void FadeOut_Panel_FadeOut_Complete(string SceneName)
    {
        // シーン遷移(記述が変わったので注意)
        SceneManager.LoadScene(SceneName);

        // フェードアウトアニメーションを行う
        iTween.ValueTo(Fadeout_Panel, iTween.Hash("from", 1.0f, "to", 0.0f, "time", 0.6f, "delay", 0.4f, "onupdate", "FadeOut_Panel_SetAlphaValue", "onupdatetarget", Fadeout_Panel, "oncomplete", "FadeOut_Panel_FadeIn_Complete"));
    }

    // フェードイン完了後　⇒　フェードアウト用パネルを非活性にする
    void FadeOut_Panel_FadeIn_Complete()
    {
        isScene_Transition = false;  // シーン切替終了
        Fadeout_Panel.SetActive(false);
    }
}
