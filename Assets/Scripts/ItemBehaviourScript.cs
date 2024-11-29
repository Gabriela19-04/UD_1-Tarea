using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviourScript : MonoBehaviour
{
    public GameBehaviour GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item colected!");

            GameManager.Items += 1;
        }

    }
}

