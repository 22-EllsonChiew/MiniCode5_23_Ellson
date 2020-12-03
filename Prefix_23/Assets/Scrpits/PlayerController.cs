using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed;
    float energyCount = 0;

    public Text EnergyCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        

        if (Input.GetKey(KeyCode.A))
        {
            
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Add"))
        {
            energyCount += 5;
            Destroy(collision.gameObject);
            EnergyCount.GetComponent<Text>().text = "Energy: " + energyCount.ToString();
        }
        else if(collision.gameObject.CompareTag("Minus"))
        {
            energyCount -= 5;
            Destroy(collision.gameObject);
            EnergyCount.GetComponent<Text>().text = "Energy: " + energyCount.ToString();
        }
    }



}
