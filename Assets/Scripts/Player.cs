using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Transform pas1;
    public Transform pas2;
    public Transform pas3;
    public Transform[] pasy;
	void Start () {
        //pasy = new Transform[pas1, pas2, pas3];
	}
	
	void Update () {
        if (Input.anyKeyDown) {
            
            float touchPosition = Input.mousePosition.y;
            System.Console.WriteLine(touchPosition);
            Transform pas;
            if (touchPosition > Screen.height / 2)
                pas = pas1;
            else
                pas = pas3;
            Vector3 pos = transform.position;
            pos.y = pas.transform.position.y;
            transform.position = pos;
        }
	}
}
