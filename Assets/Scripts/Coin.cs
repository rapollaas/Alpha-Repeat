using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public string targetTag;
    public int coinValue = 1;

    //audio for when picked up
    public AudioSource audio;
    public GameObject model;
    public Collider collide;

    public LevelManager levelManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the tag of the object we collide with matches the tag we set to collide with then call the pick up method
        if(other.tag == targetTag)
        {
            PickUp();
        }
    }

    //pick up method calls LevelManager to add coinvalue to the score, plays audio, disables the object, disables collider
    private void PickUp()
    {
        levelManager.AddScore(coinValue);
        audio.Play();
        model.SetActive(false);
        GetComponent<Collider>().enabled = false;
    }
    
}
