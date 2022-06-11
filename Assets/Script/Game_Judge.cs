using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Judge : MonoBehaviour
{
    public GameObject Clear_UI;

    public GameObject Over_UI;

    [Header("‰¹Šy‚ÌŠÔ")]
    [SerializeField]
    float AudioTime = 52;

    [Header("Œ»İ‚ÌŠÔ")]
    [SerializeField]
    float x;

    public bool G_Clear, G_Over;

    void Start()
    {
        Clear_UI.SetActive(false);
        Over_UI.SetActive(false);
        x = AudioTime;
    }

    void Update()
    {
        x -= Time.deltaTime;

        if(x <= 0)
        {
            G_Clear = true;
        }

        if(G_Clear == true && G_Over == false)
        {
            Clear_UI.SetActive(true);
        }
        if (G_Clear == false && G_Over == true)
        {
            Over_UI.SetActive(true);
        }
    }
}
