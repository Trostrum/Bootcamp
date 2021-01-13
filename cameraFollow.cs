using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public float offset;
    

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x , gameObject.transform.position.y , player.transform.position.z + offset);
    }
}
