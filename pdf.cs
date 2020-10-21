using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pdf : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //Opens Pdf
            Application.OpenURL("https://drive.google.com/open?id=1cZCnJ34ZqNT0ws_ErkVd5J-Eb9sG1sr_");
        }
    }
}
    