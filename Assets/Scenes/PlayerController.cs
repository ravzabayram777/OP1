using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;
private Vector3 _startPosition;
    private void Start()
    {
        _startPosition = transform.position;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CommandInvoker.ExecuteCommand(new MoveCommand(transform, Vector3.up * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CommandInvoker.ExecuteCommand(new MoveCommand(transform, Vector3.down * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            CommandInvoker.ExecuteCommand(new MoveCommand(transform, Vector3.left * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            CommandInvoker.ExecuteCommand(new MoveCommand(transform, Vector3.right * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            CommandInvoker.UndoCommand();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            CommandInvoker.Instance.StartReplay(transform, _startPosition);
        }
    }
}