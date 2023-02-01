using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public TMP_Text tmpScore;
    public TMP_Text tmpBestScore;
    public TMP_Text tmpStage;
    public TMP_Text tmpBonusScore;

    public static int score;
    public static int bestScore;
    public static int stageCount;
    public static int bonusScore;



    public GameObject gameOverTxtobj = default;
    public GameObject scoreObj = default;
    public GameObject bestScoreTxtobj = default;

    private const string SCENE_NAME = "SampleScene";
    private const string BEST_SCORE = "bestscore";
    private float _score = default;
    private bool isGameOver = false;

    void Update()
    {
        tmpScore.text = string.Format("1P - {0:D6}", score);
        tmpBestScore.text = string.Format("HI - {0:D6}", bestScore);
        tmpStage.text = string.Format("Stage - {0:D2}", stageCount);
        tmpBonusScore.text = string.Format("<color=#800020>BONUS</color> - {0:D4}",bonusScore);
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverTxtobj.SetActive(true);

        // BestTime 키로 저장된 이전까지의 최고 기록 가져오기
        float bestscore = PlayerPrefs.GetFloat(BEST_SCORE);

        // 이전까지의 최고 기록보다 현재 생존 시간이 더 긴 경우
        if (bestscore < _score)
        {
            //플레이어 프리팹스에 베스트 타임을 갱신해서 저장한다.
            bestscore = score;
            PlayerPrefs.SetFloat(BEST_SCORE, bestscore);
        }       // if: 현재 surviveTime이 bestTime 보다 큰 경우 
        //최고 기록을 텍스트에 갱신한.
        Util.SetTmpText(bestScoreTxtobj,
            $"Best Score : {Mathf.FloorToInt(bestscore)}");
    }       //EndGame()
}
