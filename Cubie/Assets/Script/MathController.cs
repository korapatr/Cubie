using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathController : MonoBehaviour {
    private float a, b, c;
    private float answer;
    public Text valueA, valueB, scoreTxt, prob;
    public static int staticScore;

    private float localcAnswer; //เก็บตำแหน่งคำตอบที่ถูก
    public int score;
    public GameObject[] choiceBtn;//จำนวน choice 4 ตัว
    public string tagBtn; //ตัวที่บ่งบอกว่า choice ไหนถูกหรือผิด
    public static MathController instance;

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
        // PlayerPrefs.Save();
    }
    public void AdditionMethod() {
        a = Random.Range(1, 51);//min,max
        b = Random.Range(1, 51);
        valueA.text = "" + a;
        valueB.text = "" + b;
        
        c = Random.Range(0, 2);
        if (c == 0) {
            prob.text = "TRIANGLE";
            answer = (a * b)/2;
        } else {
            prob.text = "RECTANGLE";
            answer = a * b;
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
                choiceBtn[i].GetComponentInChildren<Text>().text = "" + Random.Range(1,2602);
                while (choiceBtn[i].GetComponentInChildren<Text>().text == "" + answer) {
                    choiceBtn[i].GetComponentInChildren<Text>().text = "" + Random.Range(1,2602);
                }
                //1,2,3,4
                //2
                //1,3,4 =
            }
        }
    }
}
