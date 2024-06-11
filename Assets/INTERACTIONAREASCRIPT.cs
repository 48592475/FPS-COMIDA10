using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class INTERACTIONAREASCRIPT : MonoBehaviour
{
    public Text puntosTexto;
    public int Puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntosTexto.text = Puntos.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        PickUpScript pickUp;
        pickUp = other.GetComponent<PickUpScript>();
        Puntos += pickUp.Puntos1;
        if (pickUp.Comida == true)
        {
            Destroy(other.gameObject);
        }
    }
}
