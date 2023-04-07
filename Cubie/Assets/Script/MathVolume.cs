using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathVolume : MonoBehaviour {
    private float a, b, c, d;
    private float answer;
    public Text valueA, valueB,valueC, scoreTxt, prob;
    private float localcAnswer; //เก็บตำแหน่งคำตอบที่ถูก
    public int score;
    public static int staticScore;
    public GameObject[] choiceBtn;//จำนวน choice 4 ตัว
    public string tagBtn; //ตัวที่บ่งบอกว่า choice ไหนถูกหรือผิด
    public static MathVolume instance;

    private void Awake() {
        MakeInstance();
    }

    void MakeInstance() {
        if (instance == null) {
            instance = this;
        }
    }

    void Start() {
        AdditionMethod();
    }


    void Update() {
        tagBtn = localcAnswer.ToString();
        scoreTxt.text = "" + score;
        staticScore = score;
        PlayerPrefs.SetInt("score", score);
    }
    public void AdditionMethod() {
        a = Random.Range(1, 21);//min,max
        b = Random.Range(1, 21);
        c = Random.Range(1,21);
        valueA.text = "" + a;
        valueB.text = "" + b;
        valueC.text = "" + c;
        
        d = Random.Range(0, 2);
        if (d == 0) {
            prob.text = "RECTANGULAR PRISM";
            answer = a * b * c;
        } else {
            prob.text = "RECTANGLE PRRAMID";
            answer = (a * b * c)/3;
        }

        // สุ่มตำแหน่งที่จะใส่คำตอบที่ถูกต้องลงไป
        localcAnswer = Random.Range(0,choiceBtn.Length); // ตำแหน่งของปุ่มคำตอบที่ถูก
        //สุ่มปุ่ม choice
        for (int i = 0; i < choiceBtn.Length; i++) {
            // เพื่อเปลี่ยนตัวเลขด้านใน
            //ตำแหน่งตรงกับ localofAnswer
            if (i == localcAnswer) {
                // คำตอบที่ถูกที่จะแสดงในปุ่ม
                choiceBtn[i].GetComponentInChildren<Text>().text = "" + answer;
            } else {
                //คำตอบที่ผิดที่จะแสดงในปุ่ม
                choiceBtn[i].GetComponentInChildren<Text>().text = "" + Random.Range(1,9500);
                while (choiceBtn[i].GetComponentInChildren<Text>().text == "" + answer) {
                    choiceBtn[i].GetComponentInChildren<Text>().text = "" + Random.Range(1,9500);
                }
            }
        }
    }
}
