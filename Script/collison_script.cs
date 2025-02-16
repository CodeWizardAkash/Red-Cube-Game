using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
// using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
// using UnityEngine.UI;
// using UnityEngine.SocialPlatforms.Impl;

public class collison_script : MonoBehaviour
{
    // private void OnCollisionEnter(Collision other)
    // {
    //     // Debug.Log(other.gameObject.name);
    //     if(other.gameObject.tag == "Collectable")
    //     {
    //         Destroy(other.gameObject);
    //     }
    // }
    public PlayerScript playerscript;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    // public ScoreText score;
    // public Score score;
    
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Collectable")
        {
            
            audioSource.Play();
            Destroy(other.gameObject);
            score_script.instance.myScore +=1;
            
            // score_script.instance.AddScore(val);
        }
    }
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Obstacles"){
            audioSource1.Play();
            playerscript.enabled = false;
            GameController.instance.GameOver();
        }
    }
}
