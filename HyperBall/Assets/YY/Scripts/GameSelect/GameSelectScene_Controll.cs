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

public class GameSelectScene_Controll : MonoBehaviour {

    // ＳＥ
    private GameObject SE_Source;
    public static AudioSource GameSelect_SeSource;

    // ＵＩ関連
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

        // SE取得
        SE_Source = GameObject.Find("SE_Source");
        GameSelect_SeSource = SE_Source.GetComponent<AudioSource>();

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
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(0);
        GameSelect_SeSource.Play();

        All_HideImage();
        ChallengeMode_Button.SetActive(true);
        FreeMode_Button.SetActive(true);
        Option_Button.SetActive(true);
    }

    // "ChallengeMode_Button"押下時にゲームレベルボタンを表示
    public static void ChallengeMode_Button_Event() {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(0);
        GameSelect_SeSource.Play();

        All_HideImage();
        ChallengeModeTitle_Image.SetActive(true);
        Easy_Button.SetActive(true);
        Normal_Button.SetActive(true);
        Hard_Button.SetActive(true);
        Return_GameModeSelect_Button.SetActive(true);
    }

    // "FreeMode_Button"押下時にEasyStage_1に遷移
    public static void FreeMode_Button_Event() {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(2);
        GameSelect_SeSource.Play();

        SceneTransition_Controll.NextScene_Transition("FreeMode");
    }

    // "Easy_Button"押下時にEasyStage_1に遷移
    public static void Easy_Button_Event()  {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(2);
        GameSelect_SeSource.Play();

        SceneTransition_Controll.NextScene_Transition("EasyStage_1");
    }

    // "Normal_Button"押下時にNormalStage_1に遷移
    public static void Normal_Button_Event() {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(2);
        GameSelect_SeSource.Play();

        SceneTransition_Controll.NextScene_Transition("NormalStage_1");
    }

    // "Hard_Button"押下時にHardStage_1に遷移
    public static void Hard_Button_Event()
    {
        // 決定音に変更して音を鳴らす
        SE_Controll.SE_Change(2);
        GameSelect_SeSource.Play();

        SceneTransition_Controll.NextScene_Transition("HardStage_1");
    }

    // "Return_GameModeSelect_Button"押下時にモードとオプションボタンを表示
    public static void Return_GameModeSelect_Button_Event() {
        // キャンセル音に変更して音を鳴らす
        SE_Controll.SE_Change(1);
        GameSelect_SeSource.Play();

        All_HideImage();
        ChallengeMode_Button.SetActive(true);
        FreeMode_Button.SetActive(true);
        Option_Button.SetActive(true);
    }
}
