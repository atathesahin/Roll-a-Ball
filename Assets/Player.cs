using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    public float speed;
    private Rigidbody rigidBody;
    public Text countText;
    public Text winText;
    private int count;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = " ";
    }
    void setCountText()
    {
        countText.text = "Count : " + count.ToString();
        if(count >= 10)
        {
            winText.text = "You Win";
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        rigidBody.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
    }
}
