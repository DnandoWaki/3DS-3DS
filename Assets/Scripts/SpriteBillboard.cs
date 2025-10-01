using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    [SerializeField] bool freezeXZAxis = true;
    // Update is called once per frame
    void Update()
    {
        //metodo de movimento y
        if(freezeXZAxis)
        {
         transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
            return;
        }
        transform.rotation = Camera.main.transform.rotation;
    }
}
