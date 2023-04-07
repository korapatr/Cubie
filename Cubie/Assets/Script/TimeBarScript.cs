using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBarScript : MonoBehaviour
{

    public Transform filbar;
    public float currentTime;//แสดงค่าเวลา
    public float delay = 0.06f;
    public static TimeBarScript instance;

    void Start()
    {
        currentTime = 1;
    }
    private void Awake() {
        MakeInstance();
    }
    void MakeInstance() {
        if (instance==null) {
            instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= delay*Time.deltaTime;// ลดค่าตัว currenttime
        filbar.GetComponent<Image>().fillAmount = currentTime;
        if (currentTime<0.1f) {
            Application.LoadLevel("EndGameScene");
        }
    }
}
