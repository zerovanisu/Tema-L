using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    [Header("プレイヤーのジャンプ力")]
    [SerializeField]
    private float jumpForce = 350f;

    private int jumpCount = 0;

    public GameObject Enter1, Enter2;

    public bool Eneming1, Eneming2;

    public int Player_Life;

    [SerializeField]
    GameObject Canvas_UI;

    [SerializeField]
    AudioClip Jamp, Atc, Dmg;

    AudioSource ad;

    [SerializeField]
    GameObject[] lifeimg;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        ad = GetComponent<AudioSource>();
    }

    void Update()
    {
        Eneming1 = Enter1.GetComponent<HANTEI>().Eneming;
        Eneming2 = Enter2.GetComponent<HANTEI>().Eneming;

        if (Input.GetKeyDown(KeyCode.Space) && this.jumpCount < 1)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            jumpCount++;

            ad.PlayOneShot(Jamp);
        }

        Attack();

        if(Player_Life == 0)
        {
            Canvas_UI.GetComponent<Game_Judge>().G_Over = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            LifeDown(Player_Life);
            Player_Life -= 1;
            Debug.Log("敵に触れたよ");
            ad.PlayOneShot(Dmg);
        }

        if (collision.gameObject.tag == "Trap")
        {
            LifeDown(Player_Life);
            Debug.Log("罠を踏んだよ");
            ad.PlayOneShot(Dmg);
        }
    }

    void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(Eneming1 == true)
            {
                Debug.Log("敵を倒した");
                Destroy(Enter1.GetComponent<HANTEI>().Enemy);
                ad.PlayOneShot(Atc);
            }
            else if(Eneming1 == false && Eneming2 == true)
            {
                Debug.Log("タイミングが合ってないよ");
                Player_Life -= 1;
            }
        }
    }

    void LifeDown(int x)
    {
        x -= 1;

        if(Player_Life > 0)
        {
            Destroy(lifeimg[x]);
        }
    }
}
