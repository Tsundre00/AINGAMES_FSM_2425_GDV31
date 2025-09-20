using UnityEngine;

public class SimpleFSM : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;

    
    private StateMachineBehaviour currentState;

}
