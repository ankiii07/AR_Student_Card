using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wattsapp : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
        Application.OpenURL("https://chat.whatsapp.com/CsKvB0rn7HMDS8fcvDMukE");
    }
}
