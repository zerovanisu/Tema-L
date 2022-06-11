using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HANTEI : MonoBehaviour
{
    public bool Eneming;

    public GameObject Enemy;

    private void Start()
    {
        Enemy = null;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Eneming = true;
            Enemy = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Eneming = false;
            Enemy = null;
        }
    }
}
