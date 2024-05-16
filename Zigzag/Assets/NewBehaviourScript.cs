using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject cube_1;
    public int jump;
    public Material cube_color;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cube_1.transform.position += new Vector3(0, jump, 0);
            cube_1.transform.localScale *= 2;


           cube_1.GetComponent<MeshRenderer>().material = cube_color;
        }
    }

    // Start is called before the first frame update
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
