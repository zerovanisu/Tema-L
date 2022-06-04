using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager : MonoBehaviour
{
    [Header("流れる速度")]
    [SerializeField]
    float Speed;

    [Header("もらえる得点")]
    [SerializeField]
    int Score;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;
    }
}
