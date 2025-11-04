using UnityEngine;

// Write the BatW6 class here.

public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed = 3f;
    [SerializeField] private float _chaseDistance = 5f; // ¾àÀëãÐÖµ
    private bool _isChasing;

    private void Update()
    {
        if (_player == null) return;

        float distance = Vector3.Distance(transform.position, _player.position);

        if (distance < _chaseDistance)
        {
            StartChasing();
        }
        else
        {
            StopChasing();
        }

        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _player.position,
                _speed * Time.deltaTime
            );
        }
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
