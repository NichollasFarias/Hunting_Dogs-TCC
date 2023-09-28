using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillWave : MonoBehaviour
{
    public GameObject Shoot;
    public Transform local;
    public MvtPlayer Player;
    public float velocity = 6000f;
    public float time = 0;

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        if (time <= 0 && Input.GetButtonDown("Wave"))
        {
            GetComponent<Animator>().SetTrigger("Wave");
            Player.enabled = false;
        }

    }

    public void Wave()
    {
        GameObject tirodisparado = (GameObject)Instantiate(Shoot, local.position, Quaternion.identity);
        time = 2f;
    }

    public void CanMove()
    {
        Player.enabled = true;
    }
}
