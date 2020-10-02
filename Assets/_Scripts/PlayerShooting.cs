using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    const string verticalFire = "VerticalFire";
    const string horizontalFire = "HorizontalFire";
    [SerializeField] GameObject bullet;
    Transform parent;
    Vector3 aiming;
    
    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        aiming = new Vector3(Input.GetAxis(  horizontalFire), Input.GetAxis(  verticalFire), 0);
        transform.rotation = new Quaternion(aiming);
        
    }
}
