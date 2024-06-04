using UnityEngine;

public class Fist : MonoBehaviour
{
    private new Collider collider;
    private GameObject rootObject;


    private void Awake()
    {
        collider = GetComponent<Collider>();
        rootObject = transform.root.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        collider = other;
    }

    private void Start ()
   {
      
   }
   

}