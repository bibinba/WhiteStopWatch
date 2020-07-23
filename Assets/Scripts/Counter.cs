using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Counter : MonoBehaviour
{

    public Text Text_mmsss;    
    public Text Text_ff;                         //デジタルテキストの取得用変数
    private float movetime;                          //稼働時間用変数
    private bool moving;                             //ストップウォッチ稼働フラグ

void Start(){
    Text_mmsss.text = "00:00";
    Text_ff.text = ".00";
}
    void Update()
    {
        //スタートボタンを押したら稼働する
        if (moving)
        {
            //ストップウォッチ稼働時間
            movetime += Time.deltaTime;
            //デジタルテキスト表示
            TimeSet();
        }
    }


    //各ボタンの機能
    //ストップウォッチのスタート
    public void WatchStart()
    {
        moving = true;
    }
    //ストップウォッチのストップ
    public void WatchStop()
    {
        moving = false;
    }
    //ストップウォッチのリセット
    public void TimeReset()
    {
        //稼働中はリセットを無効にする
        if (moving)
        {
            return;
        }

        movetime = 0;
        Text_mmsss.text = "00:00";
        Text_ff.text = ".00";
    }


    //時・分・秒の表示方法を指定
    private void TimeSet()
    {
        //各種変数
        string timetext_mmss = null;
        int provtime = 0;
        int twodecimal = 0;

        //稼働時間から小数点以下を取り出して二桁の整数にする
        provtime = Mathf.FloorToInt(movetime);
        twodecimal = Mathf.FloorToInt((movetime - provtime) * 100);

        //TimeSpanを使って　00：00：00.　の文字列を作る
        TimeSpan ts = new TimeSpan(0, 0, provtime);
        Text_mmsss.text = ts.ToString(@"mm\:ss");
        //切り離した小数点以下を文字化する
        Text_ff.text = "."+twodecimal.ToString("D2");

    }
}