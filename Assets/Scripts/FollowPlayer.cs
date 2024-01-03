
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;

    void Update()
    {

        if (Player.transform.position.y > transform.position.y || Player.transform.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,Player.position.y,transform.position.z);
        }
        

        
    }
}
