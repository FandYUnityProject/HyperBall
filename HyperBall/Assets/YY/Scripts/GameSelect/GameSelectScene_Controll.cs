/* -クラスの説明-
 * =======================================================
 *  GameSelectScene_Controll.cs
 *  作成日：2016/1/24
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  ゲームセレクトシーンのUIコントロール
 ========================================================== */

using UnityEngine;
using UnityEngine.UI;

public class GameSelectScene_Controll : MonoBehaviour {

    public static GameObject Game_PressButton_Button;

    public static GameObject ChallengeMode_Button;
    public static GameObject FreeMode_Button;
    public static GameObject Option_Button;

    public static GameObject ChallengeModeTitle_Image;
    public static GameObject Easy_Button;
    public static GameObject Normal_Button;
    public static GameObject Hard_Button;
    public static GameObject Return_GameModeSelect_Button;

    void Start () {
        // ゲームオブジェクト取得
        Game_PressButton_Button      = GameObject.Find("Game_PressButton_Button");
        ChallengeMode_Button         = GameObject.Find("ChallengeMode_Button");
        FreeMode_Button              = GameObject.Find("FreeMode_Button");
        Option_Button                = GameObject.Find("Option_Button");
        ChallengeModeTitle_Image     = GameObject.Find("ChallengeModeTitle_Image");
        Easy_Button                  = GameObject.Find("Easy_Button");
        Normal_Button                = GameObject.Find("Normal_Button");
        Hard_Button                  = GameObject.Find("Hard_Button");
        Return_GameModeSelect_Button = GameObject.Find("Return_GameModeSelect_Button");

        // "Game_PressButton_Button"以外を非活性
        All_HideImage();
        Game_PressButton_Button.SetActive(true);
    }

    // 全てのボタンを非表示にする
    public static void All_HideImage() {
        Game_PressButton_Button.SetActive(false);
        ChallengeMode_Button.SetActive(false);
        FreeMode_Button.SetActive(false);
        Option_Button.SetActive(false);
        ChallengeModeTitle_Image.SetActive(false);
        Easy_Button.SetActive(false);
        Normal_Button.SetActive(false);
        Hard_Button.SetActive(false);
        Return_GameModeSelect_Button.SetActive(false);
    }

    // "PressButton"押下時にモードとオプションボタンを表示
    public static void PressButton_Event() {
        All_HideImage();

        ChallengeMode_Button.SetActive(true);
        FreeMode_Button.SetActive(true);
        Option_Button.SetActive(true);
    }

    // "ChallengeMode_Button"押下時にゲームレベルボタンを表示
    public static void ChallengeMode_Button_Event() {
        All_HideImage();

        ChallengeModeTitle_Image.SetActive(true);
        Easy_Button.SetActive(true);
        Normal_Button.SetActive(true);
        Hard_Button.SetActive(true);
        Return_GameModeSelect_Button.SetActive(true);
    }

    // "Return_GameModeSelect_Button"押下時にモードとオプションボタンを表示
    public static void Return_GameModeSelect_Button_Event()
    {
        PressButton_Event();
    }
}
