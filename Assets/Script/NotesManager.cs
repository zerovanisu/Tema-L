using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager : MonoBehaviour
{
    [Header("����鑬�x")]
    [SerializeField]
    float Speed;

    [Header("���炦�链�_")]
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
