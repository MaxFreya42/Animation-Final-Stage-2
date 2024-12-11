using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour {

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
    public GameObject Cam6;
    public GameObject Cam7;
    public GameObject GameCam;

    public GameObject Actor;
    public GameObject Player;


    void Start()
    {
        StartCoroutine (TheSequence());
    }

    IEnumerator TheSequence ()
    {
        yield return new WaitForSeconds(1.7f);
        Cam2.SetActive (true);
        Cam1.SetActive (false);
        yield return new WaitForSeconds(0.9f);
        Cam3.SetActive (true);
        Cam2.SetActive (false);
        yield return new WaitForSeconds(1.5f);
        Cam3.SetActive(false);
        yield return new WaitForSeconds(6.84f);
        Cam4.SetActive(false);
        yield return new WaitForSeconds(4.625f);
        Cam6.SetActive(true);
        Cam5.SetActive(false);
        yield return new WaitForSeconds(1.625f);
        Cam7.SetActive(true);
        Cam6.SetActive(false);
        yield return new WaitForSeconds(2.1f);
        Actor.SetActive(false);
        Player.SetActive(true);
        GameCam.SetActive(true);
        Cam7.SetActive(false);
    }
    
}
