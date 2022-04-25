using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalTrigger : MonoBehaviour
{ 
    public GameObject modalWindow;
    // Start is called before the first frame update
    public bool state = false;
    void Start()
    {
        modalWindow = GameObject.FindWithTag("modalWindow");
        modalWindow.SetActive(state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void Clicked(Button button)
    {
        state = !state;
        modalWindow.SetActive(state);
    }
}
