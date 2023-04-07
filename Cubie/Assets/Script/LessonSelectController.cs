using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonSelectController : MonoBehaviour
{
    // Start is called before the first frame update
    public void goVolumePage() {
        Application.LoadLevel("VolumePage");
    }

    public void goHomePage() {
        Application.LoadLevel("Home");
    }

    public void goAreaPage() {
        Application.LoadLevel("AreaPage");
    }
}

