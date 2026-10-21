using UnityEngine;

public class MoveCommand : ICommand
{
    private readonly Transform _transform;

    private readonly Vector3 _movement;

    public MoveCommand(Transform transform, Vector3 movement)
    {
        _transform = transform;
        _movement = movement;
    }

    public void Execute()
    {
        _transform.position += _movement;
    }

    public void Undo()
    {
        _transform.position -= _movement;
    }
}