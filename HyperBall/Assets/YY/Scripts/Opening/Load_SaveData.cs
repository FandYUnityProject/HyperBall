/* -クラスの説明-
 * =======================================================
 *  Load_SaveData.cs
 *  作成日：2016/1/23
 *  作成者：Yamaguchi Yohei
 *
 * 【概要】
 *  ゲーム開始初期処理後、セーブデータをロードする。
 ========================================================== */

using UnityEngine;

public class Load_SaveData : MonoBehaviour {

    private int _SaveData_Clear_EasyStage;
    private int _SaveData_Clear_NormalStage;
    private int _SaveData_Clear_HardStage;

    private int _SaveData_Socre_EasyStage;
    private int _SaveData_Socre_NormalStage;
    private int _SaveData_Socre_HardStage;

    private int _SaveData_Time_EasyStage;
    private int _SaveData_Time_NormalStage;
    private int _SaveData_Time_HardStage;

    void Start () {
        
        DebugInfo_Manager.DebugInfo_Update("\n===セーブデータリスト===");

        // ゲーム音量のロード
        DebugInfo_Manager.DebugInfo_Update("\nゲーム音量\n-----------");
        DebugInfo_Manager.DebugInfo_Update("MasterVolume:" + PlayerPrefs.GetInt("Master_Volume"));
        DebugInfo_Manager.DebugInfo_Update("BGM_Volume  :" + PlayerPrefs.GetInt("BGM_Volume"));
        DebugInfo_Manager.DebugInfo_Update("SE_Volume   :" + PlayerPrefs.GetInt("SE_Volume"));

        DebugInfo_Manager.DebugInfo_Update("\n各ステージのセーブデータ\n-----------");
        for (int i = 1; i <= 30; i++)
        {
            // クリアフラグのロード
            _SaveData_Clear_EasyStage   = PlayerPrefs.GetInt("isClear_EasyStage_");
            _SaveData_Clear_NormalStage = PlayerPrefs.GetInt("isClear_NormalStage_");
            _SaveData_Clear_HardStage   = PlayerPrefs.GetInt("isClear_HardStage_");

            // クリアスコアのロード
            _SaveData_Socre_EasyStage   = PlayerPrefs.GetInt("Score_EasyStage_");
            _SaveData_Socre_NormalStage = PlayerPrefs.GetInt("Score_NormalStage_");
            _SaveData_Socre_HardStage   = PlayerPrefs.GetInt("Score_HardStage_");

            // クリアタイムのロード
            _SaveData_Time_EasyStage   = PlayerPrefs.GetInt("Time_EasyStage_");
            _SaveData_Time_NormalStage = PlayerPrefs.GetInt("Time_NormalStage_");
            _SaveData_Time_HardStage   = PlayerPrefs.GetInt("Time_HardStage_");
            
            DebugInfo_Manager.DebugInfo_Update("ステージ" + i
                + " 【Easy:"   + _SaveData_Clear_EasyStage   + ", Score:" + _SaveData_Socre_EasyStage   + ", Time:" + _SaveData_Time_EasyStage   + "】"
                + " 【Normal:" + _SaveData_Clear_NormalStage + ", Score:" + _SaveData_Socre_NormalStage + ", Time:" + _SaveData_Time_NormalStage + "】"
                + " 【Hard:"   + _SaveData_Clear_HardStage   + ", Score:" + _SaveData_Socre_HardStage   + ", Time:" + _SaveData_Time_HardStage   + "】"
            );
        }
    }
}
