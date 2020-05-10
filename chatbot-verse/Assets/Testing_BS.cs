using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing_BS : MonoBehaviour
{

    //Variable

    private Text thisTextComponment;
    public Text otherTextComponent;

    public string URL;





    // Start is called before the first frame update
    void Start()
    {
        thisTextComponment = this.GetComponent<Text>();

    }

}
