using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text score_Lable;
    void Update()
    {
        int scoreInt = (int)gameObject.transform.position.z;
        score_Lable.text = scoreInt.ToString();
    }
}
