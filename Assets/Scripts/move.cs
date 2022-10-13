using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject _Pos;
    private Vector3 _EndPos;
    private Vector3 _CurPos;
    private int _velocity;
    private int _distance;
    public int _Velocity 
    {
        get
        {
            return _Velocity;
        }
        set
        {
            if (!(value < 1 ))
            {
                _velocity = value;
            }
            else
            {
                _velocity = 1;
            }
        }
    }
    public int _Distance 
    {
        get
        {
            return _Distance;
        }
        set
        {
            if (!(value < 1 ))
            {
                _distance = value;
            }
            else
            {
                _distance = 1;
            }
        }
    }
    private void Start()
    {
        _CurPos = _Pos.transform.position;
        _EndPos = _CurPos + new Vector3(_distance, 0, 0);
    }
    void Update()
    {
        Move(_velocity, _distance);
    }
    public void Move(int _Velocity, int _Distance)
    {
        if (_Pos.transform.position != _EndPos)
        {
            _Pos.transform.position = Vector3.MoveTowards(_Pos.transform.position, _EndPos, Time.deltaTime * _velocity);
        }
        else
        {
            Destroy(_Pos);
        }
    }
}
